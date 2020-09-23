//-----------------------------------------------------------------------
// <copyright file="InvoiceSummary.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
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
        /// <summary>
        /// Gets or sets rides
        /// </summary>
        public int TotalNumberOfRides { get; set; }

        /// <summary>
        /// Gets or sets  fare
        /// </summary>
        public double TotalFare { get; set; }

        /// <summary>
        /// Gets or sets  average fare
        /// </summary>
        public double AverageFarePerRide { get; set; }

        /// <summary>
        /// method to calculate average fare
        /// </summary>
        public void CalculateAvergaeFare()
        {
            this.AverageFarePerRide = this.TotalFare / this.TotalNumberOfRides;
        }
    }
}
