using System;
namespace OOP_01
{
    public struct DeliveryAddress
    {
        #region Properties
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        #endregion

        #region CTOR
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        #endregion

        #region GetFullAddress
        public string GetFullAddress()
        {
            return $"{BuildingNumber} {Street}, {City}";
        }
        #endregion
    }
}