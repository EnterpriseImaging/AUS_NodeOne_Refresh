using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace AUSClaims_Prod_NodeOneRefresh.Pages
{
    class AUSClaims_Prod_CustomConfigPage_NodeOne
    {
        private readonly BrowserWindow browser;
        private HtmlEdit soleCaptureServerValueField;

        public AUSClaims_Prod_CustomConfigPage_NodeOne(BrowserWindow BrowserWindow)
        {
            browser = BrowserWindow;
        }

        public HtmlEdit SoleCaptureServerValueField
        {
            get
            {
                soleCaptureServerValueField = new HtmlEdit(browser);
                soleCaptureServerValueField.SearchProperties.Add("TagInstance", "28");
                soleCaptureServerValueField.SearchProperties.Add("Name", "SOLE_CAPTURE_SERVER");
                return soleCaptureServerValueField;
            }
        }
    }
}
