//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace NUnitTestCabInvoice
{
    using System.Collections.Generic;
    using Cab_Invoice_Generator;
    using NUnit.Framework;    

    /// <summary>
    /// Test class
    /// </summary>
    public class UnitTest1
    {
        /// <summary>
        /// initialize CabInvoiceMain null
        /// </summary>
       private CabInvoiceMain invoiceGenerator = null;

        /// <summary>
        /// setup method to create object
        /// </summary>
        [SetUp]
        public void Setup()
        {
          this.invoiceGenerator = new CabInvoiceMain();
        }

        /// <summary>
        /// get total fare
        /// </summary>
        [Test]
        public void GivenDistanceAndTime_ShouldReturnTotalFare()
        {
            double distance = 2.0;
            int time = 5;
            string type = "Normal";
            double fare = this.invoiceGenerator.CalculateFare(distance, time, type);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }

        /// <summary>
        /// get total fare negative
        /// </summary>
        [Test]
        public void GivenDistanceAndTime_ShouldReturnTotalFarenNegative()
        {
            double distance = 2.0;
            int time = 5;
            string type = "Normal";
            double fare = this.invoiceGenerator.CalculateFare(distance, time, type);
            double expected = 5;
            Assert.AreNotEqual(expected, fare);
        }

        /// <summary>
        /// get total fare for less distance and time
        /// </summary>
        [Test]
        public void GivenLessDistanceAndTime_ShouldReturnMinFare()
        {
            double distance = 0.1;
            int time = 1;
            string type = "Normal";
            double fare = this.invoiceGenerator.CalculateFare(distance, time, type);
            double expected = 5;
            Assert.AreEqual(expected, fare);
        }

        /// <summary>
        /// get total fare for less distance and time negative 
        /// </summary>
        [Test]
        public void GivenLessDistanceAndTime_ShouldReturnMinFareNegative()
        {
            double distance = 0.1;
            int time = 1;
            string type = "Normal";
            double fare = this.invoiceGenerator.CalculateFare(distance, time, type);
            double expected = 25;
            Assert.AreNotEqual(expected, fare);
        }

        /// <summary>
        /// get multiple rides fare
        /// </summary>
        [Test]
        public void GivenMultipleRides_ShouldReturnTotalFare()
        {
            string userId = "nitin";
            Rides firstRide = new Rides(2.0, 5, "Premium");
            Rides secondRide = new Rides(0.1, 1, "Normal");
            List<Rides> rides = new List<Rides> { firstRide, secondRide };
            UserAccount.AddRides(userId, rides);
            InvoiceSummary invoiceSummary = this.invoiceGenerator.GetInvoiceSummary(userId);
            double expected = 30;
            Assert.AreEqual(expected, invoiceSummary.TotalFare);
        }

        /// <summary>
        /// get multiple rides fare negative
        /// </summary>
        [Test]
        public void GivenMultipleRides_ShouldReturnTotalFareNegative()
        {
            string userId = "nitin";
            Rides firstRide = new Rides(2.0, 5, "Premium");
            Rides secondRide = new Rides(0.1, 1, "Normal");
            List<Rides> rides = new List<Rides> { firstRide, secondRide };
            UserAccount.AddRides(userId, rides);
            InvoiceSummary invoiceSummary = this.invoiceGenerator.GetInvoiceSummary(userId);
            double expected = 0;
            Assert.AreNotEqual(expected, invoiceSummary.TotalFare);
        }

        /// <summary>
        /// get fare based on user id
        /// </summary>
        [Test]
        public void GivenUSerId_ShouldReturnInvoiceSummary()
        {
            string userId = "nitin";
            Rides firstRide = new Rides(3.0, 5, "Premium");
            Rides secondRide = new Rides(1, 1, "Normal");
            List<Rides> rides = new List<Rides> { firstRide, secondRide };
            UserAccount.AddRides(userId, rides);
            InvoiceSummary invoiceSummary = this.invoiceGenerator.GetInvoiceSummary(userId);
            InvoiceSummary expected = new InvoiceSummary
            {
                TotalNumberOfRides = 2,
                TotalFare = 46,
                AverageFarePerRide = 23
            };
            object.Equals(expected, invoiceSummary);
        }

        /// <summary>
        /// get data based on ride type
        /// </summary>
        [Test]
        public void GivenPremiumRide_ShouldReturnInvoiceSummary()
        {
            string userId = "nitin";
            Rides firstRide = new Rides(3.0, 5, "Premium");
            Rides secondRide = new Rides(1, 1, "Normal");
            List<Rides> rides = new List<Rides> { firstRide, secondRide };
            UserAccount.AddRides(userId, rides);
            InvoiceSummary invoiceSummary = this.invoiceGenerator.GetInvoiceSummary(userId);
            InvoiceSummary expected = new InvoiceSummary
            {
                TotalNumberOfRides = 2,
                TotalFare = 106,
                AverageFarePerRide = 33
            };
            Assert.AreEqual(expected.TotalFare, invoiceSummary.TotalFare);
        }
    }    
}