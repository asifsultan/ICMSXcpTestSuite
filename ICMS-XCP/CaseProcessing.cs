using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ICMS_XCP
{
    class CaseProcessing
    {
        public CaseProcessing()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        /// <FirstPage>
        /// ///////////////////////////////////////////////////////////////////////////
        /// </summary>
        

        [FindsBy(How = How.Id, Using = "xcp_nav_button-1020-btnInnerEl")]
        public IWebElement CaseActionMenu { get; set; }
       
        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2157-inputWrap")]
        public IWebElement PreliminaryTriage { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_text_input-1135-inputEl")]
        public IWebElement SearchByCaseNumber { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-1038-btnInnerEl")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_cisu_preliminary_tr') and contains(text(),'2019-222420')]")]
        public IWebElement CISUPreliminaryTriageClick { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_cisu_validation') and contains(text(),'2019-222420')]")]
        public IWebElement CISUValidation { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'javascript:void(0)')]")]
        public IWebElement SearchedCase { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-1128-btnInnerEl")]
        public IWebElement AquireCaseTriage { get; set; }

        
        [FindsBy(How = How.Id, Using = "xcp_button-1139-btnInnerEl")]
        public IWebElement AquireCaseValdiation { get; set; }

        [FindsBy(How = How.XPath, Using = "xcp_button-1156-btnIconEl")]
        public IWebElement SaveTriage { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-1086")]
        public IWebElement ClaimButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'2019-222419')]")]
        public IWebElement ClickOnACase { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_cisu_supervisor_ass') and contains(text(),'2019-222420')]")]
        public IWebElement CISUSupervisor { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2035-inputEl")]
        public IWebElement EnterPriliminaryTriage { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-1156-btnIconEl")]
        public IWebElement SaveTriageData { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-1141-inputEl")]
        public IWebElement DDLforNextStep { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-1130-btnInnerEl")]
        public IWebElement CompleteTriageBtn { get; set; }


        [FindsBy(How = How.Id, Using = "xcp_button-1141-btnInnerEl")]
        public IWebElement CompleteValidationBtn { get; set; }

        [FindsBy(How = How.Id, Using = "button-1095-btnIconEl")]
        public IWebElement LastPageBtn { get; set; }

        
        [FindsBy(How = How.Id, Using = "xcp_button-1164-btnInnerEl")]
        public IWebElement AquireSuperviosrTask { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_header_tab-5104-btnInnerEl")]
        public IWebElement AssessmentTab { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-4995-btnIconEl")]
        public IWebElement AddAllegationBtn { get; set; }


        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-5293-trigger-picker")]
        public IWebElement ComplainingPartyTrigger { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-5296-trigger-picker")]
        public IWebElement InvolvePartyTrigger { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-recordindex = '0']")]
        public IWebElement SelectFirstItemOnIndex { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Add')]")]
        public IWebElement AddBtn { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-14419-inputEl")]
        public IWebElement SelectChargeInput { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-14420-inputEl")]
        public IWebElement SelectProtectedInput { get; set; }//Discrimination //Race

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-14620-inputEl")]
        public IWebElement SelectDesignationInput { get; set; } // A

        

        [FindsBy(How = How.Id, Using = "button-14417-btnInnerEl")]
        public IWebElement AllegationUpdateBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "button-14359-btnInnerEl")]
        public IWebElement AllegationFinishBtn { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-13161-btnIconEl")]
        public IWebElement SaveFinalDesignation { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-14419-inputEl")]
        public IWebElement AssignInvestigator { get; set; } //CISU Investigator 1

        [FindsBy(How = How.Id, Using = "xcp_button-13137-btnInnerEl")]
        public IWebElement CompleteSupervisorBtn { get; set; }//Discrimination //Race

        //[FindsBy(How = How.Id, Using = "xcp_dropdown_list-5293-inputEl")]
        //public IWebElement SelectDesignationInput { get; set; } // A

        public void ClickForTriage()
        {

            waitForPageUntilElementIsVisible(By.XPath("a[contains(@onclick,'icms_cisu_preliminary_tr') and contains(text(),'2019-222420')]"), 8);
            CISUPreliminaryTriageClick.Clicks();
            //AquireCaseTriage.Clicks();
            //waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2035-inputEl"), 15);
            //EnterPriliminaryTriage.EnterText("A");

            //SaveTriageData.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-1141-inputEl"), 18);
            DDLforNextStep.EnterText("Triage Complete");
            waitForPageUntilElementIsVisible(By.Id("xcp_button-1130-btnInnerEl"), 18);
            CompleteTriageBtn.Clicks();

            
        }

        public void CompleteInitialValidation()
        {
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_cisu_validation') and contains(text(),'2019-222420')]"), 8);
            CISUValidation.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_button-1164-btnInnerEl"), 8);
            AquireCaseValdiation.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_button-1141-btnInnerEl"), 8);
            CompleteValidationBtn.Clicks();

        }

        public void CompleteSupervisor()
        {
           
            LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_cisu_validation') and contains(text(),'2019-222420')]"), 8);
            CISUSupervisor.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_button-1164-btnInnerEl"), 8);
            AquireSuperviosrTask.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_header_tab-5104-btnInnerEl"), 8);
            AssessmentTab.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_button-4995-btnIconEl"), 8);
            AddAllegationBtn.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-5293-trigger-picker"), 8);
            ComplainingPartyTrigger.Clicks();
            SelectFirstItemOnIndex.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-5296-trigger-picker"), 8);
            InvolvePartyTrigger.Clicks();
            SelectFirstItemOnIndex.Clicks();
            AddBtn.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-14419-inputEl"), 8);
            SelectChargeInput.EnterText("Discrimination");
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-14420-inputEl"), 8);
            SelectProtectedInput.EnterText("Race");
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-14620-inputEl"), 8);
            SelectDesignationInput.EnterText("A");
            AllegationUpdateBtn.Clicks();
            waitForPageUntilElementIsVisible(By.Id("button-14359-btnInnerEl"), 8);
            AllegationFinishBtn.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_button-13161-btnIconEl"), 8);
            SaveFinalDesignation.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-14419-inputEl"), 20);
            AssignInvestigator.EnterText("CISU Investigator 1");
            waitForPageUntilElementIsVisible(By.Id("xcp_button-13137-btnInnerEl"), 8);
            CompleteSupervisorBtn.Clicks();

        }


        public IWebElement waitForPageUntilElementIsVisible(By locator, int maxSec)
        {
            return new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(maxSec))
                 .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }



        public static string ReadData(int rowNumber, string columnName, List<Datacollection> collectionName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in collectionName
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }


}
