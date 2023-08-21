using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProject.PageObject

{
    public class BaseClass
    {

        public IWebDriver driver;
        public ChromeOptions chromeOptions = new ChromeOptions();


        [SetUp]
        public void Setup()

        {

            //without opening a browser
            //chromeOptions.AddArguments("headless");

            chromeOptions.AddArgument("--start-maximized");


            chromeOptions.PageLoadStrategy = PageLoadStrategy.Default;
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
