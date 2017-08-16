using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace AUSClaims_Prod_NodeOneRefresh.Pages
{
    class AUSClaims_Prod_CachePage_NodeOne
    {
        private readonly BrowserWindow browser;
        private HtmlHyperlink clearAllCachesButton;

        public AUSClaims_Prod_CachePage_NodeOne(BrowserWindow BrowserWindow)
        {
            browser = BrowserWindow;
        }

        public HtmlHyperlink clearAllCaches_Button
        {
            get
            {
                clearAllCachesButton = new HtmlHyperlink(browser);
                clearAllCachesButton.TechnologyName = "Web";
                clearAllCachesButton.SearchProperties.Add("InnerText", "Clear All Caches");
                clearAllCachesButton.SearchProperties.Add("TagInstance", "1");
                return clearAllCachesButton;
            }
        }
    }
}
