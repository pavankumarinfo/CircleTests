using System;
using System.Drawing.Imaging;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace CirclesSeleniumTestScripts
{
    public static class Circlesurls
    {
        public static string gmailhomepage = "https://www.google.com/gmail/about/";
        public static string gmailloginpage = "http://gmail.com";
        public static string gmailloginsuccesspage = "https://mail.google.com/mail/#inbox";
        public static string FacebookUrl = "https://en-gb.facebook.com/"; //"https://www.facebook.com/";
        public static string circlesHomePage = "https://pages.circles.life/";
        public static string circlesLoginPage = "https://shop.circles.life/login";
        public static string circlesUserHomePage = "https://shop.circles.life/my_profile";
        public static string circlesUserProfilePage = "https://shop.circles.life/my_profile";
    }

    public static class username
    {
        public static string loginID = "pavan.circles@gmail.com";

    }

    public static class loginpassword
    {
        public static string password = "Abc123456";
    }

    public static class Helper
    {
        public static void NavigatetoCirclesPages(IWebDriver driver, string UrlPage)
        {
            driver.Navigate().GoToUrl(UrlPage);
        }

        public static bool clickDropdownSelectItem(IWebDriver driver, IWebElement dropdownelement, string texttoSearch = null,
            int position = 0)
        {
            int positionitem = 0;
            bool returnvalue = false;
            SelectElement ss = new SelectElement(dropdownelement);
            foreach (IWebElement element in ss.Options)
            {
                positionitem += 1;
                if (!string.IsNullOrEmpty(texttoSearch))
                {
                    if (element.Text.ToLower() == texttoSearch.ToLower())
                    {
                        element.Click();
                        returnvalue = true;
                        break;
                    }
                }
                if (position > 0)
                {
                    if (positionitem == position)
                    {
                        element.Click();
                        returnvalue = true;
                        break;
                    }
                }
            }
            return returnvalue;
        }

        public static void Sleep(IWebDriver driver, int micorSeconds)
        {
            System.Threading.Thread.Sleep(micorSeconds);
        }
        public static bool waitTillElementisDisplayed(IWebDriver driver, IWebElement webelement, int timeoutInSeconds)
        {
            bool elementDisplayed = false;

            for (int i = 0; i < timeoutInSeconds; i++)
            {
                try
                {
                    if (timeoutInSeconds > 0)
                    {
                        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                        wait.Until(drv => webelement);
                    }
                    elementDisplayed = webelement.Displayed;
                }
                catch
                { }
            }
            return elementDisplayed;

        }

        public static void TakeScreenshot(IWebDriver webdriver)
        {
            // And then the usage would be:

            ScreenShotRemoteWebDriver webDriver = new ScreenShotRemoteWebDriver(
                new Uri("http://127.0.0.1:4444/wd/hub"), DesiredCapabilities.Firefox());
            // ... do stuff with webDriver
            Screenshot ss = ((ITakesScreenshot)webDriver).GetScreenshot();
            string screenshot = ss.AsBase64EncodedString;
            byte[] screenshotAsByteArray = ss.AsByteArray;
            //ss.SaveAsFile(activeDir + TestSuiteName + "//" + FileNanme + imageFormat, ImageFormat.Jpeg);
        }

        public static IWebElement WaitForElementToAppear(IWebDriver driver, int waitTime, By waitingElement)
        {
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime)).Until(ExpectedConditions.ElementExists(waitingElement));
            return wait;
        }

        public static void browserScreenshot(IWebDriver driver)
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile("c:/test.png", ImageFormat.Png);
        }

        public static bool IsElementExists(IWebElement element)
        {
            try
            {
                if (element != null)
                {
                    return true;
                }
            }
            catch (NoSuchElementException) { return false; }
            catch (StaleElementReferenceException) { return false; }
            return true;
        }

        public static string generateNewStoreName(string country, string envrionment)
        {
            return country + envrionment + string.Format(@"{0}.txt", DateTime.Now.Ticks);
        }
    }
    public class ScreenShotRemoteWebDriver : RemoteWebDriver, ITakesScreenshot
    {
        public ScreenShotRemoteWebDriver(Uri RemoteAdress, ICapabilities capabilities)
        : base(RemoteAdress, capabilities)
        {
        }

        /// <summary>
        /// Gets a <see cref="Screenshot"/> object representing the image of the page on the screen.
        /// </summary>
        /// <returns>A <see cref="Screenshot"/> object containing the image.</returns>
        public Screenshot GetScreenshot()
        {
            // Get the screenshot as base64.
            Response screenshotResponse = this.Execute(DriverCommand.Screenshot, null);
            string base64 = screenshotResponse.Value.ToString();

            // ... and convert it.
            return new Screenshot(base64);
        }
    }
}
