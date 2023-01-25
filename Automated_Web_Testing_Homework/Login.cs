using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Automated_Web_Testing_Homework
{
    public class Login : Base
    {

        IWebElement username => driver.FindElement(By.Id("loginusername"));
        IWebElement password => driver.FindElement(By.Id("loginpassword"));
        IWebElement login => driver.FindElement(By.Id("login2"));
        IWebElement login2 => driver.FindElement(By.XPath("(//button[@class='btn btn-primary'])[3]"));
        IWebElement welcome => driver.FindElement(By.XPath("//a[@id='nameofuser']"));

        public void Login_test(string Username, string Password)
        {

            login.Click();
            
            ExplicitWait.WaitUntilClickableByXPath("//input[@id='loginusername']");
            username.SendKeys(Username);
            password.SendKeys(Password);

            login2.Click();
            Console.WriteLine("Log in button is clicked");
            
            ExplicitWait.WaitUntilClickableByXPath("//a[@id='nameofuser']");
            Console.WriteLine(welcome.Text);
            Assert.That(welcome.Text, Is.EqualTo("Welcome Rusne01251"));

        }

    }
}