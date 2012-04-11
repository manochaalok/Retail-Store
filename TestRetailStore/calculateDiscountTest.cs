using RetailStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BO;

namespace TestRetailStore
{
    
    
    /// <summary>
    ///This is a test class for calculateDiscountTest and is intended
    ///to contain all calculateDiscountTest Unit Tests
    ///</summary>
    [TestClass()]
    public class calculateDiscountTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetPercentageDiscount
        ///</summary>
        [TestMethod()]
        public void GetPercentageDiscountTest()
        {
            calculateDiscount_Accessor target = new calculateDiscount_Accessor(); // TODO: Initialize to an appropriate value
            string custID = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetPercentageDiscount(custID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getNetAmount
        ///</summary>
        [TestMethod()]
        public void getNetAmountTest()
        {
            CustomerInfo oCustomerInfo = null; // TODO: Initialize to an appropriate value
            CustomerInfo expected = null; // TODO: Initialize to an appropriate value
            CustomerInfo actual;
            actual = calculateDiscount.getNetAmount(oCustomerInfo);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateInstance
        ///</summary>
        [TestMethod()]
        public void CreateInstanceTest()
        {
            calculateDiscount expected = null; // TODO: Initialize to an appropriate value
            calculateDiscount actual;
            actual = calculateDiscount.CreateInstance();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for calculateDiscount Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("RetailStore.exe")]
        public void calculateDiscountConstructorTest()
        {
            calculateDiscount_Accessor target = new calculateDiscount_Accessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
