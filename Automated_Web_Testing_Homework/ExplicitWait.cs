using Automated_Web_Testing_Homework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automated_Web_Testing_Homework
{

    public class ExplicitWait : Base
    {
        public static void ClickWhenReady(IWebElement element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();

        }

        public static void WaitUntilClickableByXPath ( string XPath)
        {
        new WebDriverWait(driver, TimeSpan.FromMilliseconds(1000)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(XPath)));


        }

        public static void WaitUntilAlertPresent()
        {
            new WebDriverWait(driver, TimeSpan.FromMilliseconds(1000)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());


        }


    }
}
