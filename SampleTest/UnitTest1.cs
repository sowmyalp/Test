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

//namespace SampleTest
//{
//    public class UnitTest1
//    {
//        static void Main(string[] args)
//        {
//            //opening the chrome driver
//            IWebDriver driver = new ChromeDriver(@"C:\Users\RD-14\Documents\visual studio 2012\Projects\SampleTest\SampleTest\Drivers");

//            //launching carjojo site
//            driver.Navigate().GoToUrl("https://devfe1.carjojo.com/carjojo");
//            driver.Manage().Window.Maximize();
//            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

//            //regestering new user
//            driver.FindElement(By.LinkText("SIGN IN")).Click();
//            driver.FindElement(By.XPath("html/body/div[4]/div/div/div[2]/signup-component/div/div/form/div/div/p/span[1]")).Click();
//            ExcelLib.PopulateInCollection(@"C:\TestDataAccess\TestData.xlsx");
//            driver.FindElement(By.Name("firstname")).SendKeys(ExcelLib.ReadData(1, "firstname"));
//            driver.FindElement(By.Name("username")).SendKeys(ExcelLib.ReadData(1, "username"));
//            IList<IWebElement> listItems = driver.FindElements(By.XPath("html/body/div[4]/div/div/div[2]/signup-component/div/div/form/div/div/label[2]/span/input"));
//            driver.FindElement(By.XPath("html/body/div[4]/div/div/div[2]/signup-component/div/div/form/div/div/label[3]/span/input[2]")).SendKeys(ExcelLib.ReadData(1, "password"));
          
//            driver.FindElement(By.XPath("html/body/div[4]/div/div/div[2]/signup-component/div/div/form/div/div/button")).Click();


//            Console.WriteLine("Test script executed successfully");

//            //driver.Close();

//            //Firefox Browser

//            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\RD-14\Documents\visual studio 2012\Projects\SampleTest\SampleTest\Drivers", "geckodriver.exe");
//            //service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
//            //IWebDriver driver = new FirefoxDriver(service);
//            //driver.Navigate().GoToUrl("https://devfe1.carjojo.com/carjojo");

//        }
//    }
//}