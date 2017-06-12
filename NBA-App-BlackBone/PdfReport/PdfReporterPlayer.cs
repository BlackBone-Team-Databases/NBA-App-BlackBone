using iTextSharp.text;
using iTextSharp.text.pdf;
using NbaBlackBone.Persistance;
using System.Collections.Generic;
using System.IO;

namespace NBABlackBone.PdfReport
{
    class PdfReporterPlayer : IReporter
    {
        private NbaContext dbContext;
        private int i;

        public PdfReporterPlayer(NbaContext context)
        {
            this.dbContext = context;
        }

        public void GenerateReport(string path)
        {
            Directory.CreateDirectory(path);

            var filePath = path + "/Player-Report.pdf";
            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document doc = new Document();

                PdfWriter writer = PdfWriter.GetInstance(doc, stream);
                doc.Open();

                var columns = 2;
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var table = new PdfPTable(columns);
                PdfPCell cell = new PdfPCell(new Phrase("Player report", titleFont));
                cell.Colspan = 2;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                var tableHeaders = new List<string>() { "Name", "Position" };
                for (int i = 0; i < columns; i++)
                {
                    var headerCell = new PdfPCell(new Phrase(tableHeaders[i], boldFont));
                    headerCell.HorizontalAlignment = 1;
                    table.AddCell(headerCell);
                }

                i = 0;
                foreach (var pl in this.dbContext.Players)
                {
                    var flname = new PdfPCell();
                    var position = new PdfPCell();
                    
                    var fl = pl.FirstLastName;
                    flname.AddElement(new Phrase(fl));
                    var pos = pl.Position;
                    position.AddElement(new Phrase(pos.ToString()));
                    
                    table.AddCell(flname);
                    table.AddCell(position);

                    i++;
                    if (i == 30) break;
                }

                doc.Add(table);
                doc.Close();
            }
        }
    }
}
