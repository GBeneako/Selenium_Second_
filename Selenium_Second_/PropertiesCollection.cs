using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Second_
{
    enum PropertyType //Here are the type elements to make it easier for us to choose among these...
    {
        Id,
        Name,
        LinkText,
        CssSelector,
        ClassName

    }
    class PropertiesCollection //Here are the driver instances
    {

        //Auto implemented property
        //This is to act as a library for the ChromeDriver
        public static IWebDriver driver { get; set; }


    }
}
