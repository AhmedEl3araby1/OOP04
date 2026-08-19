using System;
namespace OOP_01
{
    public class Driver
    {
        #region Properties
        public string DriverId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        #endregion

        #region CTOR
        public Driver(string driverId, string fullName, string phoneNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
        #endregion
    }
}