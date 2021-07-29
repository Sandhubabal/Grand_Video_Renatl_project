using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grand_Video_Renatl_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Video_Renatl_project.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        DatabaseInteractions databaseInteractions = new Grand_Video_Renatl_project.DatabaseInteractions();
        [TestMethod]

        public void TestMethod1()
        {

            databaseInteractions.Operations("Insert into Customers Values('Name','Test@gmail.com','9999999999','Address')");
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void TestMethod2()
        {
            databaseInteractions.Operations("Delete from Customers where CustomerId = 1");
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void TestMethod3()
        {
            databaseInteractions.Operations("Insert into Rentals Values(1,1,'28 June 2021','28 June 2022')");
            Assert.IsTrue(true);
        }



    }
}