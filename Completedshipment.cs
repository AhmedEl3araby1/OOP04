using System;
namespace OOP_01
{
    public sealed class CompletedShipment : Shipment
    {
        #region CTOR
        public CompletedShipment(string code, string desc, decimal weight, decimal fee, DeliveryAddress address)
            : base(code, desc, weight, fee, address)
        {
        }
        #endregion

        #region EstimatedCost Override
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }
        #endregion

        #region ShipmentType Override
        public override string ShipmentType
        {
            get { return "Completed Shipment"; }
        }
        #endregion

        #region PrintShipment Override
        public override void PrintShipment()
        {
            Console.WriteLine("Completed Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Weight : {Weight} KG");
            Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
            Console.WriteLine($"Destination : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
        #endregion
    }
}