using DoclerStudyTCs.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;

namespace DoclerStudyTCs
{
    [TestFixture]
    public class TestClass
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;

        [SetUp]
        public void SetUp()
        {
            // Need to use an exact path because otherwise got this error: "OpenQA.Selenium.DriverServiceNotFoundException"
            // Please insert and change the Chrome driver's path from the project's 'packages' folder below: 
            driver = new ChromeDriver(@"C:\Users\EZCSUGA\source\repos\DoclerStudyTCs\packages\Selenium.Chrome.WebDriver.2.38\driver");
            //driver = new ChromeDriver();
            baseURL = "http://uitest.duodecadits.com";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        //[Test]
        public void TheTestClass()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.Manage().Window.Maximize();

            HomePage home = new HomePage(driver);
            home.InspectHomePages();

            FormPage form = new FormPage(driver);
            form.InspectFormPage();

            ErrorPage error = new ErrorPage(driver);
            error.InspectErrorPage();
        }

    }
}