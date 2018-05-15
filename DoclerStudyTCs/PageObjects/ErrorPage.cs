using OpenQA.Selenium;
using NUnit.Framework;

namespace DoclerStudyTCs.PageObjects
{
    public class ErrorPage
    {
        private IWebDriver driver;

        public ErrorPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void InspectErrorPage()
        {
            // Check that after clicking the 'error' button we are get a 404 error response. REQ-UI-07.
            driver.FindElement(By.Id("error")).Click();
            Assert.AreEqual("404 Error: File not found :-)", driver.Title);
        }
    }
}
