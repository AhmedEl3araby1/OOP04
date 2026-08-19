using System;
namespace OOP_01
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        #region CTOR
        public StandardShipment(string code, string desc, decimal weight, decimal fee, DeliveryAddress address) : base(code, desc, weight, fee, address)
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

        #region PrintStandardShipment
        public void PrintStandardShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
        #endregion

        #region PrintShipment Override
        public override void PrintShipment()
        {
            PrintStandardShipment();
        }
        #endregion

        #region ITrackable Implementation
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }
        #endregion

        #region IInsurable Implementation
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
        #endregion
    }
}