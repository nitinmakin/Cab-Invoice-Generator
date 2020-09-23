//-----------------------------------------------------------------------
// <copyright file="UserAccount.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Cab_Invoice_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// user account class
    /// </summary>
    public class UserAccount
    {
        /// <summary>
        /// creating object of dictionary
        /// </summary>
        private static Dictionary<string, List<Rides>> listOfAccounts = new Dictionary<string, List<Rides>>();

        /// <summary>
        ///  Gets or sets accounts
        /// </summary>
        public static Dictionary<string, List<Rides>> ACCOUNTS1 { get => listOfAccounts; set => listOfAccounts = value; }

        /// <summary>
        /// for adding rides
        /// </summary>
        /// <param name="key">set key</param>
        /// <param name="inputRides">input of rides</param>
        public static void AddRides(string key, List<Rides> inputRides)
        {
            if (ACCOUNTS1.ContainsKey(key))
            {
                foreach (Rides ride in inputRides)
                {
                    ACCOUNTS1[key].Add(ride);
                }
            }
            else
            {
                ACCOUNTS1.Add(key, inputRides);
            }
        }
    }
}
