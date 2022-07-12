using NUnit.Framework;
using NUnit.Framework.Internal;
using ShoppingCart_ASP.NET_MVC5.Models;
using System.ComponentModel.DataAnnotations;
using ShoppingCart_ASP.NET_MVC5.Controllers;
using System;

namespace Testing
{
    public class TestCustomers
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void username()
        {
            Customer customer = new Customer();
            string expect = "sivani";
            string Actual = customer.username = "sivani";
            Assert.AreEqual(expect, Actual);
        }
        [Test]
        public void password()
        {
            Customer customer = new Customer();
            string expect = "indra";
            string Actual = customer.password = "indra";
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void customerid()
        {
            Customer customer = new Customer();
            int expect = 201;
            int Actual = customer.customer_id = 201;
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void firstname()
        {
            Customer customer = new Customer();
            string expect = "sivani";
            string Actual = customer.firstname = "sivani";
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void sessionid()
        {
            Customer customer = new Customer();
            string expect = "32551a3c-594d-4023-8867-a0f55ec54c61";
            string Actual = customer.session_id = "32551a3c-594d-4023-8867-a0f55ec54c61";
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void productid()
        {
            AllItemList items = new AllItemList();
            int expect = 101;
            int Actual = items.pro_id = 101;
            Assert.AreEqual(expect, Actual);
            int expect2 = 102;
            int Actual2 = items.pro_id = 102;
            Assert.AreEqual(expect2, Actual2);
            int expect3 = 103;
            int Actual3 = items.pro_id = 103;
            Assert.AreEqual(expect3, Actual3);
            int expect4 = 104;
            int Actual4 = items.pro_id = 104;
            Assert.AreEqual(expect4, Actual4);
            int expect5 = 105;
            int Actual5 = items.pro_id = 105;
            Assert.AreEqual(expect5, Actual5);
            int expect6 = 106;
            int Actual6 = items.pro_id = 106;
            Assert.AreEqual(expect6, Actual6);

        }
        [Test]
        public void productname()
        {
            AllItemList items = new AllItemList();
            string expect = "Cheese Pizza";
            string Actual = items.pro_name = "Cheese Pizza";
            Assert.AreEqual(expect, Actual);
            string expect2 = "Chicken Pizza";
            string Actual2 = items.pro_name = "Chicken Pizza";
            Assert.AreEqual(expect2, Actual2);
            string expect3 = "Corn Pizza";
            string Actual3 = items.pro_name = "Corn Pizza";
            Assert.AreEqual(expect3, Actual3);
            string expect4 = "Paneer Pizza";
            string Actual4 = items.pro_name = "Paneer Pizza";
            Assert.AreEqual(expect4, Actual4);
            string expect5 = "Pepperoni Pizza";
            string Actual5 = items.pro_name = "Pepperoni Pizza";
            Assert.AreEqual(expect5, Actual5);
            string expect6 = "Veg Pizza";
            string Actual6 = items.pro_name = "Veg Pizza";
            Assert.AreEqual(expect6, Actual6);

        }
        [Test]
        public void productdescription()
        {
            AllItemList items = new AllItemList();
            string expect = "cheese pizza added double layer";
            string Actual = items.pro_desc = "cheese pizza added double layer";
            Assert.AreEqual(expect, Actual);
            string expect2 = "fresh ingrediants used to make chicken pizza";
            string Actual2 = items.pro_desc = "fresh ingrediants used to make chicken pizza";
            Assert.AreEqual(expect2, Actual2);
            string expect3 = "sweet corn is used to make corn pizza";
            string Actual3 = items.pro_desc = "sweet corn is used to make corn pizza";
            Assert.AreEqual(expect3, Actual3);
            string expect4 = "fresh milk is used to make paneer";
            string Actual4 = items.pro_desc = "fresh milk is used to make paneer";
            Assert.AreEqual(expect4, Actual4);
            string expect5 = "delicious pepporoni pizza";
            string Actual5 = items.pro_desc = "delicious pepporoni pizza";
            Assert.AreEqual(expect5, Actual5);
            string expect6 = "fresh vegetables are used";
            string Actual6 = items.pro_desc = "fresh vegetables are used";
            Assert.AreEqual(expect6, Actual6);
        }
        [Test]
        public void productprice()
        {
            AllItemList items = new AllItemList();
            int expect = 150;
            int Actual = items.pro_price = 150;
            Assert.AreEqual(expect, Actual);
            int expect2 = 200;
            int Actual2 = items.pro_price = 200;
            Assert.AreEqual(expect2, Actual2);
            int expect3 = 150;
            int Actual3 = items.pro_price = 150;
            Assert.AreEqual(expect3, Actual3);
            int expect4 = 200;
            int Actual4 = items.pro_price = 200;
            Assert.AreEqual(expect4, Actual4);
            int expect5 = 200;
            int Actual5 = items.pro_price = 200;
            Assert.AreEqual(expect5, Actual5);
            int expect6 = 150;
            int Actual6 = items.pro_price = 150;
            Assert.AreEqual(expect6, Actual6);

        }
        [Test]
        public void productimage()
        {
            AllItemList items = new AllItemList();
            string expect = "cheese pizza.jpg";
            string Actual = items.pro_image = "cheese pizza.jpg";
            Assert.AreEqual(expect, Actual);
            string expect2 = "chicken pizza.jpg";
            string Actual2 = items.pro_image = "chicken pizza.jpg";
            Assert.AreEqual(expect2, Actual2);
            string expect3 = "corn pizza.jpg";
            string Actual3 = items.pro_image = "corn pizza.jpg";
            Assert.AreEqual(expect3, Actual3);
            string expect4 = "paneer pizza.jpg";
            string Actual4 = items.pro_image = "paneer pizza.jpg";
            Assert.AreEqual(expect4, Actual4);
            string expect5 = "pepperoni pizza.jpg";
            string Actual5 = items.pro_image = "pepperoni pizza.jpg";
            Assert.AreEqual(expect5, Actual5);
            string expect6 = "veg pizza.jpg";
            string Actual6 = items.pro_image = "veg pizza.jpg";
            Assert.AreEqual(expect6, Actual6);
        }
        [Test]
        public void cartpro_id()
        {
            Cart cart = new Cart();
            int expect = 101;
            int Actual = cart.pro_id = 101;
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void cartpro_name()
        {
            Cart cart = new Cart();
            string expect = "Cheese Pizza";
            string Actual = cart.pro_name = "Cheese Pizza";
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void cartpro_desc()
        {
            Cart cart = new Cart();
            string expect = "cheese pizza added double layer";
            string Actual = cart.pro_desc = "cheese pizza added double layer";
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void cartpro_price()
        {
            Cart cart = new Cart();
            int expect = 150;
            int Actual = cart.pro_price = 150;
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void cartpro_image()
        {
            Cart cart = new Cart();
            string expect = "cheese pizza.jpg";
            string Actual = cart.pro_image = "cheese pizza.jpg";
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void cartpro_count()
        {
            Cart cart = new Cart();
            int expect = 3;
            int Actual = cart.count = 3;
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void purchaseitem_cust_id()
        {
            PurchaseItems pi = new PurchaseItems();
            int expect = 101;
            int Actual = pi.customer_id = 101;
            Assert.AreEqual(expect, Actual);
        }
        [Test]
        public void purchaseitem_pro_id()
        {
            PurchaseItems pi = new PurchaseItems();
            int expect = 101;
            int Actual = pi.customer_id = 101;
            Assert.AreEqual(expect, Actual);
        }
        [Test]
        public void purchaseitem_pro_name()
        {
            PurchaseItems pi = new PurchaseItems();
            string expect = "cheese pizza";
            string Actual = pi.pro_name = "cheese pizza";
            Assert.AreEqual(expect, Actual);
        }
        [Test]
        public void purchaseitem_pro_desc()
        {
            PurchaseItems pi = new PurchaseItems();
            string expect = "cheese pizza added double layer";
            string Actual = pi.pro_desc = "cheese pizza added double layer";
            Assert.AreEqual(expect, Actual);
        }
        [Test]
        public void purchaseitem_pro_image()
        {
            PurchaseItems pi = new PurchaseItems();
            string expect = "cheese pizza.jpg";
            string Actual = pi.pro_image = "cheese pizza.jpg";
            Assert.AreEqual(expect, Actual);
        }
        [Test]
        public void purchaseitem_pro_count()
        {
            PurchaseItems pi = new PurchaseItems();
            int expect = 4;
            int Actual = pi.count = 4;
            Assert.AreEqual(expect, Actual);
        }




    }
}