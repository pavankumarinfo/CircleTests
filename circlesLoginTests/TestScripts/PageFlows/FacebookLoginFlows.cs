using OpenQA.Selenium;
using CirclesSeleniumTestScripts.PageElements;

namespace CirclesSeleniumTestScripts.PageFlows
{
    public static class FacebookLoginFlows
    {
      
        public static IWebDriver NavigateFacebookLoginPage(IWebDriver driver)
        {
            Helper.NavigatetoCirclesPages(driver, Circlesurls.FacebookUrl);
            Helper.Sleep(driver, 5000);

            FacebookLoginPageElements facebookLoginPage = new FacebookLoginPageElements(driver);
            facebookLoginPage.facebookLoginEmailTextBox.SendKeys(username.loginID);
            facebookLoginPage.facebookLoginPasswordTextBox.SendKeys(loginpassword.password);
            Helper.Sleep(driver, 2000);
            facebookLoginPage.facebookLoginSubmitButton.Click();
            return driver;
        }

        public static IWebDriver NavigateFacebookLogoutPage(IWebDriver driver)
        {
            FacebookLoginPageElements facebookloginelements = new FacebookLoginPageElements(driver);
            facebookloginelements.FacebookLogoutButton.Click();
            return driver;
        }
    }
}
