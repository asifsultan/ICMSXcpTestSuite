﻿using NUnit.Framework;
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

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_cisu_investigation') and contains(text(),'2019-222428')]")]
        public IWebElement CISUInvestigator { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2035-inputEl")]
        public IWebElement EnterPriliminaryTriage { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-1156-btnIconEl")]
        public IWebElement SaveTriageData { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-1141-inputEl")]
        public IWebElement DDLforNextStep { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-1130-btnInnerEl")]
        public IWebElement CompleteTriageBtn { get; set; }


        //[FindsBy(How = How.Id, Using = "xcp_button-1141-btnInnerEl")]
        //public IWebElement CompleteStepBtn { get; set; }

        [FindsBy(How = How.Id, Using = "button-1095-btnIconEl")]
        public IWebElement LastPageBtn { get; set; }

        
        [FindsBy(How = How.Id, Using = "xcp_button-1164-btnInnerEl")]
        public IWebElement AquireSuperviosrTask { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Assessment/Designation')]")]
        public IWebElement AssessmentTab { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-2094-btnIconEl")]
        public IWebElement AddAllegationBtn { get; set; }


        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2392-inputEl")]
        public IWebElement ComplainingPartyDB { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2395-inputEl")]
        public IWebElement InvolvePartyDB { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-recordindex = '0']")]
        public IWebElement SelectFirstItemOnIndex { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Add')]")]
        public IWebElement AddBtn { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2423-inputEl")]
        public IWebElement SelectChargeInput { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2424-inputEl")]
        public IWebElement SelectProtectedInput { get; set; }//Discrimination //Race

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2425-inputEl")]
        public IWebElement SelectDesignationInput { get; set; } // A

        

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Update')]")]
        public IWebElement AllegationUpdateBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Finish')]")]
        public IWebElement AllegationFinishBtn { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-1167-btnIconEl")]
        public IWebElement SaveFinalDesignation { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-1176-inputEl")]
        public IWebElement AssignInvestigator { get; set; } //CISU Investigator 1

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-1151-inputEl")]
        public IWebElement NextStepInvestigator { get; set; } //CISU Investigator 1

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Complete')]")]
        public IWebElement CompleteStepBtn { get; set; }//Discrimination //Race

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
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 18);
            CompleteStepBtn.Clicks();

            
        }

        public void CompleteInitialValidation()
        {
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_cisu_validation') and contains(text(),'2019-222420')]"), 18);
            CISUValidation.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_button-1164-btnInnerEl"), 18);
            AquireCaseValdiation.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 18); ;
            CompleteStepBtn.Clicks();

        }

        public void CompleteSupervisor()
        {
           waitForPageUntilElementIsVisible(By.Id("button-1095-btnIconEl"),20);
           LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_cisu_supervisor_ass') and contains(text(),'2019-222420')]"), 8);
            CISUSupervisor.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_button-1164-btnInnerEl"), 18);
            AquireSuperviosrTask.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-1176-inputEl"), 20);
            AssignInvestigator.EnterText("CISU Investigator 1");
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 18);
            CompleteStepBtn.Clicks();

        }

        public void CompleteInvestigator()
        {
           
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_cisu_investigation') and contains(text(),'2019-222428')]"), 18);
            CISUInvestigator.Clicks();
            //waitForPageUntilElementIsVisible(By.Id("xcp_button-1164-btnInnerEl"), 8);
            //AquireSuperviosrTask.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Assessment/Designation')]"), 20);
            AssessmentTab.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_button-2094-btnIconEl"), 20);
            Console.WriteLine("Add allegation");
            AddAllegationBtn.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2392-trigger-picker"), 20);
            Console.WriteLine("Complaining Party");
            ComplainingPartyDB.EnterText("CP FNAME 18 CP LNAME 18");
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2395-trigger-picker"), 20);
            Console.WriteLine("Involved Party");
            InvolvePartyDB.EnterText("IP FNAME 18 IP LNAME 18");       
            AddBtn.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2423-inputEl"), 15);
            SelectChargeInput.EnterText("Discrimination");
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2424-inputEl"), 20);
            SelectProtectedInput.EnterText("Race");
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2425-inputEl"), 20);
            SelectDesignationInput.EnterText("A");
            AllegationUpdateBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Finish')]"), 20);
            AllegationFinishBtn.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_button-1167-btnIconEl"), 20);
            SaveFinalDesignation.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-1151-inputEl"), 20);
            NextStepInvestigator.EnterText("Panel Member: Review And Approval");
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 18);
            CompleteStepBtn.Clicks();

        }

        public void CompletePanel()
        {
            waitForPageUntilElementIsVisible(By.Id("button-1095-btnIconEl"), 20);
            LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_cisu_supervisor_ass') and contains(text(),'2019-222420')]"), 8);
            CISUSupervisor.Clicks();
            //waitForPageUntilElementIsVisible(By.Id("xcp_button-1164-btnInnerEl"), 8);
            //AquireSuperviosrTask.Clicks();
            AssignInvestigator.EnterText("CISU Investigator 1");
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 8);
            CompleteStepBtn.Clicks();

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
