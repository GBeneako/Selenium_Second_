using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Second_
{
    enum PropertyType //Here, [this emumerators] are the type elements to make it easier for us to choose among these...
    {
        Id, //<=Id and others is a hard-coded string value so all the element locators are placed here for peace of mind when using it in the base class
        Name,
        LinkText,
        CssSelector,
        ClassName,
        XPath

    }
    class PropertiesCollection //Here are the driver instances
    {

        //Auto implemented property
        //This is to act as a library / property for the ChromeDriver throughout our methods in this project
        //We know that the driver is to be fully avaliable throughout the test execution in this project so it is placed here
        public static IWebDriver driver { get; set; }


    }
}
