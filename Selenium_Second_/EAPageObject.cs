﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;


namespace Selenium_Second_
{
    class EAPageObject
    {

        public EAPageObject()
            //This is to initialize the code below with the ChromeDriver [FindBy...]... public is a constructor
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //using a Page Object model to separate element locators with tests (Program.cs) then clearly explain that
        // using SeleniumExtras.PageObjects; is the NuGet package to use here...
        //This is to make it simple to call out the elements and the WebElement / references in Programs.cs
        //This is the [elements in] operations for Programs.cs, the initialization of the objects
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement DropDownTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement TextInitialName { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstNameID { get; set; }

        [FindsBy(How = How.Id, Using = "MiddleName")]
        public IWebElement SurnameID { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement BtnSaveName { get; set; }

        [FindsBy(How = How.Name, Using = "Female")]
        public IWebElement RadioBtnName { get; set; }

        public void FillUserForm(string TitleId, string Initial, string FirstName, string Surname)
        {
            /*
            TextInitialName.SendKeys(Initial);
            FirstNameID.SendKeys(FirstName);
            SurnameID.SendKeys(Surname);
            RadioBtnName.Click();
            BtnSaveName.Click();
            */
            //Objects to perform, and where these objects are and who they are on the page
            SeleniumSetMethods.SelectDropDown(DropDownTitleID, TitleId);
            SeleniumSetMethods.EnterText(TextInitialName, Initial);
            SeleniumSetMethods.EnterText(FirstNameID, FirstName);
            SeleniumSetMethods.EnterText(SurnameID, Surname);
            SeleniumSetMethods.Click(RadioBtnName);
            SeleniumSetMethods.Click(BtnSaveName);
            

            
        }
    }
}
