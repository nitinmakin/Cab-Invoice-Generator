namespace Cab_Invoice_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Ride
    {
        /// <summary>
        /// variable for distance
        /// </summary>
        public double Distance;

        /// <summary>
        /// variable for time
        /// </summary>
        public double Time;

        /// <summary>
        /// constructor for multiple rides
        /// </summary>
        /// <param name="distance">distance in double.</param>
        /// <param name="time">time in double.</param>

        public Ride(double distance, double time)
        {
            this.Distance = distance;
            this.Time = time;
        }
    }
}
