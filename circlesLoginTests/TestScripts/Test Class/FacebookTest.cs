using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using CirclesSeleniumTestScripts.PageFlows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CirclesSeleniumTestScripts.PageElements;

namespace CirclesSeleniumTestScripts.Test_Class
{
    [TestClass]
    public class FacebookTest
    {
      

        [TestMethod]
        public void LoginIntoFacebook()
        {
            IWebDriver driver = new ChromeDriver();

            Helper.NavigatetoCirclesPages(driver, Circlesurls.FacebookUrl);
            Helper.Sleep(driver,2000);
            FacebookLoginFlows.NavigateFacebookLoginPage(driver);
        }

    }
}
