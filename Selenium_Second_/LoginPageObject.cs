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
        //This is to initialize the code below with the ChromeDriver [FindBy...]... public is a constructor
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //Below are the operators for Program.cs
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement BtnLogin { get; set; }

        public EAPageObject Login(string userName, string password)
            //EAPageObject has to be here or it will not work to return the EAPageObject
        {
            //UserName
            txtUserName.SendKeys(userName);
            //password
            txtPassword.SendKeys(password);
            //Click button -> BtnLogin.Click(); and also...
            BtnLogin.Submit();

            //Return to the EA page object once I click the submit button
            //This will also start the operation in EAPageObject.cs
            return new EAPageObject();
        }

    }
}
