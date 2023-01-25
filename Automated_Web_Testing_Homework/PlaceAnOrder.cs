using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Automated_Web_Testing_Homework
{

    public class PlaceAnOrder : Base
    {

        IWebElement name => driver.FindElement(By.Id("name"));
        IWebElement country => driver.FindElement(By.Id("country"));
        IWebElement city => driver.FindElement(By.Id("city"));
        IWebElement card => driver.FindElement(By.Id("card"));
        IWebElement month => driver.FindElement(By.Id("month"));
        IWebElement year => driver.FindElement(By.Id("year"));
        IWebElement PlaceOrderButton => driver.FindElement(By.XPath("(//button[@class='btn btn-success'])"));
        IWebElement Purchase => driver.FindElement(By.XPath("(//button[@class='btn btn-primary'])[3]"));
        IWebElement cart => driver.FindElement(By.XPath("(//a[@class='nav-link'])[4]"));
        IWebElement purchaseOk => driver.FindElement(By.XPath("(//button[@class='confirm btn btn-lg btn-primary'])"));
        

        public void PlaceAnOrderTest(string Name, string Country, string City, string Card, string Month, string Year)
        {

            cart.Click();
            PlaceOrderButton.Click();
            ExplicitWait.WaitUntilClickableByXPath("(//input[@id='name'])");
            name.SendKeys(Name);
            country.SendKeys(Country);
            city.SendKeys(City);
            card.SendKeys(Card);
            month.SendKeys(Month);
            year.SendKeys(Year);
            Purchase.Click();
            Console.WriteLine("Purchase is clicked");
            ExplicitWait.WaitUntilClickableByXPath("(//button[@class='confirm btn btn-lg btn-primary'])");
            purchaseOk.Click();
            Console.WriteLine("Purchase was successfull");
            
        }

    }
}
