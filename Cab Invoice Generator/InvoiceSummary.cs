namespace Cab_Invoice_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class InvoiceSummary
    {
        public double NoOfRides;
        public double Fare;
        public double Avg;

        public InvoiceSummary(double NoOfRides, double Fare)
        {
            this.NoOfRides = NoOfRides;
            this.Fare = Fare;
            this.Avg = Fare/NoOfRides;
        }

        /// <summary>
        /// equals method to check objects
        /// </summary>
        /// <param name="obj">object parameter.</param>
        /// <returns>returns boolean true</returns>
        public override bool Equals(object obj)
        {
            return obj is InvoiceSummary summary &&
                   NoOfRides == summary.NoOfRides &&
                   Fare == summary.Fare &&
                   Avg == summary.Avg;
        }
    }
}
