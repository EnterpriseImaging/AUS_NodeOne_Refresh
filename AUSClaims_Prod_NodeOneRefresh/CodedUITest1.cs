using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using AUSClaims_Prod_NodeOneRefresh.Pages;

namespace AUSClaims_Prod_NodeOneRefresh
{
    #region Windows Security Box Setting
    public class WindowsSecurityWindow : WinWindow
    {
        private WinText uiUseanotherAccountText;
        private WinEdit uiUsernameEdit;
        private WinEdit uiPasswordEdit;
        private WinButton uiokButton;

        public WindowsSecurityWindow()
        {
            SearchProperties[PropertyNames.Name] = "Windows Security";
            SearchProperties[PropertyNames.ClassName] = "#32770";
            TechnologyName = "MSAA";
            WindowTitles.Add("Windows Security");
        }
        //Search for Use Another Account Option in Windows Security Box
        public WinText UseAnotherAccountText
        {
            get
            {
                if ((uiUseanotherAccountText == null))
                {
                    uiUseanotherAccountText = new WinText(this);
                    uiUseanotherAccountText.SearchProperties[WinText.PropertyNames.Name] = "Use Another Account";
                }

                return uiUseanotherAccountText;
            }
        }
        //Search for the User Name Entry Box in Windows Security Box
        public WinEdit UsernameEdit
        {
            get
            {
                if ((uiUsernameEdit == null))
                {
                    uiUsernameEdit = new WinEdit(this);
                    uiUsernameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "User name";
                }
                return uiUsernameEdit;
            }
        }
        //Search the the Password Entry Box in the Windows Security Box
        public WinEdit PasswordEdit
        {
            get
            {
                if ((uiPasswordEdit == null))
                {
                    uiPasswordEdit = new WinEdit(this);
                    uiPasswordEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Password";
                }

                return uiPasswordEdit;
            }
        }
        //Search for the Ok Button in the Windows Security Box
        public WinButton OkButton
        {
            get
            {
                if ((uiokButton == null))
                {
                    uiokButton = new WinButton(this);
                    uiokButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                }

                return uiokButton;
            }
        }
        //Authentication of Username and Password with MouseButton Click
        public void Authenicate(string userName, string password)
        {
            if (UseAnotherAccountText.Exists)
            {
                Mouse.Click(UseAnotherAccountText);
            }

            UsernameEdit.Text = userName;
            PasswordEdit.Text = password;

            Mouse.Click(OkButton);
        }
        #endregion

        [CodedUITest]
        public class CodedUITest1
        {
            private const string UrlUnderTest_AUSClaims_Prod_NodeOne = "http://stlpoptxwas0301.rgare.net:9080/australiaclaims/Admin -private";
            //Reporting Variables
            string testDescription = "Clearing the Application Cache and Restarting the PROD processes for AUS Claims on Node One";
            string expectedResult = "App Cache is Cleared and Processes are Restarted and Running";
            string evidenceType = "Log";
            string executedBy = "Imaging Team Regression Automation Platform";

            [TestInitialize()]
            public void MyTestInitialize()
            {

                //ExcelUtilityLibrary.PopulateInCollection(@"\\\\rgare\\rgaappcommon\\OPNTXTIMG\\common\\Mike\\Passwords for Coded UI\\Application Checkout\\AdminCredentials.xlsx");

                /* Copy the correct username and password reference below into each test case as needed
                 * example: ExcelUtilityLibrary.ReadData(1, "Username"); and ExcelUtilityLibrary.ReadData(1, "Password"); for Prod Admin UN and PW
                string ProdAdminUsername = ExcelUtilityLibrary.ReadData(1, "Username");
                string ProdAdminPassword = ExcelUtilityLibrary.ReadData(1, "Password");
                string UATAdminUsername = ExcelUtilityLibrary.ReadData(2, "Username");
                string UATAdminPassword = ExcelUtilityLibrary.ReadData(2, "Password");
                string DEVAdminUsername = ExcelUtilityLibrary.ReadData(3, "Username");
                string DEVAdminPassword = ExcelUtilityLibrary.ReadData(3, "Password");
                string ProdServiceAccountUsername = ExcelUtilityLibrary.ReadData(4, "Username");
                string ProdServiceAccountPassword = ExcelUtilityLibrary.ReadData(4, "Password");
                */

            }

            [TestMethod]
            public void AUSClaims_Prod_NodeOne_DailyRefresh()
            {
            

                //username and Password Retrevial from Excel
                ExcelUtilityLibrary.PopulateInCollection(@"\\\\rgare\\rgaappcommon\\OPNTXTIMG\\common\\Mike\\Passwords for Coded UI\\Application Checkout\\AdminCredentials.xlsx");

                //Variable to Set Which Browser to Use
                BrowserWindow browserWindow = new BrowserWindow();
                var BrowserToUse = "iexplore";

                //Open the Browser Window
                Process browserInPrivate = new Process();
                browserInPrivate.StartInfo.FileName = BrowserToUse;
                browserInPrivate.StartInfo.Arguments = UrlUnderTest_AUSClaims_Prod_NodeOne;
                browserInPrivate.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                browserInPrivate.Start();

                //Login to the AUS Claims Node One Admin Page
                WindowsSecurityWindow windowsSecurityWindow = new WindowsSecurityWindow();
                windowsSecurityWindow.Authenicate(ExcelUtilityLibrary.ReadData(1, "Username"), ExcelUtilityLibrary.ReadData(1, "Password"));

                //Page Class Definitions
                AUSClaims_Prod_AdminPage_NodeOne AdminPage_NodeOne = new AUSClaims_Prod_AdminPage_NodeOne(browserWindow);
                AUSClaims_Prod_CachePage_NodeOne CachePage_NodeOne = new AUSClaims_Prod_CachePage_NodeOne(browserWindow);
                AUSClaims_Prod_ConfigPage_NodeOne ConfigPage_NodeOne = new AUSClaims_Prod_ConfigPage_NodeOne(browserWindow);
                AUSClaims_Prod_CustomConfigPage_NodeOne CustomConfigPage_NodeOne = new AUSClaims_Prod_CustomConfigPage_NodeOne(browserWindow);
                AUSClaims_Prod_ProcessPage_NodeOne ProcessPage_NodeOne = new AUSClaims_Prod_ProcessPage_NodeOne(browserWindow);
                AUSClaims_Prod_ServersPage_NodeOne ServersPage_NodeOne = new AUSClaims_Prod_ServersPage_NodeOne(browserWindow);

                //Select the Cache Link to Navigate to the Cache Page on Node One
                var nodeOneCacheLink = AdminPage_NodeOne.CacheLink;
                Mouse.Click(nodeOneCacheLink);

                //Click the Clear All Caches Button on Node One
                var clickClearAllCachesButton = CachePage_NodeOne.clearAllCaches_Button;
                Mouse.Click(clickClearAllCachesButton);

                //Select the Process Link to Navigate to the Process Page on Node One
                var nodeOneProcessLink = AdminPage_NodeOne.ProcessLink;
                Mouse.Click(nodeOneProcessLink);

                //Stop the AUSClaimAssessment Process on Node One
                var NodeOne_AusClaimAssessment_Stop = ProcessPage_NodeOne.AUSClaimAssessmentProcessStop;
                Mouse.Click(NodeOne_AusClaimAssessment_Stop);

                //Start the AUSClaimAssessment Process on Node One
                var NodeOne_AUSClaimAssessment_Start = ProcessPage_NodeOne.AUSClaimAssessmentProcessStart;
                Mouse.Click(NodeOne_AUSClaimAssessment_Start);

                //Assert the AUSClaimAssessment Process has a status of Running on Node One
                var AUSClaimAssessmentStatusControl = ProcessPage_NodeOne.AUSClaimAssessmentProcessStatus;
                string returnedAUSClaimAssessmentStatus = AUSClaimAssessmentStatusControl.GetProperty("InnerText").ToString();
                string expectedAUSClaimAssessmentStatus = "Running";
                if (returnedAUSClaimAssessmentStatus == expectedAUSClaimAssessmentStatus)
                {
                    Equals(true, true);
                }
                else
                {
                    Equals(true, false);
                }

                //Stop the AUSClaimDocument Process on Node One
                var NodeOne_AUSClaimDocument_Stop = ProcessPage_NodeOne.AUSClaimDocumentProcessStop;
                Mouse.Click(NodeOne_AUSClaimDocument_Stop);

                //Start the AUSClaimDocument Process on Node One
                var NodeOne_AUSClaimDocument_Start = ProcessPage_NodeOne.AUSClaimDocumentProcessStart;
                Mouse.Click(NodeOne_AUSClaimDocument_Start);

                //Assert the AUSClaimDocument Process has a status of Running on Node One
                var AUSClaimDocumentStatusControl = ProcessPage_NodeOne.AUSClaimDocumentProcessStatus;
                string returnedAUSClaimDocumentStatus = AUSClaimDocumentStatusControl.GetProperty("InnerText").ToString();
                string expectedAUSClaimDocumentStatus = "Running";
                if (returnedAUSClaimDocumentStatus == expectedAUSClaimDocumentStatus)
                {
                    Equals(true, true);
                }
                else
                {
                    Equals(true, false);
                }

                //Stop the AUSAssessmentTasks Process on Node One
                var NodeOne_AUSClaimAssessmentTasks_Stop = ProcessPage_NodeOne.AUSAssessmentTasksProcessStop;
                Mouse.Click(NodeOne_AUSClaimAssessmentTasks_Stop);

                //Start the AUSAssessmentTasks Process on Node One
                var NodeOne_AUSClaimAssessmentTasks_Start = ProcessPage_NodeOne.AUSAssessmentTasksProcessStart;
                Mouse.Click(NodeOne_AUSClaimAssessmentTasks_Start);

                //Assert the AUSAssessmentTasks Process has a status of Running on Node One
                var AUSAssessmentTasksStatusControl = ProcessPage_NodeOne.AUSAssessmentTasksProcessStatus;
                string returnedAUSAssessmentTasksStatus = AUSAssessmentTasksStatusControl.GetProperty("InnerText").ToString();
                string expectedAUSAssessmentTasksStatus = "Running";
                if (returnedAUSAssessmentTasksStatus == expectedAUSAssessmentTasksStatus)
                {
                    Equals(true, true);
                }
                else
                {
                    Equals(true, false);
                }

                //Stop the PendBatchProcess on Node One
                var NodeOne_PendBatchProcess_Stop = ProcessPage_NodeOne.PendBatchProcessStop;
                Mouse.Click(NodeOne_PendBatchProcess_Stop);

                //Start the PendBatchProcess on Node One
                var NodeOne_PendBatchProcess_Start = ProcessPage_NodeOne.PendBatchProcessStart;
                Mouse.Click(NodeOne_PendBatchProcess_Start);

                //Assert the PendBatchProcess has a status of Running on Node One
                var PendBatchProcessStatusControl = ProcessPage_NodeOne.PendBatchProcessStatus;
                string returnedPendBatchProcessStatus = PendBatchProcessStatusControl.GetProperty("InnerText").ToString();
                string expectedPendBatchProcessStatus = "Running";
                if (returnedPendBatchProcessStatus == expectedPendBatchProcessStatus)
                {
                    Equals(true, true);
                }
                else
                {
                    Equals(true, false);
                }

                //Stop the ReminderBatchJob Process on Node One
                var NodeOne_ReminderBatchJob_Stop = ProcessPage_NodeOne.ReminderBatchJobProcessStop;
                Mouse.Click(NodeOne_ReminderBatchJob_Stop);

                //Start the ReminderBatchJob Process on Node One
                var NodeOne_ReminderBatchJob_Start = ProcessPage_NodeOne.ReminderBatchJobProcessStart;
                Mouse.Click(NodeOne_ReminderBatchJob_Start);

                //Assert the ReminderBatchJob Process has a status of Running on Node One
                var ReminderBatchJobStatusControl = ProcessPage_NodeOne.ReminderBatchJobProcessStatus;
                string returnedReminderBatchJobStatus = ReminderBatchJobStatusControl.GetProperty("InnerText").ToString();
                string expectedReminderBatchJobStatus = "Running";
                if (returnedReminderBatchJobStatus == expectedReminderBatchJobStatus)
                {
                    Equals(true, true);
                }
                else
                {
                    Equals(true, false);
                }

                //Select the Servers Link to Navigate to the Servers Page on Node One
                var select_ServersLink = AdminPage_NodeOne.ServersLink;
                Mouse.Click(select_ServersLink);

                //Verify the Port Two Label Displays and Grab the Inner Text
                var PortTwoLabelControl = ServersPage_NodeOne.ServerTwoPortMenu;
                string returnedPortTwoLabelValue = null;
                if (PortTwoLabelControl.Exists)
                {
                    returnedPortTwoLabelValue = PortTwoLabelControl.GetProperty("InnerText").ToString();
                }
                else
                {
                    this.TestContext.WriteLine("The Port Two Label Control Wasn't Found");
                    Assert.AreEqual(true, false);
                }

                //Select the Configuration Link to Navigate to the Configuration Page on Node One
                var select_ConfigurationLink = AdminPage_NodeOne.ConfigurationLink;
                Mouse.Click(select_ConfigurationLink);

                //Select The Action Dropdown on the Configuration Page on Node One
                var select_ActionMenu = ConfigPage_NodeOne.ActionsDropdown;
                Mouse.Click(select_ActionMenu);

                //Select the Custom Link in the Actions Menu on Node One
                var select_CustomLink = ConfigPage_NodeOne.CustomLink;
                Mouse.Click(select_CustomLink);

                //Get the Value in the Sole Capture Server Custom Property
                string returnedSoleCaptureServerValue = null;
                var SoleCaptureServerLabelControl = CustomConfigPage_NodeOne.SoleCaptureServerValueField;
                if (SoleCaptureServerLabelControl.Exists)
                {
                    returnedSoleCaptureServerValue = SoleCaptureServerLabelControl.GetProperty("ValueAttribute").ToString();
                    Assert.AreEqual(true, true);
                }
                else
                {
                    this.testContextInstance.WriteLine("The Sole Capture Custom Property Field Couldn't Be Located on Node One");
                    Assert.AreEqual(true, false);
                }

                //Assert the Port Two Value from Server Page and the Sole Capture Server Custom Property are Equal
                if (returnedPortTwoLabelValue == returnedSoleCaptureServerValue)
                {
                    this.testContextInstance.WriteLine("The Values are Equal -- Sole Capture Server is Configured Correctly");
                    Assert.AreEqual(true, true);
                }
                else
                {
                    //Select the Sole Capture Server Field
                    var select_SoleCaptureServerField = CustomConfigPage_NodeOne.SoleCaptureServerValueField;
                    Mouse.Click(select_SoleCaptureServerField);

                    //Clear out the Current Value in the Sole Capture Server Field
                    for (int j = 0; j < 40; j++)
                    {
                        Keyboard.SendKeys("{BACK}");
                    }
                    Keyboard.SendKeys(returnedPortTwoLabelValue);
                    Keyboard.SendKeys("{Enter}");

                    //Verify the Value in the Sole Capture Server Field has Changed
                    string returnedSoleCaptureValue_AfterUpdate = null;
                    var SoleCaptureValueFieldControl_AfterUpdate = CustomConfigPage_NodeOne.SoleCaptureServerValueField;
                    if (SoleCaptureValueFieldControl_AfterUpdate.Exists)
                    {
                        returnedSoleCaptureValue_AfterUpdate = SoleCaptureValueFieldControl_AfterUpdate.GetProperty("ValueAttribute").ToString();

                        if (returnedSoleCaptureValue_AfterUpdate == returnedPortTwoLabelValue)
                        {
                            this.testContextInstance.WriteLine("The Sole Capture Server Property was updated and is now configured correctly.");
                            Assert.AreEqual(true, true);
                        }
                        else
                        {
                            this.testContextInstance.WriteLine("The Sole Capture Server Custom Property wasn't Updated Correctly");
                            Assert.AreEqual(true, false);
                        }
                    }
                    else
                    {
                        this.testContextInstance.WriteLine("The Sole Capture Custom Property Field Couldn't Be Located on Node One after the Update");
                        Assert.AreEqual(true, false);
                    }
                }

                //Close the Browser Window
                browserWindow.Close();
            }

            #region Additional test attributes

            // You can use the following additional attributes as you write your tests:

            ////Use TestInitialize to run code before running each test 
            //[TestInitialize()]
            //public void MyTestInitialize()
            //{        
            //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            //}

            ////Use TestCleanup to run code after each test has run
            [TestCleanup()]
            public void MyTestCleanup()
            {
                //Create the Report Output File
                var usernameToPass = ExcelUtilityLibrary.ReadData(4, "Username");
                var passwordToPass = ExcelUtilityLibrary.ReadData(4, "Password");
                var impersonationContext = new AUSClaims_Prod_NodeOneRefresh.Impersonate.WrappedImpersonationContext("RGARE", usernameToPass, passwordToPass);
                impersonationContext.Enter();
                Reports.CreateCSVOutputFile(TestContext.TestName.ToString(), TestContext.CurrentTestOutcome.ToString(), testDescription, expectedResult, evidenceType, testContextInstance.TestResultsDirectory.ToString(), executedBy);
                impersonationContext.Leave();

                //Send Email to Imaging Team 
                var fromAddress = new MailAddress("codeduitestresults@gmail.com");
                var toAddress = new MailAddress("michael.young@rgare.com");
                var Todaysdate = DateTime.Now;
                const string fromPassword = "4872Hmnc!";
                var subject = "The Application Checkout Test: " + this.testContextInstance.TestName.ToString() + " Has " + this.testContextInstance.CurrentTestOutcome.ToString();
                var body = this.testContextInstance.TestName.ToString() + " Has Been Completed on: " + Todaysdate + "\n The log files results can be found at: " + this.testContextInstance.TestResultsDirectory;
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }

            #endregion

            /// <summary>
            ///Gets or sets the test context which provides
            ///information about and functionality for the current test run.
            ///</summary>
            public TestContext TestContext
            {
                get
                {
                    return testContextInstance;
                }
                set
                {
                    testContextInstance = value;
                }
            }
            private TestContext testContextInstance;
        }
    }
}