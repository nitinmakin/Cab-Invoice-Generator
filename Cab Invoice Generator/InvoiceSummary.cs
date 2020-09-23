namespace Cab_Invoice_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Invoice summary class
    /// </summary>
    public class InvoiceSummary
    {
        public int TotalNumberOfRides { get; set; }

        public double TotalFare { get; set; }

        public double AverageFarePerRide { get; set; }

        public void CalculateAvergaeFare()
        {
            this.AverageFarePerRide = this.TotalFare / this.TotalNumberOfRides;
        }
    }
}
