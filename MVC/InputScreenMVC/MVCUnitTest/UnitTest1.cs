using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InputScreenMVC.Controllers;
using System.Web.Mvc;


namespace MVCUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DisplayCustomer()
        {
            CustomerController obj = new CustomerController();
            var varresult = obj.DisplayCustomer();
            Assert.AreEqual("DisplayCustomer", varresult);
        }
    }
}
