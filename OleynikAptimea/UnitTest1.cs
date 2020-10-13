using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace OleynikAptimea
{
    public class UnitTest1
    {
        String test_url = "http://aptimea.com/form/questionnaire";

        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_page1()
        {
            driver.Url = test_url;

            System.Threading.Thread.Sleep(200);
            driver.Navigate().GoToUrl("http://aptimea.com/form/questionnaire");


            //IWebElement cookieButton = driver.FindElement(By.CssSelector(".eu-cookie-compliance-secondary-button"));
            //cookieButton.Click();

            IWebElement genderRadio = driver.FindElement(By.Id("edit-je-suis-0"));
            genderRadio.Click();

            IWebElement yearSelect = driver.FindElement(By.Id("edit-je-suis-ne-e-en-annee-year"));
            SelectElement selectElement = new SelectElement(yearSelect);
            selectElement.SelectByValue("2002");

            IWebElement sportRadio = driver.FindElement(By.Id("edit-je-fais-du-sport-chaque-semaine-0"));
            sportRadio.Click();


            IWebElement supplementsText = driver.FindElement(By.CssSelector("[name = 'mes_traitements_medicaux_sont']"));
            supplementsText.SendKeys("Vitamin D");

            IWebElement weightNumeric = driver.FindElement(By.Id("edit-user-weight"));
            weightNumeric.SendKeys("85");

            IWebElement heightNumeric = driver.FindElement(By.Id("edit-user-height"));
            heightNumeric.SendKeys("182");

            IWebElement kidsNumeric = driver.FindElement(By.CssSelector("#edit-j-ai-enfants-nombre-"));
            kidsNumeric.SendKeys("1");

            IWebElement veganRadio = driver.FindElement(By.Id("edit-je-suis-2-2"));
            veganRadio.Click();

            IWebElement positionRadio = driver.FindElement(By.Id("edit-je-vis-0"));
            positionRadio.Click();

            IWebElement pointGoalRadio = driver.FindElement(By.Id("edit-patient-goals-29"));
            pointGoalRadio.Click();

            //IWebElement searchButton = driver.FindElement(By.Id("edit-wizard-next"));
            //searchButton.Submit();

            System.Threading.Thread.Sleep(6000);

            Console.WriteLine("Test Passed");
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}