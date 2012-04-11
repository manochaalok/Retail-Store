using RetailStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace TestRetailStore
{
    
    
    /// <summary>
    ///This is a test class for getDataTest and is intended
    ///to contain all getDataTest Unit Tests
    ///</summary>
    [TestClass()]
    public class getDataTest
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
        ///A test for getCustomerType
        ///</summary>
        [TestMethod()]
        public void getCustomerTypeTest()
        {
            string strCustID = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = getData.getCustomerType(strCustID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getDiscountData
        ///</summary>
        [TestMethod()]
        public void getDiscountDataTest()
        {
            Hashtable dtDiscountData = null; // TODO: Initialize to an appropriate value
            Hashtable expected = null; // TODO: Initialize to an appropriate value
            Hashtable actual;
            actual = getData.getDiscountData(dtDiscountData);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
