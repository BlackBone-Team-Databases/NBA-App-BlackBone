using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.PdfReport
{
    interface IReporter
    {
        void GenerateReport(string path);
    }
}
