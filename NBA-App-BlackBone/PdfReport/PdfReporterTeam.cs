using iTextSharp.text;
using iTextSharp.text.pdf;
using NbaBlackBone.Persistance;
using System.Collections.Generic;
using System.IO;

namespace NBABlackBone.PdfReport
{
    class PdfReporterTeam : IReporter
    {
        private NbaContext dbContext;

        public PdfReporterTeam(NbaContext context)
        {
            this.dbContext = context;
        }

        public void GenerateReport(string path)
        {
            Directory.CreateDirectory(path);

            var filePath = path + "/Team-Report.pdf";
            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document doc = new Document();

                PdfWriter writer = PdfWriter.GetInstance(doc, stream);
                doc.Open();

                var columns = 5;
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var table = new PdfPTable(columns);
                PdfPCell cell = new PdfPCell(new Phrase("Team report", titleFont));
                cell.Colspan = 5;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                var tableHeaders = new List<string>() { "Team", "Minutes", "OffRtg", "DeffRtg", "OveralRating"};
                for (int i = 0; i < columns; i++)
                {
                    var headerCell = new PdfPCell(new Phrase(tableHeaders[i], boldFont));
                    headerCell.HorizontalAlignment = 1;
                    table.AddCell(headerCell);
                }

                foreach (var te in this.dbContext.Teams)
                {
                    var team = new PdfPCell();
                    var minutes = new PdfPCell();
                    var offrtg = new PdfPCell();
                    var deffrtg = new PdfPCell();
                    var overal = new PdfPCell();


                    var tname = te.Name;
                    team.AddElement(new Phrase(tname));
                    var min = te.Minutes;
                    minutes.AddElement(new Phrase(min.ToString()));
                    var off = te.OffRtg;
                    offrtg.AddElement(new Phrase(off.ToString()));
                    var deff = te.DeffRtg;
                    deffrtg.AddElement(new Phrase(deff.ToString()));
                    var over = te.OverallRtg;
                    overal.AddElement(new Phrase(over.ToString()));

                    table.AddCell(team);
                    table.AddCell(minutes); 
                    table.AddCell(offrtg);
                    table.AddCell(deffrtg);
                    table.AddCell(overal);
                }

                doc.Add(table);
                doc.Close();
            }
        }
    }
}
