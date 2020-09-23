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
        public double GetTotalFare(double km, double time)
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

        /// <summary>
        /// to calculate multiple rides
        /// </summary>
        /// <param name="rides">to take multiple rides</param>
        /// <returns>return result.</returns>
        public double GetTotxalFare(Ride[] rides)
        {
            double totalFare = 0;
         foreach (Ride item in rides)
            {
                totalFare += this.GetTotalFare(item.Distance, item.Time);
            }

            return totalFare;
        }
    }
}
