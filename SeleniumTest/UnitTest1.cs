using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;

namespace SeleniumTest
{
    public class Tests
    {

        public IWebDriver Driver;      

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Console.WriteLine("Setup"); 
        }

        [Test]  
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("apple");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
            Console.WriteLine("Test1");
            Assert.Pass();           
        }
    }
}