//-----------------------------------------------------------------------
// <copyright file="Rides.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Cab_Invoice_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class for getting rides
    /// </summary>
    public class Rides
    { 
        /// <summary>
        /// distance variable
        /// </summary>        
        private double distance;

        /// <summary>
        /// time variable
        /// </summary>  
        private int time;

        /// <summary>
        /// ride type
        /// </summary>
        private string rideType;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rides" /> class.
        /// </summary>
        /// <param name="inputDistance">input distance.</param>
        /// <param name="inputTime">input time </param>
        /// <param name="inputRideType">ride type</param>
        public Rides(double inputDistance, int inputTime, string inputRideType)
            {
                this.DISTANCE1 = inputDistance;
                this.TIME1 = inputTime;
                this.RIDETYPE1 = inputRideType;
            }

        /// <summary>
        /// Gets or sets distance
        /// </summary>
        public double DISTANCE1 { get => this.distance; set => this.distance = value; }

        /// <summary>
        ///  Gets or sets time
        /// </summary>
        public int TIME1 { get => this.time; set => this.time = value; }

        /// <summary>
        ///  Gets or sets ride type
        /// </summary>
        public string RIDETYPE1 { get => this.rideType; set => this.rideType = value; }
    }
}
