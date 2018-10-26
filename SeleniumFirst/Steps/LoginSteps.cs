using NUnit.Framework;
using SeleniumFirst.Pages;
using System;
using TechTalk.SpecFlow;

namespace SeleniumFirst.Steps
{
    //[Binding]
    //public class LoginSteps : BaseSteps
    //{
    //    [Given(@"User navigates to automation practice web site 2")]
    //    public void GivenUserNavigatesToAutomationPracticeWebSite()
    //    {
    //        Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
    //    }

    //    [Given(@"user clicks on sign in button 2")]
    //    public void GivenUserClicksOnSignInButton()
    //    {
    //        HomePage homePage = new HomePage(Driver);
    //        homePage.SignInLink().Click();
    //    }

    //    [Given(@"authentication page is displayed 2")]
    //    public void GivenAuthenticationPageIsDisplayed()
    //    {
    //        AuthenticationPageLogin authPage = new AuthenticationPageLogin(Driver);
    //        Assert.That(authPage.IsPageDisplayed(), Is.True, "Authentification page is not displayed.");
    //    }

    //    [When(@"user enters valid email address and password")]
    //    public void WhenUserEntersValidEmailAddressAndPassword()
    //    {
    //        AuthenticationPageLogin authPage = new AuthenticationPageLogin(Driver);
    //        authPage.EmailInputField().SendKeys("zoran123@gmail.com");
    //        authPage.PasswordInputField().SendKeys("123456");
    //    }

    //    [When(@"user clicks on the sign in button")]
    //    public void WhenUserClicksOnTheSignInButton()
    //    {
    //        AuthenticationPageLogin authPage = new AuthenticationPageLogin(Driver);
    //        authPage.SignInButton().Click();
    //    }

    //    [Then(@"user is successfuly signed in")]
    //    public void ThenUserIsSuccessfulySignedIn()
    //    {
    //        MyAccountPage myAccountPage = new MyAccountPage(Driver);
    //        Assert.That(myAccountPage.IsPageDisplayed(), Is.True, "My account page is not displayed.");
    //    }
    //}
}
