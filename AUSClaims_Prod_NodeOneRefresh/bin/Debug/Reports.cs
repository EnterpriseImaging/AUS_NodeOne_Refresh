using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Web;

namespace AUSClaims_Prod_NodeOneRefresh
{
    class Reports
    {
        public static void CreateCSVOutputFile(string testname, string testresult, string testdescription, string expectedresult, string evidencetype, string evidencelink, string executedby)
        {

            string filepath = @"\\rgare\opentext\stlprod\Case360_capturebroker\Case360_Docs\Capture\Claims\AUS\RegressionTesting\testresult.log";
            string delimiter = ",";

            string[][] output = new string[][]
            {
                new string[] {"TestName", "TestDescription", "ExpectedResult", "EvidenceType", "EvidenceLink", "ExecutedBy", "TestRunDate", "TestResult"},
                new string[] {testname, testdescription, expectedresult, evidencetype, evidencelink, executedby, DateTime.Now.ToString(), testresult}
            };

            int length = output.GetLength(0);
            StringBuilder stringBuilder = new StringBuilder();
            for (int index = 0; index < length; index++)
                stringBuilder.AppendLine(string.Join(delimiter, output[index]));

            if (!File.Exists(filepath))
            {
                File.WriteAllText(filepath, stringBuilder.ToString());
            }
            else
            {
                File.AppendAllText(filepath, stringBuilder.ToString());
            }
        }
    }
}
