using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst.Pages
{
    class MyAccountPage
    {
        private IWebDriver driver;

        public MyAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("myaccount-link-list")));
        }

        public bool IsPageDisplayed()
        {
            By myAccount = By.ClassName("myaccount-link-list");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(myAccount)).Displayed;
        }
        public IWebElement LogOutButton()
        {
            By logout = By.XPath("//a[@class='logout']");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(logout));
        }

    }
}
