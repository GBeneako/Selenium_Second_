using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Second_
{
    class SeleniumSetMethods
    {
        //Set Methods - set values into them then perform the operations into the DOM (Document Object Model)
        public static void EnterText(IWebElement element, string value) //We know that the driver is be fully avaliable throughout the test execution in this project so it is placed in PropertiesCollection
        {
            element.SendKeys(value);

        }

        //click into a button, checkbox, option etc

        public static void Click(IWebElement element)
            {
            element.Click();
        }

        //Select a dropdown menu / value

        public static void SelectDropDown(IWebElement element, string value)
            {

            new SelectElement(element).SelectByText(value);
                
                // SelectElement selectElement = new SelectElement();
/*
                if (elementtype == PropertyType.Id) //<=Id is a hard-coded string value
                    new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
                if (elementtype == PropertyType.Name)
                    new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            */
                
                /* if (elementtype == "CssSelector")
                 new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).SelectByText(value);
             if (elementtype == "XPath")
                 new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByText(value); */

        }




    }
}
