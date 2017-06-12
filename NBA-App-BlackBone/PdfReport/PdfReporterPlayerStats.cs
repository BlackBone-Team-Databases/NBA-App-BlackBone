using iTextSharp.text;
using iTextSharp.text.pdf;
using NbaBlackBone.Persistance;
using System.Collections.Generic;
using System.IO;

namespace NBABlackBone.PdfReport
{
    class PdfReporterPlayerStats : IReporter
    {
        private NbaContext dbContext;
        private int i;

        public PdfReporterPlayerStats(NbaContext context)
        {
            this.dbContext = context;
        }

        public void GenerateReport(string path)
        {
            Directory.CreateDirectory(path);

            var filePath = path + "/PlayerStats-Report.pdf";
            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document doc = new Document();

                PdfWriter writer = PdfWriter.GetInstance(doc, stream);
                doc.Open();

                var columns = 4;
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var table = new PdfPTable(columns);
                PdfPCell cell = new PdfPCell(new Phrase("Player report", titleFont));
                cell.Colspan = 4;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                var tableHeaders = new List<string>() { "Minutes", "SimplePossFor", "SimplePointsFor", "SimpleORebFor" };
                for (int i = 0; i < columns; i++)
                {
                    var headerCell = new PdfPCell(new Phrase(tableHeaders[i], boldFont));
                    headerCell.HorizontalAlignment = 1;
                    table.AddCell(headerCell);
                }

                i = 0;
                foreach (var pls in this.dbContext.PlayerStatistics)
                {
                    var minutes = new PdfPCell();
                    var simpleposfor = new PdfPCell();
                    var simplepointsfor = new PdfPCell();
                    var simpleorebfor = new PdfPCell();

                    var min = pls.Minutes;
                    minutes.AddElement(new Phrase(min.ToString()));
                    var sposf = pls.SimplePossFor;
                    simpleposfor.AddElement(new Phrase(sposf.ToString()));
                    var spointsf = pls.SimplePointsFor;
                    simplepointsfor.AddElement(new Phrase(spointsf.ToString()));
                    var srebf = pls.SimpleORebFor;
                    simpleorebfor.AddElement(new Phrase(srebf.ToString()));

                    table.AddCell(minutes);
                    table.AddCell(simpleposfor);
                    table.AddCell(simplepointsfor);
                    table.AddCell(simpleorebfor);

                    i++;
                    if (i == 30) break;
                }

                doc.Add(table);
                doc.Close();
            }
        }
    }
}
