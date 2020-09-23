namespace NUnitTestCabInvoice
{
    using Cab_Invoice_Generator;
    using NUnit.Framework;
    using System.Resources;

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
            double result = this.cabInvoiceMain.GetTotalFare(2, 10);
            Assert.AreEqual(30, result);
        }

        /// <summary>
        /// test method for negative
        /// </summary>
        [Test]
        public void GivenDistanceAndTime_shouldReturnTotalFareOfJournyNegative()
        {
            double result = this.cabInvoiceMain.GetTotalFare(2, 10);
            Assert.AreNotEqual(20, result);
        }

        /// <summary>
        /// test method for positive
        /// </summary>
        [Test]
        public void GivenMultipleInvoiceFare_shouldReturnTotalFareOfJourny()
        {
            Ride[] rides = { new Ride(2, 5), new Ride(0.1, 1) };
            double result = this.cabInvoiceMain.GetTotxalFare(rides);
            Assert.AreEqual(30, result);
        }

        /// <summary>
        /// test method for negative
        /// </summary>
        [Test]
        public void GivenMultipleInvoiceFare_shouldReturnTotalFareOfJournyNegative()
        {
            Ride[] rides = { new Ride(2, 5), new Ride(0.1, 1) };
            double result = this.cabInvoiceMain.GetTotxalFare(rides);
            Assert.AreNotEqual(20, result);
        }

        /// <summary>
        /// test method for positive
        /// </summary>
        [Test]
        public void GivenMultipleInvoiceFare_shouldReturnTMultipleFields()
        {
            Ride[] rides = { new Ride(2, 5), new Ride(0.1, 1) };
            InvoiceSummary result = cabInvoiceMain.CalculateFare(rides);
            InvoiceSummary expectedinvoiceSummary = new InvoiceSummary(2, 30);
            Assert.AreEqual(expectedinvoiceSummary, result);
        }

        /// <summary>
        /// test method for negative
        /// </summary>
        [Test]
        public void GivenMultipleInvoiceFare_shouldReturnTMultipleFieldsNegative()
        {
            Ride[] rides = { new Ride(2, 5), new Ride(0.1, 1) };
            InvoiceSummary result = cabInvoiceMain.CalculateFare(rides);
            InvoiceSummary expectedinvoiceSummary = new InvoiceSummary(1, 30);
            Assert.AreNotEqual(expectedinvoiceSummary, result);
        }
    }
}