using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Second_
{
    class SeleniumGetMethods
    {
        //Get Methods
        public static string GetText(IWebElement element)
        {


            /*
            if (elementtype == PropertyType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value"); //.Text do not work in textboxs so GetAttribute is needed
            if (elementtype == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            if (elementtype == PropertyType.CssSelector)
                return PropertiesCollection.driver.FindElement(By.CssSelector(element)).GetAttribute("value");
            else return String.Empty;
            */

            return element.GetAttribute("value");

        }

        public static string GetTextFromDropDown(IWebElement element)
        {
            /*
            if (elementtype == PropertyType.Id)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text; //LINQ is used here
            if (elementtype == PropertyType.Name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
            */

            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

        /*public static string clickRadio(string element, string elementtype)
        {
            if (elementtype == "Id")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().GetCssValue;
            if (elementtype == "Name")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == "CssSelector")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;

        }*/
    }
}
