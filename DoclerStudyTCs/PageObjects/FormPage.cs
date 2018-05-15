using OpenQA.Selenium;
using NUnit.Framework;

namespace DoclerStudyTCs.PageObjects
{
    public class FormPage
    {
        private IWebDriver driver;

        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void InspectFormPage()
        {
            // Check that after clicking the 'form' button we are on the 'Form' page. REQ-UI-05.
            driver.FindElement(By.XPath("//a[contains(@href, '/form.html')]")).Click();

            string[] users = new string[4];
            users[0] = "John";
            users[1] = "Sophia";
            users[2] = "Charlie";
            users[3] = "Emily";

            foreach (string i in users)
            {
                // Check that there are an input box and a submit button. REQ-UI-11.
                driver.FindElement(By.Id("hello-input")).SendKeys(i);
                driver.FindElement(By.Id("hello-submit")).Click();

                // Check the required output on the Hello page. REQ-UI-12.
                Assert.AreEqual("Hello " + i + "!", driver.FindElement(By.CssSelector("h1")).Text);
                Assert.AreEqual("UI Testing Site", driver.Title);
                Assert.AreEqual("", driver.FindElement(By.Id("dh_logo")).Text);
                driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
            }

        }
    }
}
