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
        //Set Methods
        public static void EnterText(IWebElement element, string value)
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
                if (elementtype == PropertyType.Id)
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
