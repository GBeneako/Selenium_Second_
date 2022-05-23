using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Second_
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssSelector,
        ClassName

    }
    class PropertiesCollection
    {

        //Auto implemented property
        //This is to act as a library for the ChromeDriver
        public static IWebDriver driver { get; set; }


    }
}
