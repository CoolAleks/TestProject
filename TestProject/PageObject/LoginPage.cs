using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.PageObject;
using OpenQA.Selenium.Chrome;
using TestProject.Helpers;


namespace TestProject.PageObject
{
    public class LoginPage
    {
        private readonly IWebDriver _webDriver;
        //readonly By loginPage = By.XPath("//div[@class='signup-form']/h2");
        //readonly By fieldlogin = By.XPath("//input[@data-qa='signup-name']");
        //readonly By fieldEmail = By.XPath("//input[@data-qa='signup-email']");
        //readonly By buttonSignup = By.XPath("//button[@data-qa='signup-button']");
        readonly By loginInputlocator = By.XPath("//input[@data-qa='signup-name']");
        readonly By emailInputlocator = By.XPath("//input[@data-qa='signup-email']");
        readonly By LoginButtonLocator = By.XPath("//button[@data-qa='signup-button']");
        readonly By errorFieldLocator = By.XPath("//p[text()='Email Address already exist!']");

        //public LoginPage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //    var _loginPage = driver.FindElement(loginPage);
        //    Assert.True(_loginPage.Displayed, "Step loginPage fail");
        //}

        public LoginPage(IWebDriver driver)
        {
            _webDriver = driver;
            Helper.CheckLocation(driver, "/login");

        }
        public void SendCredentional(string login, string password)
        {
            var logInput = _webDriver.FindElement(loginInputlocator);
            Helper.SendText(logInput, login);

            var passInput = _webDriver.FindElement(emailInputlocator);
            Helper.SendText(passInput, password);
        }

        public LoginPage Login(string login, string password)
        {
            SendCredentional(login, password);
            _webDriver.FindElement(LoginButtonLocator).Click();
            return this;
        }

        public string GetAlertText()
        {
            return _webDriver.FindElement(errorFieldLocator).Text.Trim();
        }

        public SignupPage GoToSignupPage(IWebDriver driver)
        {
            return new SignupPage(_webDriver);
        }

        //public SignupPage SignupButtonClick(IWebDriver driver)
        //{

        //    var _fieldlogin = driver.FindElement(fieldlogin);
        //    _fieldlogin.SendKeys(DataFaker.GenerateNameFirst());

        //    var _fieldEmail = driver.FindElement(fieldEmail);
        //    _fieldEmail.SendKeys(DataFaker.GenerateEmail());

        //    var _buttonSignup = driver.FindElement(buttonSignup);
        //    _buttonSignup.Click();

        //    return new SignupPage(driver);
        //}
    }
}
