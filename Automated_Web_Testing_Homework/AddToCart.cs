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
    public class AddToCart : Base
    {

        IWebElement Laptops => driver.FindElement(By.XPath("(//a[@class='list-group-item'])[3]"));
        IWebElement productcard => driver.FindElement(By.XPath("(//a[@class='hrefch'])[contains(text(),'MacBook air')]"));
        IWebElement AddToCartButton => driver.FindElement(By.XPath("//a[@class='btn btn-success btn-lg']"));

        public void AddToTest()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            ExplicitWait.WaitUntilClickableByXPath("(//a[@class='list-group-item'])[3]");
            Laptops.Click();
            Console.WriteLine("Laptops button is clicked");
            ExplicitWait.WaitUntilClickableByXPath("//a[@class='hrefch'][contains(text(),'MacBook air')]");
            productcard.Click();
            Console.WriteLine("Product card button is clicked");
            ExplicitWait.WaitUntilClickableByXPath("//a[@class='btn btn-success btn-lg']");
            AddToCartButton.Click();
            Console.WriteLine("Add to cart button is clicked");

            ExplicitWait.WaitUntilAlertPresent();
            var alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            Assert.That(alert.Text, Is.EqualTo("Product added."));
            alert.Accept();
        }



    }
}
