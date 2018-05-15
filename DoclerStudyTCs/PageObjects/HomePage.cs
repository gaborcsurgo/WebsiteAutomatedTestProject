using OpenQA.Selenium;
using NUnit.Framework;

namespace DoclerStudyTCs.PageObjects
{
    // This is the main class of the project, because of simplification it is testing other URLs too, not just the Home page
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void InspectHomePages()
        {
            string[] hpage = new string[3];
            hpage[0] = "home";
            hpage[1] = "site";
            hpage[2] = "form";

            foreach (string i in hpage)
            {
                // Clicking on the 'home', 'site', 'form' buttons.
                driver.FindElement(By.Id(i)).Click();

                // Check that the buttons are in active status. REQ-UI-04, 06.
                IWebElement button = driver.FindElement(By.Id(i));
                Assert.AreEqual(true, button.Enabled);

                // Check the title and the logo. REQ-UI-01, 02.
                Assert.AreEqual("UI Testing Site", driver.Title); 
                Assert.IsTrue(IsElementPresent(By.Id("dh_logo")));

                if (i != "form")
                {
                    // Check that after clicking the 'home' or 'UI Testing' buttons we are on the 'Home' page. REQ-UI-03, 08.
                    driver.FindElement(By.XPath("//a[contains(text(),'Home')]")).Click(); 

                    // Check the texts on home page which have <h1> or <p> tags. REQ-UI-09, 10.
                    Assert.AreEqual("Welcome to the Docler Holding QA Department", driver.FindElement(By.CssSelector("h1")).Text);
                    Assert.AreEqual("This site is dedicated to perform some exercises and demonstrate automated web testing.", driver.FindElement(By.CssSelector("p.lead")).Text);
                }
            }

        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
