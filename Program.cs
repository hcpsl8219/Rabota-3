using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Rabota3
{
    [TestFixture]
    public class Program
    {
        IWebDriver webDriver = new FirefoxDriver();

        [TestCase]


        public void yaru_request()
        {
            webDriver.Url = "https://www.avito.ru";
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/div[2]/div/form/div/div[1]/div[7]/div/input[1]"));
            bool status = button.Click;
            webDriver.Navigate().Back();

            IWebElement search = webDriver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div/div[2]/div/div/div/label[1]"));
            search.SendKeys("телевизор");
            webDriver.Navigate().Back();

            IWebElement element = webDriver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[1]/div[1]/span/a"));
            bool status1 = element.Enabled;
            IWebElement botton1 = webDriver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[1]/div[1]/span/a"));
            botton1.Click();
            webDriver.Navigate().Back();

            IWebElement element2 = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[1]/div[5]/div/a/div/img"));
            string text = element2.Text;
            IWebElement botton2 = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/ul/li[3]/a"));
            botton2.Click();
            webDriver.Navigate().Back();

            IWebElement botton3 = webDriver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/a"));
            botton3.Click();
        }

        [TearDown]
        public void testEnd()
        {
            webDriver.Quit();
        }
    }
}
