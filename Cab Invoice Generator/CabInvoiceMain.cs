namespace Cab_Invoice_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Main Class
    /// </summary>
    public class CabInvoiceMain
    {
        /// <summary>
        /// cost per km
        /// </summary>
      private double costPerKm = 10;

        /// <summary>
        /// cost per min
        /// </summary>
       private double costPerMin = 1;

        /// <summary>
        /// min fare
        /// </summary>
        private double minFare = 5;

        /// <summary>
        /// main method
        /// </summary>
        /// <param name="km">km parameter.</param>
        /// <param name="time">time parameter.</param>
        /// <returns>returns cost</returns>
        public double GetTotakFare(double km, double time)
        {
            double result = (km * this.costPerKm) + (time * this.costPerMin);
            if (result < this.minFare)
            {
                return this.minFare;
            }
            else
            {
                return result;
            }             
        }
    }
}
