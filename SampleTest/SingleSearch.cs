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

//            driver.FindElement(By.XPath(".//*[@id='select-brand']/div[1]/div/ul/li[2]/label/span/img")).Click();
//            driver.FindElement(By.XPath(".//*[@id='select-model']/div[1]/div/ul/li[1]/label")).Click();
//            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(55));


//            driver.FindElement(By.XPath(".//*[@id='year-select']")).selectByValue(2015);
            
//           // driver.FindElement(By.XPath(".//*[@id='model-summary']/div[2]/div[3]/div/button")).Click();
//            driver.FindElement(By.XPath("//*[@id='model-summary']/div[2]/div[3]/div/button")).Click();
            
//            //driver.FindElement(By.ClassName("expand carjojo-button continue")).Click();

//        }
//    }
//}

//// selenium.open("/carjojo/#/search/single/brand");
////        selenium.click("id=brand-1");
////        selenium.click("css=img.icon-make-Acura");
////        selenium.click("id=model-1939");
////        selenium.click("//img[contains(@src,'https://images.carjojo.com/8272_WX_032_small.jpg?v=3')]");
////        selenium.click("//div[@id='model-summary']/div[2]/div[3]/div/button");
////        selenium.select("id=selectList", "label=Within 100 miles");
////        selenium.click("css=option[value=\"100\"]");
////        selenium.type("id=regularInput", "95008");
////        selenium.click("//div[@id='select-location']/div/div/div[3]/form/div[3]/button");
////        selenium.click("//li[@id='trim-10752']/div/div[2]/div/button");
////        selenium.click("//div[@id='select-colors']/div/div/div[3]/div[2]/div/button");
////        selenium.click("link=SHOW VEHICLES");