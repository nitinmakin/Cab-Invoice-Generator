//-----------------------------------------------------------------------
// <copyright file="CabInvoiceMain.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Cab_Invoice_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// main class
    /// </summary>
    public class CabInvoiceMain
    {
        /// <summary>
        /// method to calculate total fare
        /// </summary>
        /// <param name="distance">total distance.</param>
        /// <param name="time">total time.</param>
        /// <param name="type">total type.</param>
        /// <returns>return total fare</returns>
        public double CalculateFare(double distance, int time, string type)
        {
            RideType rideType = new RideType(type);
            double totalFare = (distance * rideType.MINIMUMCOSTPERKILOMETER) + (time * rideType.COSTPERTIME);
            if (totalFare < rideType.MINIMUMFARE)
            {
                return rideType.MINIMUMFARE;
            }

            return totalFare;
        }

        /// <summary>
        /// get invoice summery
        /// </summary>
        /// <param name="userId">user id.</param>
        /// <returns>return invoice summary.</returns>
        public InvoiceSummary GetInvoiceSummary(string userId)
        {
            InvoiceSummary invoiceSummary = new InvoiceSummary();           
            double totalFare = 0;
            int numberOfRides = 0;
           
            if (UserAccount.ACCOUNTS1.ContainsKey(userId))
            {
                foreach (Rides ride in UserAccount.ACCOUNTS1[userId])
                {
                    totalFare += this.CalculateFare(ride.DISTANCE1, ride.TIME1, ride.RIDETYPE1);
                    numberOfRides++;
                }
            }

            invoiceSummary.TotalNumberOfRides = numberOfRides;
            invoiceSummary.TotalFare = totalFare;
            invoiceSummary.CalculateAvergaeFare();
            return invoiceSummary;
        }
    }
}
