using Automated_Web_Testing_Homework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Automated_Web_Testing_Homework
{
 
    public class Tests : Hooks
    {
        [Test, Order(1)]
        public void Registration_test()
        {
            Registration RegistrationPage = new Registration();
            RegistrationPage.Registration_test("Rusne01251", "RusnesSlaptazodis");
        }

        [Test, Order(2)]
        public void Login_test()
        {
            Login LoginPage = new Login();
            LoginPage.Login_test("Rusne01251", "RusnesSlaptazodis");
        }

        [Test, Order(3)]
        public void AddToCartTest()
        {
            AddToCart AddingToCart = new AddToCart();
            AddingToCart.AddToTest();
        }

        [Test, Order(4)]
        public void PlaceAnOrderTest()
        {
            PlaceAnOrder PlacingOrder = new PlaceAnOrder();
            PlacingOrder.PlaceAnOrderTest("Rusne01251", "Lietuva", "Vilnius", "123456", "01", "2023");
        }
    }

}