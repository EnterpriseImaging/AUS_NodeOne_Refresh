using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace AUSClaims_Prod_NodeOneRefresh.Pages
{
    class AUSClaims_Prod_ServersPage_NodeOne
    {
        private readonly BrowserWindow browser;
        private HtmlHyperlink serverTwoPortMenu;
        

        public AUSClaims_Prod_ServersPage_NodeOne(BrowserWindow BrowserWindow)
        {
            browser = BrowserWindow;
        }

        public HtmlHyperlink ServerTwoPortMenu
        {
            get
            {
                serverTwoPortMenu = new HtmlHyperlink(browser);
                serverTwoPortMenu.TechnologyName = "Web";
                serverTwoPortMenu.SearchProperties.Add("TagInstance", "3");
                serverTwoPortMenu.SearchProperties.Add("Title", "Update Server Capacity");
                return serverTwoPortMenu;
            }
        }
    }
}
