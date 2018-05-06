using OpenQA.Selenium;
using CirclesSeleniumTestScripts.PageElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CirclesSeleniumTestScripts.PageFlows
{
    public static class CircleLoginFlows
    {

        public static IWebDriver NavigateCirclesLoginPage(IWebDriver driver)
        {
            Helper.NavigatetoCirclesPages(driver, Circlesurls.circlesHomePage);
            Helper.NavigatetoCirclesPages(driver, Circlesurls.circlesLoginPage);
            CirclesLoginElements circleloginpage = new CirclesLoginElements(driver);

            circleloginpage.CirclesLoginTextBox.SendKeys(username.loginID);
            circleloginpage.CirclesPasswordTextBox.SendKeys(loginpassword.password);
            circleloginpage.CirclesLoginButton.Click();
            return driver;
        }

        public static IWebDriver VerifyCirclesVerifyPage(IWebDriver driver)
        {

            Helper.Sleep(driver, 10000);
            Helper.NavigatetoCirclesPages(driver, Circlesurls.circlesUserProfilePage);
            Helper.Sleep(driver, 10000);

            CirclesLoginElements circleloginpage = new CirclesLoginElements(driver);
            Assert.AreEqual("pavan.circles@gmail.com", circleloginpage.UserProfilePageEmailAddress.Text);
            Helper.NavigatetoCirclesPages(driver, Circlesurls.circlesHomePage);
            return driver;
        }
    }
}
