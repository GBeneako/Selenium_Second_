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
        public static void EnterText(string element, string value, PropertyType elementtype) //instead of string elementtype, it is PropertyType
        {
            if (elementtype == PropertyType.Id) //(elementtype == "Id")
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            /* if (elementtype == "CssSelector")
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).SendKeys(value);
            if (elementtype == "XPath")
                PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value); */
        }

        //click into a button, checkbox, option etc

        public static void Click(string element, PropertyType elementtype)
            {
                if (elementtype == PropertyType.Id) //PropertyType in PropertiesCollection makes sure you select from what is avaliable in PropertiesCollection in case of mistakes
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
                if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            /* if (elementtype == "CssSelector")
                 PropertiesCollection.driver.FindElement(By.CssSelector(element)).Click();
             if (elementtype == "XPath")
                 PropertiesCollection.driver.FindElement(By.XPath(element)).Click(); */
        }

        //Select a dropdown menu

        public static void SelectDropDown(string element, string value, PropertyType elementtype)
            {

                // SelectElement selectElement = new SelectElement();

                if (elementtype == PropertyType.Id)
                    new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
                if (elementtype == PropertyType.Name)
                    new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            /* if (elementtype == "CssSelector")
                 new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).SelectByText(value);
             if (elementtype == "XPath")
                 new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByText(value); */

        }




    }
}
