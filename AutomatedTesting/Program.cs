using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTesting
{
    class Program
    {
        // Creating the reference of google chrome
           IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
           
        }

        [SetUp]
        public void Intialize()
        {
            // navigating to login page which i created
            driver.Url = "http://localhost/MVCDemo/Demo/Login";
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // maximizimg the browser
            driver.Manage().Window.Maximize();
            Console.WriteLine("Maximized the browser");

            //finding the element by ID and performing operations
            driver.FindElement(By.Id("Email_username")).SendKeys("aksabhijeet98@gmail.com");
            Console.WriteLine("Entered User name");

            driver.FindElement(By.Id("Password")).SendKeys("abhi1234" + Keys.Enter);
            Console.WriteLine("Entered Password");

            Console.WriteLine("Test Executed");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();

            Console.WriteLine("Closed the browser");
        }


    }
}
