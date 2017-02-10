
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;
//using SampleTest;
//using NUnit.Framework;

//namespace SampleTest
//{
//    class Format
//    {
//        IWebDriver driver = new ChromeDriver(@"C:\Users\RD-14\Documents\visual studio 2012\Projects\SampleTest\SampleTest\Drivers");
//        static void Main(string[] args)
//        {

//        }


//        [SetUp]
//        public void Initalization()
//        {
//            driver.Navigate().GoToUrl("https://devfe1.carjojo.com/carjojo");
//            driver.Manage().Window.Maximize();
//            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
//        }


//        [Test]
//        public void ExecuteTest()
//        {
//            driver.FindElement(By.LinkText("SIGN IN")).Click();
//            driver.FindElement(By.XPath("html/body/div[4]/div/div/div[2]/signup-component/div/div/form/div/div/p/span[1]")).Click();
//            ExcelLib.PopulateInCollection(@"C:\TestDataAccess\TestData.xlsx");
//            driver.FindElement(By.Name("firstname")).SendKeys(ExcelLib.ReadData(1, "firstname"));
//            driver.FindElement(By.Name("username")).SendKeys(ExcelLib.ReadData(1, "username"));
//            IList<IWebElement> listItems = driver.FindElements(By.XPath("html/body/div[4]/div/div/div[2]/signup-component/div/div/form/div/div/label[2]/span/input"));
//            driver.FindElement(By.XPath("html/body/div[4]/div/div/div[2]/signup-component/div/div/form/div/div/label[3]/span/input[2]")).SendKeys(ExcelLib.ReadData(1, "password"));
//            driver.FindElement(By.XPath("html/body/div[4]/div/div/div[2]/signup-component/div/div/form/div/div/button")).Click();
//            Console.WriteLine("Test script executed successfully");

//        }


//        [TearDown]
//        public void CleanUp()
//        {
//            driver.Close();
//        }

//    }
//}