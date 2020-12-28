using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
namespace Integration_Testing
{
    class ITest
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(@"D:\3-2\SWE 4604 (Testing Lab)\Lab 8");
        }
        [Test]
        public void test()
        {
            driver.Url = "http://result.ewubd.edu";
            IWebElement element = driver.FindElement(By.Name("txtstudid"));
            element.SendKeys("Your Id");
            IWebElement password = driver.FindElement(By.Name("txtpass"));
            password.SendKeys("Your Password");
            driver.FindElement(By.Id("studlogin")).Click();
            String at = driver.Title;

            String et = "East West University";
            if (at == et)
            {
                Console.WriteLine("Test Successful");
                IWebElement element2 =
                driver.FindElement(By.XPath("/html/body/table/tbody/tr[4]/td/div/div/div[2]/a"));
                element2.Click();
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}