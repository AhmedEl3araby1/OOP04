using System;
namespace OOP_01
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal extraFee;

        #region Properties
        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }
        #endregion

        #region CTOR
        public ExpressShipment(string code, string desc, decimal weight, decimal fee, DeliveryAddress address, decimal extraFee) : base(code, desc, weight, fee, address)
        {
            ExtraFee = extraFee;
        }
        #endregion

        #region GetExpressCost
        public decimal GetExpressCost()
        {
            return DeliveryFee + (Weight * 5) + ExtraFee;
        }
        #endregion

        #region EstimatedCost Override
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }
        #endregion

        #region ShipmentType Override
        public override string ShipmentType
        {
            get { return "Express Shipment"; }
        }
        #endregion

        #region PrintExpressShipment
        public void PrintExpressShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
        #endregion

        #region PrintShipment Override
        public override void PrintShipment()
        {
            PrintExpressShipment();
        }
        #endregion

        #region ITrackable Implementation
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }
        #endregion

        #region IInsurable Implementation
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
        #endregion
    }
}