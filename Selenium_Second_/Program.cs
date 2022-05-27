using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Text;

namespace Selenium_Second_
{
    class Program
    {
        // IWebDriver driver = new ChromeDriver(@"I:\G Gilbert's Documents\Selenium\Selenium 101 Location");
        // Not using above because of using Driver from PropertiesCollection.cs
        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()

        {
            PropertiesCollection.driver = new ChromeDriver(@"I:\G Gilbert's Documents\Selenium\Selenium 101 Location");

            
            string url = "https://demosite.executeautomation.com/Login.html";
            PropertiesCollection.driver.Navigate().GoToUrl(url);
            Console.WriteLine("Open URL");
        }

        [Test] //<== This [Test] is to show TestExplorer this is to run the Test Method
        /*Add "<GenerateProgramFile>false</GenerateProgramFile>" in the csproj file as the test will not work with them and...
        ...also add NuGet packages: 1. Nunit.ConsoleRunner, 2. Nunit3TestAdapter and 3. Microsoft.Net.Test.sdk */
        public void ExecuteTest()
        {
            /*
            //Thread.Sleep(20000);
            //IWebElement element = driver.FindElement(By.Name("q"));
            //element.SendKeys("Kanto");

            Thread.Sleep(20000);

            //to select a element please type in "PropertyType" below \/ HERE then next to it, select the element
            //Title
            SeleniumSetMethods.SelectDropDown("TitleId", "Ms.", PropertyType.Id); //PropertyType is a strong parameter
        
            //Initials
            SeleniumSetMethods.EnterText("Initial", "SK", PropertyType.Name);

            //Name
            SeleniumSetMethods.EnterText("FirstName", "Samira", PropertyType.Id);

            SeleniumSetMethods.EnterText("MiddleName", "Keys", PropertyType.Id);
            
            Console.WriteLine("The results from my title is: " + SeleniumGetMethods.GetText("#TitleId", PropertyType.CssSelector));
            Console.WriteLine("The results from my inital is: " + SeleniumGetMethods.GetText("#Initial", PropertyType.CssSelector));
            Console.WriteLine("The results from my name is: " + SeleniumGetMethods.GetText("#FirstName", PropertyType.CssSelector));
            Console.WriteLine("The results from my Surname is: " + SeleniumGetMethods.GetText("#MiddleName", PropertyType.CssSelector));

            //TextBox
            //SeleniumSetMethods.TextBox("english", "Name");

            //Click
            SeleniumSetMethods.Click("Female", PropertyType.Name);
            //Console.WriteLine("The results from my Gender/S is: " + SeleniumGetMethods.clickRadio("#details > table > tbody > tr:nth-child(5) > td:nth-child(2) > input[type=radio]:nth-child(2)", "CssSelector"));

            SeleniumSetMethods.Click("Save", PropertyType.Name);
            Thread.Sleep(20000);
            */

            //These are the custom methods by the in built method that will activate the operation in EAPageObject
            //Login application - This is coming from LoginPageObject from line 29 
            LoginPageObject pageLogin = new LoginPageObject(); //this is to initialize this
            Thread.Sleep(3000);
            EAPageObject PageEA = pageLogin.Login("Samira", "2_Gilbert#_");
            Thread.Sleep(3000);

            //Initialize the page by calling its reference and methods from EAPageObject.cs instead of writing long codes
            //Here we ae writing the codes as a method, actions I am going to perform from the EAPageObject class itself
            PageEA.FillUserForm("Ms.", "SM", "Samira", "Mi"); //passing the values here from FillUserForm
            Thread.Sleep(3000);

        }

        [TearDown]
        public void Close()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close the Browser");

        }
}

}
