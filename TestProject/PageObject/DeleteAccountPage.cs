using OpenQA.Selenium;
using TestProject.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.PageObject
{
    public class DeleteAccountPage
    {
        private IWebDriver driver;
        readonly By textAccountDeleted = By.XPath("//h2[@data-qa='account-deleted']");
        readonly By buttonContinueFinal = By.XPath("//a[@data-qa='continue-button']");

        public DeleteAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            var _textAccountDeleted = driver.FindElement(textAccountDeleted);
            _textAccountDeleted.Click();
            string textAccount = _textAccountDeleted.Text;
            StringAssert.AreEqualIgnoringCase("Account Deleted!", textAccount, "step 18 failed");
        }

        public MainMenuPage ToMainPage(IWebDriver driver)
        {

            var _buttonContinueFinal = driver.FindElement(buttonContinueFinal);
            _buttonContinueFinal.Click();

            return new MainMenuPage(driver);
        }

    }
}

