using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Demo_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Testing" + Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Quit();
        }
    }
}
