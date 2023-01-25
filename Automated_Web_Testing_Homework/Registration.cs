using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Automated_Web_Testing_Homework
{
    public class Registration : Base
    {
        
        IWebElement username => driver.FindElement(By.Id("sign-username"));
        IWebElement password => driver.FindElement(By.Id("sign-password"));
        IWebElement signup => driver.FindElement(By.Id("signin2"));
        IWebElement signup2 => driver.FindElement(By.XPath("(//button[@class='btn btn-primary'])[2]"));
        IWebElement close => driver.FindElement(By.XPath("(//button[@class='close'])[2]"));

        public void Registration_test (string Username, string Password)
        {
            
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            
            signup.Click();
            ExplicitWait.WaitUntilClickableByXPath("//input[@id='sign-username']");
            username.SendKeys(Username);
            password.SendKeys(Password);

            signup2.Click();
            Console.WriteLine("Sign up button is clicked");
            ExplicitWait.WaitUntilAlertPresent();
            var alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            Assert.That(alert.Text, Is.EqualTo("Sign up successful."));
            alert.Accept();
            ExplicitWait.WaitUntilClickableByXPath("(//button[@class='close'])[2]");
            close.Click();
        }
    }
}