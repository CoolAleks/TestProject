using OpenQA.Selenium;
using TestProject.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.PageObject
{
    public class SignupPage
    {
        private IWebDriver driver;
        private readonly By signupPage = By.XPath("//b[text()='Enter Account Information']");
        private readonly By fildTitleGenderMrSignup = By.XPath("//div[@id='uniform-id_gender1']");
        private readonly By fildPasswordSignup = By.XPath("//input[@id='password']");
        private readonly By fildDateOfBirthDays = By.XPath("//select[@id='days']");
        private readonly By day = By.XPath("//option[@value='1']");
        private readonly By fildDateOfBirthMonths = By.XPath("//select[@id='months']");
        private readonly By months = By.XPath("//option[@value='6']");
        private readonly By fildDateOfBirthYears = By.XPath("//select[@id='years']");
        private readonly By years = By.XPath("//option[@value='1982']");
        private readonly By checkboxNewsletter = By.XPath("//*[@id='newsletter']");
        private readonly By checkboxSpecialOffers = By.XPath("//*[@id='optin']");
        private readonly By firstName = By.XPath("//input[@id='first_name']");
        private readonly By lastName = By.XPath("//input[@id='last_name']");
        private readonly By company = By.XPath("//input[@id='company']");
        private readonly By address = By.XPath("//input[@id='address1']");
        private readonly By address2 = By.XPath("//input[@id='address2']");
        private readonly By country = By.XPath("//select[@id='country']");
        private readonly By countryCanada = By.XPath("//option[@value='Canada']");
        private readonly By state = By.XPath("//input[@id='state']");
        private readonly By city = By.XPath("//input[@id='city']");
        private readonly By zipcode = By.XPath("//input[@id='zipcode']");
        private readonly By mobileNumber = By.XPath("//input[@id='mobile_number']");
        private readonly By buttonCreateAccount = By.XPath("//button[text()='Create Account']");



        public SignupPage(IWebDriver driver)
        {
            this.driver = driver;
            var _signupPage = driver.FindElement(signupPage);
            string res = _signupPage.Text;
            StringAssert.AreEqualIgnoringCase("Enter Account Information", res, "step SignupPage failed");
        }


        public AccountCreatedPage FillingFields(IWebDriver driver)
        {
            var _fildTitleGenderMrSignup = driver.FindElement(fildTitleGenderMrSignup);
            _fildTitleGenderMrSignup.Click();

            var _fildPasswordSignup = driver.FindElement(fildPasswordSignup);
            _fildPasswordSignup.SendKeys("qwert12345");

            var _fildDateOfBirthDays = driver.FindElement(fildDateOfBirthDays);
            _fildDateOfBirthDays.Click();

            var _day = driver.FindElement(day);
            _day.Click();

            var _fildDateOfBirthMonths = driver.FindElement(fildDateOfBirthMonths);
            _fildDateOfBirthMonths.Click();

            var _months = driver.FindElement(months);
            _months.Click();

            var _fildDateOfBirthYears = driver.FindElement(fildDateOfBirthYears);
            _fildDateOfBirthYears.Click();

            var _years = driver.FindElement(years);
            _years.Click();

            var _checkboxNewsletter = driver.FindElement(checkboxNewsletter);
            _checkboxNewsletter.Click();

            var _checkboxSpecialOffers = driver.FindElement(checkboxSpecialOffers);
            _checkboxSpecialOffers.Click();

            var _firstName = driver.FindElement(firstName);
            _firstName.SendKeys(Faker.Name.First());

            var _lastName = driver.FindElement(lastName);
            _lastName.SendKeys(Faker.Name.Last());

            var _company = driver.FindElement(company);
            _company.SendKeys(Faker.Company.Name());

            var _address = driver.FindElement(address);
            _address.SendKeys(Faker.Address.StreetAddress());

            var _address2 = driver.FindElement(address2);
            _address2.SendKeys(Faker.Address.StreetAddress());

            var _country = driver.FindElement(country);
            _country.Click();

            var _countryCanada = driver.FindElement(countryCanada);
            _countryCanada.Click();

            var _state = driver.FindElement(state);
            _state.SendKeys(Faker.Address.Country());

            var _city = driver.FindElement(city);
            _city.SendKeys(Faker.Address.City());

            var _zipcode = driver.FindElement(zipcode);
            _zipcode.SendKeys(Faker.Address.ZipCode());

            var _mobileNumber = driver.FindElement(mobileNumber);
            _mobileNumber.SendKeys(Faker.Phone.Number());

            var _buttonCreateAccount = driver.FindElement(buttonCreateAccount);
            _buttonCreateAccount.Click();

            var ArrayCountry = driver.FindElements(By.XPath("//*[@id='country']/option"));
            foreach (IWebElement item in ArrayCountry)
            {
                Console.WriteLine(item.Text);
            };



            return new AccountCreatedPage(driver);
        }
    }
}

