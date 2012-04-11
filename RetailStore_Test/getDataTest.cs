using RetailStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace RetailStore_Test
{
   [TestClass()]
    public class getDataTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod()]
        public void getCustomerTypeTest()
        {
            string strCustID = "11111"; 
            string expected = "Employee"; 
            string actual;
            actual = getData.getCustomerType(strCustID);
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod()]
        public void getDiscountDataTest()
        {
            Hashtable dtExDiscountData = new Hashtable();
            Hashtable dtDiscountData = new Hashtable();
            dtExDiscountData.Add("Employee", 30);
            dtExDiscountData.Add("Affiliate", 10);
            dtExDiscountData.Add("ExistingCustomerMoreThanTwoyrs", 5);
            dtExDiscountData.Add("NonExistingCust", 0);
            Hashtable expected = dtExDiscountData; 
            Hashtable actual;
            actual = getData.getDiscountData(dtDiscountData);
            Assert.AreEqual(expected["Employee"], actual["Employee"]);
            Assert.AreEqual(expected["Affiliate"], actual["Affiliate"]);
            Assert.AreEqual(expected["ExistingCustomerMoreThanTwoyrs"], actual["ExistingCustomerMoreThanTwoyrs"]);
            Assert.AreEqual(expected["NonExistingCust"], actual["NonExistingCust"]);


        }
    }
}
