using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumFirst.Pages;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SeleniumFirst.Steps
{
    [Binding]
    public class RegistrationSteps : BaseSteps
    {
        
        readonly string emailValue = "zoran132257338@gmail.com";
        readonly string name = "Jovan";
        readonly string lastname = "Jovanovic";
       
        //Tests for creating account
        [Given(@"User navigates to automation practice web site")]
        public void GivenUserNavigatesToAutomationPracticeWebSite()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [Given(@"user clicks on sign in button")]
        public void GivenUserClicksOnSignInButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.SignInLink().Click();
        }

        [Then(@"authentication page is displayed")]
        public void GivenAuthenticationPageIsDisplayed()
        {
            AuthenticationPage authPage = new AuthenticationPage(Driver);
            Assert.That(authPage.IsPageDisplayed(), Is.True, "Authentification page is not displayed.");
        }

        [When(@"user enters valid email address")]
        public void WhenUserEntersValidEmailAddress()
        {
            AuthenticationPage authPage = new AuthenticationPage(Driver);
            authPage.EmailInputField().SendKeys(emailValue);
            string userEmail = authPage.EmailInputField().GetAttribute("vaule");
        }

        [When(@"user clicks on the Create an account button")]
        public void WhenUserClicksOnCreateAnAccountButton()
        {
            AuthenticationPage authPage = new AuthenticationPage(Driver);
            authPage.CreateAnAccountButton().Click();
        }
        [Then(@"create an account page is displayed")]
        public void UserIsRedirectedToCreateAnAccountPage()
        {
            CreateAccountPage CreateAcc = new CreateAccountPage(Driver);
            Assert.That(CreateAcc.IsPageDisplayed(), Is.True, "Authentification page is not displayed.");
        }

        [When(@"user enters valid data")]
        public void WhenEntersValidData()
        {
            CreateAccountPage createAccPage = new CreateAccountPage(Driver);

            createAccPage.MrClickable().Click();
            //createAccPage.MrsClickable().Click();

            createAccPage.FirstNameInputField().SendKeys(name);
            createAccPage.LastNameInputField().SendKeys(lastname);


            createAccPage.EmailField().Equals(emailValue);

            createAccPage.CustomerPassword().SendKeys("123456");

            SelectElement daySelect = new SelectElement(createAccPage.DateOfBirth());
            daySelect.SelectByValue("2");
            SelectElement monthSelect = new SelectElement(createAccPage.MonthOfBirth());
            monthSelect.SelectByValue("4");
            SelectElement yearSelect = new SelectElement(createAccPage.YearOfBirth());
            yearSelect.SelectByValue("2000");

            createAccPage.SignUpCheckBox().Click();
            createAccPage.ReceiveCheckBox().Click();

            createAccPage.FirstName().Equals(name);
            createAccPage.LastName().Equals(lastname);

            createAccPage.Company().SendKeys("Kompanija");
            createAccPage.Address().Clear();
            createAccPage.Address().SendKeys("Novosadskog Sajma");
            createAccPage.Address2().Clear();
            createAccPage.Address2().SendKeys("Jevrejska 2");
            createAccPage.City().Clear();
            createAccPage.City().SendKeys("Novi Sad");

            var contrySelect = new SelectElement(createAccPage.State());
            contrySelect.SelectByValue("1");

            var stateSelect = new SelectElement(createAccPage.State());
            stateSelect.SelectByValue("2");

            createAccPage.Additional_Info().SendKeys("sdasjdsaljdlajdladlajdsa");
            createAccPage.ZipCode().SendKeys("12345");
            createAccPage.HomePhone().SendKeys("01234567");
            createAccPage.MobilePhone().SendKeys("5555555");
            createAccPage.Assign().Clear();
            createAccPage.Assign().SendKeys("Nesto Nesto");
        }

        [When(@"click Register button")]
        public void ClickOnRegisterButton()
        {
            CreateAccountPage ClickRegistration = new CreateAccountPage(Driver);
            ClickRegistration.RegisterButton().Click();

        }

        [Then(@"user is successfully created")]
        public void ThenUserIsSuccessfulyCreated()
        {
            MyAccountPage myAccountPage = new MyAccountPage(Driver);
            Assert.That(myAccountPage.IsPageDisplayed(), Is.True, "My account page is not displayed.");
        }

        //Tests for login, user is loged out from My Account Page, and he wants to login again 

        [When(@"user clicks on sign out button")]
        public void UserClicksOnSignOutButton()
        {
            MyAccountPage ClickLogout = new MyAccountPage(Driver);
            ClickLogout.LogOutButton().Click();
        }

        [Then(@"authentication page is displayed user can login")]
        public void AuthenticationPageIsDisplayed()
        {
            AuthenticationPageLogin authPage2 = new AuthenticationPageLogin(Driver);
            Assert.That(authPage2.IsPageDisplayed(), Is.True, "Authentification page is not displayed.");
        }
        [When(@"user enters valid email address and password")]
        public void WhenUserEntersValidEmailAddressAndPassword()
        {
            AuthenticationPageLogin authPage2 = new AuthenticationPageLogin(Driver);
            authPage2.EmailInputField().SendKeys(emailValue);
            authPage2.PasswordInputField().SendKeys("123456");
        }

        [When(@"user clicks on the sign in button")]
        public void WhenUserClicksOnTheSignInButton()
        {
            AuthenticationPageLogin authPage = new AuthenticationPageLogin(Driver);
            authPage.SignInButton().Click();
        }

        [Then(@"user is successfuly signed in")]
        public void ThenUserIsSuccessfulySignedIn()
        {
            MyAccountPage myAccountPage = new MyAccountPage(Driver);
            Assert.That(myAccountPage.IsPageDisplayed(), Is.True, "My account page is not displayed.");
        }
    }


}


