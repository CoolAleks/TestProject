using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.PageObject
{
    public class AccountCreatedPage
    {
        private IWebDriver driver;
        private By createAccount = By.XPath("//b[text()='Account Created!']");
        private By buttonContinue = By.XPath("//a[@data-qa='continue-button']");

        public AccountCreatedPage(IWebDriver driver)
        {
            this.driver = driver;
            var _createAccount = driver.FindElement(createAccount);
            string res2 = _createAccount.Text;
            StringAssert.AreEqualIgnoringCase("Account Created!", res2, "step 13 failed");

        }

        public LoggedAccountPage ButtonNextClick(IWebDriver driver)
        {
            var _buttonContinue = driver.FindElement(buttonContinue);
            _buttonContinue.Click();

            return new LoggedAccountPage(driver);
        }
    }
}
