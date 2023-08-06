using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject.Helpers

{


    public class BaseClass
    {

        public IWebDriver driver;
        public ChromeOptions chromeOptions = new ChromeOptions();


        [SetUp]
        public void Setup()
        {
            chromeOptions.PageLoadStrategy = PageLoadStrategy.None;
            driver = new ChromeDriver(@"C:\webdriver\chromedriver", chromeOptions);
            try
            {
                driver.Navigate().GoToUrl("http://automationexercise.com");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection to url: Failed " + ex.StackTrace);
            }
        }



        [TearDown]
        public void TearDown()
        {
            driver.Quit();

        }
    }
}
