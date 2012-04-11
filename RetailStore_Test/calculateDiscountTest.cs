using RetailStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BO;
using System.Collections;

namespace RetailStore_Test
{
    
    [TestClass()]
    public class calculateDiscountTest
    {
        private TestContext testContextInstance;
        Hashtable dtDiscountData = new Hashtable();
            
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
        [DeploymentItem("RetailStore.exe")]
        public void GetPercentageDiscountTest()
        {
            calculateDiscount_Accessor target = new calculateDiscount_Accessor();
            dtDiscountData.Add("Employee", 30);
            dtDiscountData.Add("Affiliate", 10);
            dtDiscountData.Add("ExistingCustomerMoreThanTwoyrs", 5);
            dtDiscountData.Add("NonExistingCust", 0);
            calculateDiscount_Accessor.dtDiscountData =  dtDiscountData;;
            string custID = "22222";
            int expected = 10;
            int actual;
            actual = target.GetPercentageDiscount(custID);
            Assert.AreEqual(expected, actual);
           
        }

        [TestMethod()]
        [DeploymentItem("RetailStore.exe")]
        public void getNetAmountTest()
        {
            CustomerInfo_Accessor oCustomerInfo = new CustomerInfo_Accessor();
            oCustomerInfo.GrocAmount = 100;
            oCustomerInfo.NonGrocAmount = 100;
            oCustomerInfo.PercDiscount = 10;
            oCustomerInfo.CustomerId = 22222;
            CustomerInfo_Accessor expected = new CustomerInfo_Accessor();
            expected.PercDiscount = 10;
            expected.NetAmount = 185;
            expected.CashDiscount = 5;
            CustomerInfo_Accessor actual = new CustomerInfo_Accessor(); ;
            actual = calculateDiscount_Accessor.getNetAmount(oCustomerInfo);
            Assert.AreEqual(expected.PercDiscount, actual.PercDiscount);
            Assert.AreEqual(expected.NetAmount, actual.NetAmount);
            Assert.AreEqual(expected.CashDiscount, actual.CashDiscount);
            
        }

        [TestMethod()]
        [DeploymentItem("RetailStore.exe")]
        public void calculateDiscountConstructorTest()
        {
            calculateDiscount_Accessor target = new calculateDiscount_Accessor();
            
        }
    }
}
