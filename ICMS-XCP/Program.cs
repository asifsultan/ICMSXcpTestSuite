using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICMS_XCP
{
    class Program
    {
        // Browser web reference
        // IWebDriver driver = new ChromeDriver();
        Dictionary<int, string> testResult = new Dictionary<int, string>();
        Dictionary<int, string> errorMessage = new Dictionary<int, string>();
        static void Main(string[] args)
        {

        }
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver(@"C:\chrome");
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            PropertiesCollection.driver.Manage().Window.Maximize();
            testResult.Add(0, "Status");
            errorMessage.Add(0, "Reason of failure");


        }
        [Test]
        public void CaseProcessingTriage()
        {
            
            List<Datacollection> dataFirst = new List<Datacollection>();
            dataFirst = ExcelLibrary.PopulateInCollection(@"C:\CaseData.xlsx", "Triage");

           
            for (int i = 1; i <= ExcelLibrary.getTotalRow(@"C:\CaseData.xlsx", "Triage"); i++)
            {

                try
                {
                    String start_URL = PropertiesCollection.driver.Url.ToString();

                    Console.WriteLine("Running Test number : " + i);
                    PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    PropertiesCollection.driver.Navigate().GoToUrl("http://ecmapptest03.isd.lacounty.gov:2330/ICMS/?reload");


                    Console.WriteLine("Opened URL");


                    // login to application

                    String prev_URL = PropertiesCollection.driver.Url.ToString();

                    do
                    {
                        prev_URL = PropertiesCollection.driver.Url.ToString();
                    
                    } while (!prev_URL.ToString().Contains("signin.jsp"));
                    LoginPageObject pageLogin = new LoginPageObject();
                    pageLogin.ClearFeilds();
                    CaseProcessing inbox = pageLogin.Login(ExcelLibrary.ReadData(i, "UserName"),
                        ExcelLibrary.ReadData(i, "Password"));


                    prev_URL = PropertiesCollection.driver.Url.ToString();

                    do
                    {
                        prev_URL = PropertiesCollection.driver.Url.ToString();
                        

                    } while (!prev_URL.ToString().Contains("icms_inbox"));


                    inbox.ClickForTriage();

                    Console.WriteLine("Executed test number " + i + " successfully");
                    testResult.Add(i, "True");

                }


                catch (Exception ex)
                {
                    // Console.WriteLine("Executed test number " + i + " unsuccessfully");
                    Console.WriteLine("Test failed with following error: ");
                    Console.WriteLine(ex.Message);
                    testResult.Add(i, "Fail");
                    errorMessage.Add(i, ex.Message);

                }

                Console.WriteLine(" ");


            }

            ReportGenerator.GenerateXLS(testResult, errorMessage, true);
            PropertiesCollection.driver.Close();

        }

        [Test]
        public void CaseProcessingValidation()
        {

            List<Datacollection> dataFirst = new List<Datacollection>();
            dataFirst = ExcelLibrary.PopulateInCollection(@"C:\CaseData.xlsx", "Validation");


            for (int i = 1; i <= ExcelLibrary.getTotalRow(@"C:\CaseData.xlsx", "Validation"); i++)
            {

                try
                {
                    String start_URL = PropertiesCollection.driver.Url.ToString();

                    Console.WriteLine("Running Test number : " + i);
                    PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    PropertiesCollection.driver.Navigate().GoToUrl("http://ecmapptest03.isd.lacounty.gov:2330/ICMS/?reload");


                    Console.WriteLine("Opened URL");


                    // login to application

                    String prev_URL = PropertiesCollection.driver.Url.ToString();

                    do
                    {
                        prev_URL = PropertiesCollection.driver.Url.ToString();

                    } while (!prev_URL.ToString().Contains("signin.jsp"));
                    LoginPageObject pageLogin = new LoginPageObject();
                    pageLogin.ClearFeilds();
                    CaseProcessing inbox = pageLogin.Login(ExcelLibrary.ReadData(i, "UserName"),
                        ExcelLibrary.ReadData(i, "Password"));


                    prev_URL = PropertiesCollection.driver.Url.ToString();

                    do
                    {
                        prev_URL = PropertiesCollection.driver.Url.ToString();


                    } while (!prev_URL.ToString().Contains("icms_inbox"));


                    inbox.CompleteInitialValidation();

                    Console.WriteLine("Executed test number " + i + " successfully");
                    testResult.Add(i, "True");

                }


                catch (Exception ex)
                {
                    // Console.WriteLine("Executed test number " + i + " unsuccessfully");
                    Console.WriteLine("Test failed with following error: ");
                    Console.WriteLine(ex.Message);
                    testResult.Add(i, "Fail");
                    errorMessage.Add(i, ex.Message);

                }

                Console.WriteLine(" ");


            }

            //ReportGenerator.GenerateXLS(testResult, errorMessage, true);
           // PropertiesCollection.driver.Close();

        }

        [Test]
        public void CaseProcessingSupervisor()
        {

            List<Datacollection> dataFirst = new List<Datacollection>();
            dataFirst = ExcelLibrary.PopulateInCollection(@"C:\CaseData.xlsx", "Supervisor");


            for (int i = 1; i <= ExcelLibrary.getTotalRow(@"C:\CaseData.xlsx", "Supervisor"); i++)
            {

                try
                {
                    String start_URL = PropertiesCollection.driver.Url.ToString();

                    Console.WriteLine("Running Test number : " + i);
                    PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    PropertiesCollection.driver.Navigate().GoToUrl("http://ecmapptest03.isd.lacounty.gov:2330/ICMS/?reload");


                    Console.WriteLine("Opened URL");


                    // login to application

                    String prev_URL = PropertiesCollection.driver.Url.ToString();

                    do
                    {
                        prev_URL = PropertiesCollection.driver.Url.ToString();

                    } while (!prev_URL.ToString().Contains("signin.jsp"));
                    LoginPageObject pageLogin = new LoginPageObject();
                    pageLogin.ClearFeilds();
                    CaseProcessing inbox = pageLogin.Login(ExcelLibrary.ReadData(i, "UserName"),
                        ExcelLibrary.ReadData(i, "Password"));


                    prev_URL = PropertiesCollection.driver.Url.ToString();

                    do
                    {
                        prev_URL = PropertiesCollection.driver.Url.ToString();


                    } while (!prev_URL.ToString().Contains("icms_inbox"));


                    inbox.CompleteSupervisor();

                    Console.WriteLine("Executed test number " + i + " successfully");
                    testResult.Add(i, "True");

                }


                catch (Exception ex)
                {
                    // Console.WriteLine("Executed test number " + i + " unsuccessfully");
                    Console.WriteLine("Test failed with following error: ");
                   Console.WriteLine(ex.Message);
                    testResult.Add(i, "Fail");
                    errorMessage.Add(i, ex.Message);

                }

                Console.WriteLine(" ");


            }

            //ReportGenerator.GenerateXLS(testResult, errorMessage, true);
            //PropertiesCollection.driver.Close();

        }

        [Test]
        public void CaseProcessingInvestigator()
        {

            List<Datacollection> dataFirst = new List<Datacollection>();
            dataFirst = ExcelLibrary.PopulateInCollection(@"C:\CaseData.xlsx", "Investigator");


            for (int i = 1; i <= ExcelLibrary.getTotalRow(@"C:\CaseData.xlsx", "Investigator"); i++)
            {

                try
                {
                    String start_URL = PropertiesCollection.driver.Url.ToString();

                    Console.WriteLine("Running Test number : " + i);
                    PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    PropertiesCollection.driver.Navigate().GoToUrl("http://ecmapptest03.isd.lacounty.gov:2330/ICMS/?reload");


                    Console.WriteLine("Opened URL");


                    // login to application

                    String prev_URL = PropertiesCollection.driver.Url.ToString();

                    do
                    {
                        prev_URL = PropertiesCollection.driver.Url.ToString();

                    } while (!prev_URL.ToString().Contains("signin.jsp"));
                    LoginPageObject pageLogin = new LoginPageObject();
                    pageLogin.ClearFeilds();
                    CaseProcessing inbox = pageLogin.Login(ExcelLibrary.ReadData(i, "UserName"),
                        ExcelLibrary.ReadData(i, "Password"));


                    prev_URL = PropertiesCollection.driver.Url.ToString();

                    do
                    {
                        prev_URL = PropertiesCollection.driver.Url.ToString();


                    } while (!prev_URL.ToString().Contains("icms_inbox"));


                    inbox.CompleteInvestigator();

                    Console.WriteLine("Executed test number " + i + " successfully");
                    testResult.Add(i, "True");

                }


                catch (Exception ex)
                {
                    // Console.WriteLine("Executed test number " + i + " unsuccessfully");
                    Console.WriteLine("Test failed with following error: ");
                    Console.WriteLine(ex.Message);
                    testResult.Add(i, "Fail");
                    errorMessage.Add(i, ex.Message);

                }

                Console.WriteLine(" ");


            }

            //ReportGenerator.GenerateXLS(testResult, errorMessage, true);
            //PropertiesCollection.driver.Close();

        }


        [TearDown]
        public void CleanUp()
        {
           
            try
            {
                OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(5));
              //  PropertiesCollection.driver.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Close the browser");
        }
        //public static string ReadData(int rowNumber, string columnName, List<Datacollection> collectionName)
        //{
        //    try
        //    {
        //        //Retriving Data using LINQ to reduce much of iterations
        //        string data = (from colData in collectionName
        //                       where colData.colName == columnName && colData.rowNumber == rowNumber
        //                       select colData.colValue).SingleOrDefault();

        //        //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
        //        return data.ToString();
        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //    }
        //}
    }
}
