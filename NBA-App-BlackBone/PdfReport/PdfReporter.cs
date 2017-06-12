using iTextSharp.text;
using iTextSharp.text.pdf;
using NbaBlackBone.Persistance;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.PdfReport
{
    class PdfReporter : IReporter
    {
        //public const string FilePaths = @"C:/Users/admin/Desktop/Pdf-Reports/Conference,Team,Player,Stats-report-{0}.pdf";
        //private const string Devision = "Devison";
        //private const string TeamName = "Team";
        //private const string Player = "Player";
        //private const string PdfFont = "Times New Roman";


        //public void GetValuesForReport()
        //{
        //using (var unitOfWork = new UnitOfWork(new NbaContext()))
        //{
        //    var allConference = unitOfWork.Conference.GetAll();
        //    var top6Teams = unitOfWork.Teams.GetTopTeams(10);
        //    var top6Players = unitOfWork.Players.GetTopPlayers(10);           
        //}
        //}
        private NbaContext dbContext;

        public PdfReporter(NbaContext context)
        {
            this.dbContext = context;
        }

        public void GenerateReport(string path)
        {
            Directory.CreateDirectory(path);

            var filePath = path + "/Team.pdf";
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
                PdfPCell cell = new PdfPCell(new Phrase("NBA report", titleFont));
                cell.Colspan = 5;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                var tableHeaders = new List<string>() { "Team", "Minutes", "OffRtg", "DeffRtg", "OveralRating" };
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
                    minutes.AddElement(new Phrase(off.ToString()));
                    var deff = te.DeffRtg;
                    minutes.AddElement(new Phrase(deff.ToString()));
                    var over = te.OffRtg;
                    minutes.AddElement(new Phrase(over.ToString()));

                    table.AddCell(minutes);
                    table.AddCell(team);
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
