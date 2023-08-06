using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TestProject.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.PageObject
{
    public class MainMenuPage
    {
        private IWebDriver driver;

        readonly By pageTitleDisplay = By.XPath("//a[contains(text(),' Home')]");
        
        readonly By buttonLogin = By.XPath("//a[contains(text(),' Signup')]");

        public MainMenuPage(IWebDriver driver)
        {
            this.driver = driver;
            var _pageTitleDisplay = driver.FindElement(pageTitleDisplay);
            Assert.That(_pageTitleDisplay.Text, Is.EqualTo("Home"));
        }

        public LoginPage LoginButtonClick(IWebDriver driver)
        {
            var _buttonLogin = driver.FindElement(buttonLogin);
            _buttonLogin.Click();
            return new LoginPage(driver);
        }

        // to navigation class
        //public static LoginPage GoToLoginPage(IWebDriver driver)
        //{
        //    driver.Url("");
        //    return new LoginPage(driver);
        //}

    }
}
