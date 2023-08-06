using OpenQA.Selenium;
using TestProject.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.PageObject
{
    public class LoggedAccountPage
    {
        readonly IWebDriver driver;
        readonly By buttonLoggedInAs = By.XPath("//a[text()=' Logged in as ']");
        readonly By buttonDeleteAccount = By.XPath("//a[text()=' Delete Account']");

        public LoggedAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            var _buttonLoggedInAs = driver.FindElement(buttonLoggedInAs);
            string buttonLogged = _buttonLoggedInAs.Text;
            StringAssert.Contains("Logged in as", buttonLogged, "step loggedAccount failed");

        }

        public DeleteAccountPage DeleteAccount(IWebDriver driver)
        {
            var _buttonDeleteAccount = driver.FindElement(buttonDeleteAccount);
            _buttonDeleteAccount.Click();

            return new DeleteAccountPage(driver);
        }
    }
}
