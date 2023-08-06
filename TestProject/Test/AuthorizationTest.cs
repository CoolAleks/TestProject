using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.PageObject;
using OpenQA.Selenium.Chrome;
using TestProject.Helpers;

namespace TestProject.Test
{
    public class AuthorizationTest : BaseClass



    {

        [Test]
        public void MainMenuPage()
        {
            MainMenuPage mainMenuPage = new MainMenuPage(driver);
            LoginPage loginPage = mainMenuPage.LoginButtonClick(driver);
            SignupPage signupPage = loginPage.SignupButtonClick(driver);
            AccountCreatedPage accountCreatedPage = signupPage.FillingFields(driver);
            LoggedAccountPage loggedAccountPage = accountCreatedPage.ButtonNextClick(driver);
            DeleteAccountPage deleteAccountPage = loggedAccountPage.DeleteAccount(driver);
            deleteAccountPage.ToMainPage(driver);

        }
    }
}
