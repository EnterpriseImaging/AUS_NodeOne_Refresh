using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace AUSClaims_Prod_NodeOneRefresh.Pages
{
    class AUSClaims_Prod_AdminPage_NodeOne
    {
        private readonly BrowserWindow browser;
        private HtmlHyperlink processLink;
        private HtmlHyperlink captureLink;
        private HtmlHyperlink queriesLink;
        private HtmlHyperlink menusLink;
        private HtmlHyperlink fieldsLink;
        private HtmlHyperlink scriptsLink;
        private HtmlHyperlink filestoreLink;
        private HtmlHyperlink casefolderLink;
        private HtmlHyperlink formdataLink;
        private HtmlHyperlink activedirectoryLink;
        private HtmlHyperlink usersLink;
        private HtmlHyperlink rolesLink;
        private HtmlHyperlink ACLsLink;
        private HtmlHyperlink systemMetricsLink;
        private HtmlHyperlink cacheLink;
        private HtmlHyperlink workCalendarLink;
        private HtmlHyperlink repositoriesLink;
        private HtmlHyperlink alertsLink;
        private HtmlHyperlink licenseLink;
        private HtmlHyperlink applicationsLink;
        private HtmlHyperlink serversLink;
        private HtmlHyperlink configurationLink;
        private HtmlHyperlink logLink;

        public AUSClaims_Prod_AdminPage_NodeOne(BrowserWindow BrowserWindow)
        {
            browser = BrowserWindow;
        }

        public HtmlHyperlink ProcessLink
        {
            get
            {
                processLink = new HtmlHyperlink(browser);
                processLink.TechnologyName = "Web";
                processLink.SearchProperties.Add("TagInstance", "8");
                processLink.SearchProperties.Add("InnerText", "Process");
                return processLink;
            }
        }

        public HtmlHyperlink CaptureLink
        {
            get
            {
                captureLink = new HtmlHyperlink(browser);
                captureLink.TechnologyName = "Web";
                captureLink.SearchProperties.Add("TagInstance", "15");
                captureLink.SearchProperties.Add("InnerText", "Capture");
                return captureLink;
            }
        }

        public HtmlHyperlink QueriesLink
        {
            get
            {
                queriesLink = new HtmlHyperlink(browser);
                queriesLink.TechnologyName = "Web";
                queriesLink.SearchProperties.Add("TagInstance", "2");
                queriesLink.SearchProperties.Add("InnerText", "Queries");
                return queriesLink;
            }
        }

        public HtmlHyperlink MenusLink
        {
            get
            {
                menusLink = new HtmlHyperlink(browser);
                menusLink.TechnologyName = "Web";
                menusLink.SearchProperties.Add("TagInstance", "3");
                menusLink.SearchProperties.Add("InnerText", "Menus");
                return menusLink;
            }
        }

        public HtmlHyperlink FieldsLink
        {
            get
            {
                fieldsLink = new HtmlHyperlink(browser);
                fieldsLink.TechnologyName = "Web";
                fieldsLink.SearchProperties.Add("TagInstance", "4");
                fieldsLink.SearchProperties.Add("InnerText", "Fields");
                return fieldsLink;
            }
        }

        public HtmlHyperlink ScriptsLink
        {
            get
            {
                scriptsLink = new HtmlHyperlink(browser);
                scriptsLink.TechnologyName = "Web";
                scriptsLink.SearchProperties.Add("TagInstance", "5");
                scriptsLink.SearchProperties.Add("InnerText", "Scripts");
                return scriptsLink;
            }
        }

        public HtmlHyperlink FilestoreLink
        {
            get
            {
                filestoreLink = new HtmlHyperlink(browser);
                filestoreLink.TechnologyName = "Web";
                filestoreLink.SearchProperties.Add("TagInstance", "6");
                filestoreLink.SearchProperties.Add("InnerText", "Filestore");
                return filestoreLink;
            }
        }

        public HtmlHyperlink CasefolderLink
        {
            get
            {
                casefolderLink = new HtmlHyperlink(browser);
                casefolderLink.TechnologyName = "Web";
                casefolderLink.SearchProperties.Add("TagInstance", "7");
                casefolderLink.SearchProperties.Add("InnerText", "Casefolder");
                return casefolderLink;
            }
        }

        public HtmlHyperlink FormDataLink
        {
            get
            {
                formdataLink = new HtmlHyperlink(browser);
                formdataLink.TechnologyName = "Web";
                formdataLink.SearchProperties.Add("TagInstance", "9");
                formdataLink.SearchProperties.Add("InnerText", "Form Data");
                return formdataLink;
            }
        }

        public HtmlHyperlink ActiveDirectoryLink
        {
            get
            {
                activedirectoryLink = new HtmlHyperlink(browser);
                activedirectoryLink.TechnologyName = "Web";
                activedirectoryLink.SearchProperties.Add("TagInstance", "10");
                activedirectoryLink.SearchProperties.Add("InnerText", "Active Directory");
                return activedirectoryLink;
            }
        }

        public HtmlHyperlink UsersLink
        {
            get
            {
                usersLink = new HtmlHyperlink(browser);
                usersLink.TechnologyName = "Web";
                usersLink.SearchProperties.Add("TagInstance", "11");
                usersLink.SearchProperties.Add("InnerText", "Users");
                return usersLink;
            }
        }

        public HtmlHyperlink RolesLink
        {
            get
            {
                rolesLink = new HtmlHyperlink(browser);
                rolesLink.TechnologyName = "Web";
                rolesLink.SearchProperties.Add("TagInstance", "12");
                rolesLink.SearchProperties.Add("InnerText", "Roles");
                return rolesLink;
            }
        }

        public HtmlHyperlink ACLSLink
        {
            get
            {
                ACLsLink = new HtmlHyperlink(browser);
                ACLsLink.TechnologyName = "Web";
                ACLsLink.SearchProperties.Add("TagInstance", "13");
                ACLsLink.SearchProperties.Add("InnerText", "ACLs");
                return ACLsLink;
            }
        }

        public HtmlHyperlink SystemMetricsLink
        {
            get
            {
                systemMetricsLink = new HtmlHyperlink(browser);
                systemMetricsLink.TechnologyName = "Web";
                systemMetricsLink.SearchProperties.Add("TagInstance", "14");
                systemMetricsLink.SearchProperties.Add("InnerText", "System Metrics");
                return systemMetricsLink;
            }
        }

        public HtmlHyperlink CacheLink
        {
            get
            {
                cacheLink = new HtmlHyperlink(browser);
                cacheLink.TechnologyName = "Web";
                cacheLink.SearchProperties.Add("TagInstance", "16");
                cacheLink.SearchProperties.Add("InnerText", "Cache");
                return cacheLink;
            }
        }

        public HtmlHyperlink WorkCalendarLink
        {
            get
            {
                workCalendarLink = new HtmlHyperlink(browser);
                workCalendarLink.TechnologyName = "Web";
                workCalendarLink.SearchProperties.Add("TagInstance", "17");
                workCalendarLink.SearchProperties.Add("InnerText", "Work Calendar");
                return workCalendarLink;
            }
        }

        public HtmlHyperlink RepositoriesLink
        {
            get
            {
                repositoriesLink = new HtmlHyperlink(browser);
                repositoriesLink.TechnologyName = "Web";
                repositoriesLink.SearchProperties.Add("TagInstance", "18");
                repositoriesLink.SearchProperties.Add("InnerText", "Repositories");
                return repositoriesLink;
            }
        }

        public HtmlHyperlink AlertsLink
        {
            get
            {
                alertsLink = new HtmlHyperlink(browser);
                alertsLink.TechnologyName = "Web";
                alertsLink.SearchProperties.Add("TagInstance", "19");
                alertsLink.SearchProperties.Add("InnerText", "Alerts");
                return alertsLink;
            }
        }

        public HtmlHyperlink LicenseLink
        {
            get
            {
                licenseLink = new HtmlHyperlink(browser);
                licenseLink.TechnologyName = "Web";
                licenseLink.SearchProperties.Add("TagInstance", "20");
                licenseLink.SearchProperties.Add("InnerText", "License");
                return licenseLink;
            }
        }

        public HtmlHyperlink ApplicationsLink
        {
            get
            {
                applicationsLink = new HtmlHyperlink(browser);
                applicationsLink.TechnologyName = "Web";
                applicationsLink.SearchProperties.Add("TagInstance", "21");
                applicationsLink.SearchProperties.Add("InnerText", "Applications");
                return applicationsLink;
            }
        }

        public HtmlHyperlink ServersLink
        {
            get
            {
                serversLink = new HtmlHyperlink(browser);
                serversLink.TechnologyName = "Web";
                serversLink.SearchProperties.Add("TagInstance", "22");
                serversLink.SearchProperties.Add("InnerText", "Servers");
                return serversLink;
            }
        }

        public HtmlHyperlink ConfigurationLink
        {
            get
            {
                configurationLink = new HtmlHyperlink(browser);
                configurationLink.TechnologyName = "Web";
                configurationLink.SearchProperties.Add("TagInstance", "23");
                configurationLink.SearchProperties.Add("InnerText", "Configuration");
                return configurationLink;
            }
        }

        public HtmlHyperlink LogLink
        {
            get
            {
                logLink = new HtmlHyperlink(browser);
                logLink.TechnologyName = "Web";
                logLink.SearchProperties.Add("TagInstance", "24");
                logLink.SearchProperties.Add("InnerText", "Log");
                return logLink;
            }
        }
    }
}
