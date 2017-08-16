using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace AUSClaims_Prod_NodeOneRefresh.Pages
{
    class AUSClaims_Prod_ConfigPage_NodeOne
    {
        private readonly BrowserWindow browser;
        private HtmlCustom actionsDropdown;
        private HtmlHyperlink customLink;

        public AUSClaims_Prod_ConfigPage_NodeOne(BrowserWindow BrowserWindow)
        {
            browser = BrowserWindow;
        }

        public HtmlCustom ActionsDropdown
        {
            get
            {
                actionsDropdown = new HtmlCustom(browser);
                actionsDropdown.SearchProperties.Add("TagInstance", "14");
                actionsDropdown.SearchProperties.Add("InnerText", "Actions");
                return actionsDropdown;
            }
        }

        public HtmlHyperlink CustomLink
        {
            get
            {
                customLink = new HtmlHyperlink(browser);
                customLink.SearchProperties.Add("TagInstance", "5");
                customLink.SearchProperties.Add("InnerText", "Custom");
                return customLink;
            }
        }
    }
}
