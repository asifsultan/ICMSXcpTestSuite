using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
//using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ICMS_XCP
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "j_username-inputEl")]
        public IWebElement TxtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "j_password-inputEl")]
        public IWebElement TxtPassowrd { get; set; }

        [FindsBy(How = How.Id, Using = "signin-btn-btnInnerEl")]
        public IWebElement BtnLogin { get; set; }

        public void ClearFeilds()
        {
            TxtUserName.EnterText("");
        }

        public CaseProcessing Login(string userName, string password)
        {

            TxtUserName.EnterText(userName);
            TxtPassowrd.EnterText(password);
            //WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromMinutes(1));



            BtnLogin.Clicks();



            return new CaseProcessing();

        }




    }
}
