using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace AUSClaims_Prod_NodeOneRefresh.Pages
{
    class AUSClaims_Prod_ProcessPage_NodeOne
    {
        private readonly BrowserWindow browser;
        private HtmlImage AUSClaimAssessment_Stop;
        private HtmlImage AUSClaimAssessment_Start;
        private HtmlCustom AUSClaimAssessment_Status;
        private HtmlImage AUSClaimDocument_Stop;
        private HtmlImage AUSClaimDocument_Start;
        private HtmlCustom AUSClaimDocument_Status;
        private HtmlImage AUSAssessmentTasks_Stop;
        private HtmlImage AUSAssessmentTasks_Start;
        private HtmlCustom AUSAssessmentTasks_Status;
        private HtmlImage PendBatchProcess_Stop;
        private HtmlImage PendBatchProcess_Start;
        private HtmlCustom PendBatchProcess_Status;
        private HtmlImage ReminderBatchJob_Stop;
        private HtmlImage ReminderBatchJob_Start;
        private HtmlCustom ReminderBatchJob_Status;

        public AUSClaims_Prod_ProcessPage_NodeOne(BrowserWindow BrowserWindow)
        {
            browser = BrowserWindow;
        }

        public HtmlImage AUSClaimAssessmentProcessStop
        {
            get
            {
                AUSClaimAssessment_Stop = new HtmlImage(browser);
                AUSClaimAssessment_Stop.TechnologyName = "Web";
                AUSClaimAssessment_Stop.SearchProperties.Add("TagInstance", "2");
                AUSClaimAssessment_Stop.SearchProperties.Add("Src", "http://stlpoptxwas0301.rgare.net:9080/australiaclaims/Images/Stop.gif");
                return AUSClaimAssessment_Stop;
            }
        }

        public HtmlImage AUSClaimAssessmentProcessStart
        {
            get
            {
                AUSClaimAssessment_Start = new HtmlImage(browser);
                AUSClaimAssessment_Start.TechnologyName = "Web";
                AUSClaimAssessment_Start.SearchProperties.Add("TagInstance", "2");
                AUSClaimAssessment_Start.SearchProperties.Add("Src", "http://stlpoptxwas0301.rgare.net:9080/australiaclaims/Images/Start.gif");
                return AUSClaimAssessment_Start;
            }
        }

        public HtmlCustom AUSClaimAssessmentProcessStatus
        {
            get
            {
                AUSClaimAssessment_Status = new HtmlCustom(browser);
                AUSClaimAssessment_Status.TechnologyName = "Web";
                AUSClaimAssessment_Status.SearchProperties.Add("Id", "pump0");
                return AUSClaimAssessment_Status;
            }
        }

        public HtmlImage AUSClaimDocumentProcessStop
        {
            get
            {
                AUSClaimDocument_Stop = new HtmlImage(browser);
                AUSClaimDocument_Stop.TechnologyName = "Web";
                AUSClaimDocument_Stop.SearchProperties.Add("TagInstance", "4");
                AUSClaimDocument_Stop.SearchProperties.Add("Src", "http://stlpoptxwas0301.rgare.net:9080/australiaclaims/Images/Stop.gif");
                return AUSClaimDocument_Stop;
            }
        }

        public HtmlImage AUSClaimDocumentProcessStart
        {
            get
            {
                AUSClaimDocument_Start = new HtmlImage(browser);
                AUSClaimDocument_Start.TechnologyName = "Web";
                AUSClaimDocument_Start.SearchProperties.Add("TagInstance", "4");
                AUSClaimDocument_Start.SearchProperties.Add("Src", "http://stlpoptxwas0301.rgare.net:9080/australiaclaims/Images/Start.gif");
                return AUSClaimDocument_Start;
            }
        }

        public HtmlCustom AUSClaimDocumentProcessStatus
        {
            get
            {
                AUSClaimDocument_Status = new HtmlCustom(browser);
                AUSClaimDocument_Status.TechnologyName = "Web";
                AUSClaimDocument_Status.SearchProperties.Add("Id", "pump1");
                return AUSClaimDocument_Status;
            }
        }

        public HtmlImage AUSAssessmentTasksProcessStop
        {
            get
            {
                AUSAssessmentTasks_Stop = new HtmlImage(browser);
                AUSAssessmentTasks_Stop.TechnologyName = "Web";
                AUSAssessmentTasks_Stop.SearchProperties.Add("TagInstance", "6");
                AUSAssessmentTasks_Stop.SearchProperties.Add("Src", "http://stlpoptxwas0301.rgare.net:9080/australiaclaims/Images/Stop.gif");
                return AUSAssessmentTasks_Stop;
            }
        }

        public HtmlImage AUSAssessmentTasksProcessStart
        {
            get
            {
                AUSAssessmentTasks_Start = new HtmlImage(browser);
                AUSAssessmentTasks_Start.TechnologyName = "Web";
                AUSAssessmentTasks_Start.SearchProperties.Add("TagInstance", "6");
                AUSAssessmentTasks_Start.SearchProperties.Add("Src", "http://stlpoptxwas0301.rgare.net:9080/australiaclaims/Images/Start.gif");
                return AUSAssessmentTasks_Start;
            }
        }

        public HtmlCustom AUSAssessmentTasksProcessStatus
        {
            get
            {
                AUSAssessmentTasks_Status = new HtmlCustom(browser);
                AUSAssessmentTasks_Status.TechnologyName = "Web";
                AUSAssessmentTasks_Status.SearchProperties.Add("Id", "pump2");
                return AUSAssessmentTasks_Status;
            }
        }

        public HtmlImage PendBatchProcessStop
        {
            get
            {
                PendBatchProcess_Stop = new HtmlImage(browser);
                PendBatchProcess_Stop.TechnologyName = "Web";
                PendBatchProcess_Stop.SearchProperties.Add("TagInstance", "8");
                PendBatchProcess_Stop.SearchProperties.Add("Src", "http://stlpoptxwas0301.rgare.net:9080/australiaclaims/Images/Stop.gif");
                return PendBatchProcess_Stop;
            }
        }

        public HtmlImage PendBatchProcessStart
        {
            get
            {
                PendBatchProcess_Start = new HtmlImage(browser);
                PendBatchProcess_Start.TechnologyName = "Web";
                PendBatchProcess_Start.SearchProperties.Add("TagInstance", "8");
                PendBatchProcess_Start.SearchProperties.Add("Src", "http://stlpoptxwas0301.rgare.net:9080/australiaclaims/Images/Start.gif");
                return PendBatchProcess_Start;
            }
        }

        public HtmlCustom PendBatchProcessStatus
        {
            get
            {
                PendBatchProcess_Status = new HtmlCustom(browser);
                PendBatchProcess_Status.TechnologyName = "Web";
                PendBatchProcess_Status.SearchProperties.Add("Id", "pump3");
                return PendBatchProcess_Status;
            }
        }

        public HtmlImage ReminderBatchJobProcessStop
        {
            get
            {
                ReminderBatchJob_Stop = new HtmlImage(browser);
                ReminderBatchJob_Stop.TechnologyName = "Web";
                ReminderBatchJob_Stop.SearchProperties.Add("TagInstance", "10");
                ReminderBatchJob_Stop.SearchProperties.Add("Src", "http://stlpoptxwas0301.rgare.net:9080/australiaclaims/Images/Stop.gif");
                return ReminderBatchJob_Stop;
            }
        }

        public HtmlImage ReminderBatchJobProcessStart
        {
            get
            {
                ReminderBatchJob_Start = new HtmlImage(browser);
                ReminderBatchJob_Start.TechnologyName = "Web";
                ReminderBatchJob_Start.SearchProperties.Add("TagInstance", "10");
                ReminderBatchJob_Start.SearchProperties.Add("Src", "http://stlpoptxwas0301.rgare.net:9080/australiaclaims/Images/Start.gif");
                return ReminderBatchJob_Start;
            }
        }

        public HtmlCustom ReminderBatchJobProcessStatus
        {
            get
            {
                ReminderBatchJob_Status = new HtmlCustom(browser);
                ReminderBatchJob_Status.TechnologyName = "Web";
                ReminderBatchJob_Status.SearchProperties.Add("Id", "pump4");
                return ReminderBatchJob_Status;
            }
        }
    }
}
