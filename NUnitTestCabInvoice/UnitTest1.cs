namespace NUnitTestCabInvoice
{
    using Cab_Invoice_Generator;
    using NUnit.Framework;

    /// <summary>
    /// Test class
    /// </summary>
    public class Tests
    {
        CabInvoiceMain cabInvoiceMain = null;

        /// <summary>
        /// setup method to create object of main class
        /// </summary>
        [SetUp]
        public void Setup()
        {
            cabInvoiceMain = new CabInvoiceMain();
        }

        /// <summary>
        /// test method
        /// </summary>
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}