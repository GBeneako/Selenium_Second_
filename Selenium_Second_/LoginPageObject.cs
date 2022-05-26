using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Second_
{

    class LoginPageObject
    {
        //use ctor then tab to bring 'public LoginPageObject()'
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement BtnLogin { get; set; }

        public EAPageObject Login(string userName, string password)
        {
            //UserName
            txtUserName.SendKeys(userName);
            //password
            txtPassword.SendKeys(password);
            //Click button -> BtnLogin.Click(); and also...
            BtnLogin.Submit();

            //Return to the EA page object once I click the submit button
            return new EAPageObject();
        }

    }
}
