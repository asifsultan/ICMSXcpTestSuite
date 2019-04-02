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


        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'javascript:void(0)')]")]
        public IWebElement SearchedCase { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Acquire')]")]
        public IWebElement AcquireTask { get; set; }

        [FindsBy(How = How.XPath, Using = "xcp_button-1156-btnIconEl")]
        public IWebElement SaveTriage { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-1086")]
        public IWebElement ClaimButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'2019-222430')]")]
        public IWebElement ClickOnACase { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_cisu_preliminary_tr') and contains(text(),'2019-222430')]")]
        public IWebElement CISUPreliminaryTriage { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_cisu_validation') and contains(text(),'2019-222430')]")]
        public IWebElement CISUValidation { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_cisu_supervisor_ass') and contains(text(),'2019-222430')]")]
        public IWebElement CISUSupervisor { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_panel_member_review') and contains(text(),'2019-222430')]")]
        public IWebElement CISUPanel { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_cisu_investigation') and contains(text(),'2019-222430')]")]
        public IWebElement CISUInvestigator { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_cisu_intake_case_cl') and contains(text(),'2019-222430')]")]
        public IWebElement CISUIntakeFinalLetter { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_triage_ceiu') and contains(text(),'2019-222430')]")]
        public IWebElement CEIUTriage { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_cieu_supervisor_ass') and contains(text(),'2019-222430')]")]
        public IWebElement CEIUSupervisor { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_ceiu_dco_investigat') and contains(text(),'2019-222430')]")]
        public IWebElement CEIUInvestigator { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_ceiu_sdco_approval') and contains(text(),'2019-222430')]")]
        public IWebElement CEIUApproval { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_ceiu_staff_assistan') and contains(text(),'2019-222430')]")]
        public IWebElement CEIUAsssistantStacking { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@onclick,'icms_ceiu_staff_assist_1') and contains(text(),'2019-222430')]")]
        public IWebElement CEIUAsssistantQuality { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(), 'A')]//parent::div[@id='xcp_value_display-1204-inputEl']")]
        public IWebElement AssertLetter { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2568-inputEl")]
        public IWebElement AssignInvestigatorCEIU { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2567-inputEl")]
        public IWebElement NextStepSupervisorCEIU { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@name='icms_case_@prelim_triage_letter']")]
        public IWebElement EnterPriliminaryTriage { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-1173-inputEl")]
        public IWebElement CEIUInvestigatorNextStep { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2566-inputEl")]
        public IWebElement NextStepApprovalCEIU { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-1156-btnIconEl")]
        public IWebElement SaveTriageData { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-1182-inputEl")]
        public IWebElement DDLforNextStep { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-1130-btnInnerEl")]
        public IWebElement CompleteTriageBtn { get; set; }


        //[FindsBy(How = How.Id, Using = "xcp_button-1141-btnInnerEl")]
        //public IWebElement CompleteStepBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@data-qtip='Last Page']")]
        public IWebElement LastPageBtn { get; set; }


        //[FindsBy(How = How.Id, Using = "//span[contains(text(),'Complete')]")]
        //public IWebElement Complete { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Assessment/Designation')]")]
        public IWebElement AssessmentTab { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_button-2094-btnIconEl")]
        public IWebElement AddAllegationBtn { get; set; }


        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2392-inputEl")]
        public IWebElement ComplainingPartyDB { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-recordindex='0']")]
        public IWebElement ComplainingPartyDD { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2395-inputEl")]
        public IWebElement InvolvePartyDB { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-recordindex='0' and @id='ext-element-24']")]
        public IWebElement InvolvePartyDD { get; set; }

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
        public IWebElement AssignInvestigatorCISU { get; set; } //CISU Investigator 1

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-1151-inputEl")]
        public IWebElement NextStepInvestigator { get; set; } //CISU Investigator 1

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Complete')]")]
        public IWebElement CompleteStepBtn { get; set; }//Discrimination //Race

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2659-inputEl")]
        public IWebElement SdcoTriageNext { get; set; } // A

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2392-trigger-picker")]
        public IWebElement ComplainantTrigger { get; set; }

        [FindsBy(How = How.Id, Using = "xcp_dropdown_list-2395-trigger-picker")]
        public IWebElement InvolvedTrigger { get; set; }


        public void ClickForTriage()
        {

            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_cisu_preliminary_tr') and contains(text(),'2019-222430')]"), 40);
            CISUPreliminaryTriage.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(),'Acquire')]"), 40);
            AcquireTask.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//input[@name='icms_case_@prelim_triage_letter']"), 40);
            EnterPriliminaryTriage.EnterText("A");
            SaveTriageData.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-1182-inputEl"), 40);
            DDLforNextStep.EnterText("Triage Complete");
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            CompleteStepBtn.Clicks();


        }

        public void CompleteInitialValidation()
        {
            waitForPageUntilElementIsVisible(By.XPath("//a[@data-qtip='Last Page']"), 40);
            LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_cisu_validation') and contains(text(),'2019-222430')]"), 40);
            CISUValidation.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(),'Acquire')]"), 40);
            AcquireTask.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40); ;
            CompleteStepBtn.Clicks();

        }

        public void CompleteSupervisor()
        {
            waitForPageUntilElementIsVisible(By.XPath("//a[@data-qtip='Last Page']"), 40);
            LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_cisu_supervisor_ass') and contains(text(),'2019-222430')]"), 40);
            CISUSupervisor.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(),'Acquire')]"), 40);
            AcquireTask.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 30);
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-1176-inputEl"), 40);
            AssignInvestigatorCISU.EnterText("CISU Investigator 1");
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 18);
            CompleteStepBtn.Clicks();

        }

        public void CompleteInvestigator()
        {
            waitForPageUntilElementIsVisible(By.XPath("//a[@data-qtip='Last Page']"), 40);
            LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_cisu_investigation') and contains(text(),'2019-222430')]"), 40);
            CISUInvestigator.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(),'Acquire')]"), 40);
            AcquireTask.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Assessment/Designation')]"), 40);
            AssessmentTab.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_button-2094-btnIconEl"), 40);
            Console.WriteLine("Add allegation");
            AddAllegationBtn.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2392-trigger-picker"), 40);
            ComplainantTrigger.Click();
            string Complainant = ComplainingPartyDD.GetElementText();
            ComplainingPartyDB.EnterText(Complainant);
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2395-trigger-picker"), 40);
            InvolvedTrigger.Click();
            string Involved = InvolvePartyDD.GetElementText();
            InvolvePartyDB.EnterText(Involved);
            AddBtn.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2423-inputEl"), 40);
            SelectChargeInput.EnterText("Discrimination");
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2424-inputEl"), 40);
            SelectProtectedInput.EnterText("Race");
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2425-inputEl"), 40);
            SelectDesignationInput.EnterText("A");
            AllegationUpdateBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Finish')]"), 40);
            AllegationFinishBtn.Clicks();
            waitForPageUntilElementIsVisible(By.Id("xcp_button-1167-btnIconEl"), 40);
            SaveFinalDesignation.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-1151-inputEl"), 40);
            NextStepInvestigator.EnterText("Panel Member: Review And Approval");
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            CompleteStepBtn.Clicks();

        }

        public void CompletePanel()
        {
            waitForPageUntilElementIsVisible(By.XPath("//a[@data-qtip='Last Page']"), 40);
            LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_panel_member_review') and contains(text(),'2019-222430')]"), 40);
            CISUPanel.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(),'Acquire')]"), 40);
            AcquireTask.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            CompleteStepBtn.Clicks();

        }

        public void CompleteCisuIntake()
        {

            waitForPageUntilElementIsVisible(By.XPath("//a[@data-qtip='Last Page']"), 40);
            LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_cisu_intake_case_cl') and contains(text(),'2019-222430')]"), 40);
            CISUIntakeFinalLetter.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(),'Acquire')]"), 40);
            AcquireTask.Clicks();
            //waitForPageUntilElementIsVisible(By.XPath("//h1[contains(text(), 'A')]"), 40);
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            CompleteStepBtn.Clicks();

        }

        public void CompleteSDCO()
        {
            waitForPageUntilElementIsVisible(By.XPath("//a[@data-qtip='Last Page']"), 40);
            LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_triage_ceiu') and contains(text(),'2019-222430')]"), 40);
            CEIUTriage.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(),'Acquire')]"), 40);
            AcquireTask.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("xcp_dropdown_list-2659-inputEl"), 40);
            SdcoTriageNext.EnterText("Triage Complete");

            waitForPageUntilElementIsVisible(By.XPath("//a[@data-qtip='Last Page']"), 40);
            LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_cieu_supervisor_ass') and contains(text(),'2019-222430')]"), 40);
            CEIUSupervisor.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(),'Acquire')]"), 40);
            AcquireTask.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2567-inputEl"), 40);
            NextStepSupervisorCEIU.EnterText("Assign Investigator");
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2568-inputEl"), 40);
            AssignInvestigatorCEIU.EnterText("CEIU SDCO 1");
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            CompleteStepBtn.Clicks();

            waitForPageUntilElementIsVisible(By.XPath("//a[@data-qtip='Last Page']"), 40);
            LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_ceiu_dco_investigat') and contains(text(),'2019-222430')]"), 40);
            CEIUInvestigator.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(),'Acquire')]"), 40);
            AcquireTask.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list -1173-inputEl"), 40);
            CEIUInvestigatorNextStep.EnterText("SDCO Approval");
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            CompleteStepBtn.Clicks();

            waitForPageUntilElementIsVisible(By.XPath("//a[@data-qtip='Last Page']"), 40);
            LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_ceiu_sdco_approval') and contains(text(),'2019-222430')]"), 40);
            CEIUApproval.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(),'Acquire')]"), 40);
            AcquireTask.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2566-inputEl"), 40);
            NextStepApprovalCEIU.EnterText("Stacking");
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            CompleteStepBtn.Clicks();



            waitForPageUntilElementIsVisible(By.XPath("//a[@data-qtip='Last Page']"), 40);
            LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_ceiu_staff_assistan') and contains(text(),'22019-222430')]"), 40);
            CEIUAsssistantStacking.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(),'Acquire')]"), 40);
            AcquireTask.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2566-inputEl"), 40);
            NextStepApprovalCEIU.EnterText("Quality Control");
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            CompleteStepBtn.Clicks();



            waitForPageUntilElementIsVisible(By.XPath("//a[@data-qtip='Last Page']"), 40);
            LastPageBtn.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//a[contains(@onclick,'icms_ceiu_staff_assist_1') and contains(text(),'2019-222430')]"), 40);
            CEIUAsssistantQuality.Click();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(),'Acquire')]"), 40);
            AcquireTask.Clicks();
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
            waitForPageUntilElementIsVisible(By.Id("xcp_dropdown_list-2566-inputEl"), 40);
            NextStepApprovalCEIU.EnterText("Quality Control Complete");
            waitForPageUntilElementIsVisible(By.XPath("//span[contains(text(), 'Complete')]"), 40);
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
