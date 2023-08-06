using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.PageObject
{
    public class LoginPage
    {
        private IWebDriver driver;
        readonly By loginPage = By.XPath("//div[@class='signup-form']/h2");
        readonly By fieldlogin = By.XPath("//input[@data-qa='signup-name']");
        readonly By fieldEmail = By.XPath("//input[@data-qa='signup-email']");
        readonly By buttonSignup = By.XPath("//button[@data-qa='signup-button']");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;

            var _loginPage = driver.FindElement(loginPage);
            Assert.True(_loginPage.Displayed, "Step loginPage fail");

        }

        public SignupPage SignupButtonClick(IWebDriver driver)
        {

            var _fieldlogin = driver.FindElement(fieldlogin);
            _fieldlogin.SendKeys(Faker.Name.First());

            var _fieldEmail = driver.FindElement(fieldEmail);
            _fieldEmail.SendKeys(Faker.Internet.Email());

            var _buttonSignup = driver.FindElement(buttonSignup);
            _buttonSignup.Click();

            return new SignupPage(driver);
        }
    }
}
