namespace NUnitTestCabInvoice
{
    using Cab_Invoice_Generator;
    using NUnit.Framework;

    /// <summary>
    /// Test class
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// initialize null
        /// </summary>
       private CabInvoiceMain cabInvoiceMain = null;

        /// <summary>
        /// setup method to create object of main class
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.cabInvoiceMain = new CabInvoiceMain();
        }

        /// <summary>
        /// test method for positive 
        /// </summary>
        [Test]
        public void GivenDistanceAndTime_shouldReturnTotalFareOfJourny()
        {
            double result = this.cabInvoiceMain.GetTotakFare(2, 10);
            Assert.AreEqual(30, result);
        }

        /// <summary>
        /// test method for negative
        /// </summary>
        [Test]
        public void GivenDistanceAndTime_shouldReturnTotalFareOfJournyNegative()
        {
            double result = this.cabInvoiceMain.GetTotakFare(2, 10);
            Assert.AreNotEqual(20, result);
        }
    }
}