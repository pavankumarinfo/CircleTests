using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using CirclesSeleniumTestScripts.PageElements;
using CirclesSeleniumTestScripts.PageFlows;

namespace CirclesSeleniumTestScripts
{
    public class Program
    {
        //gmail demo account:
        //userid: selenium100test@gmail.com 
        //pwd : @bc123456
        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
          
            CircleLoginFlows.NavigateCirclesLoginPage(driver);

            Helper.Sleep(driver, 100000);
            driver.Close();

        }
    }
}
