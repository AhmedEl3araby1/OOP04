using System;
namespace OOP_01
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string destinationCountry;
        private decimal customsFee;

        #region Properties
        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }
        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }
        #endregion

        #region CTOR
        public InternationalShipment(string code, string desc, decimal weight, decimal fee, DeliveryAddress address, string country, decimal customsFee) : base(code, desc, weight, fee, address)
        {
            DestinationCountry = country;
            CustomsFee = customsFee;
        }
        #endregion

        #region GetInternationalCost
        public decimal GetInternationalCost()
        {
            return DeliveryFee + (Weight * 5) + CustomsFee;
        }
        #endregion

        #region EstimatedCost Override
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }
        #endregion

        #region ShipmentType Override
        public override string ShipmentType
        {
            get { return "International Shipment"; }
        }
        #endregion

        #region PrintInternationalShipment
        public void PrintInternationalShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code        : {TrackingCode}");
            Console.WriteLine($"Destination Country  : {DestinationCountry}");
            Console.WriteLine($"Estimated Cost       : {EstimatedCost} EGP");
        }
        #endregion

        #region PrintShipment Override
        public override void PrintShipment()
        {
            PrintInternationalShipment();
        }
        #endregion

        #region GenerateCustomsReport
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report for {TrackingCode}: standard customs clearance report for {DestinationCountry}, Customs Fee: {CustomsFee} EGP.");
        }
        #endregion

        #region ITrackable Implementation
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }
        #endregion

        #region IInsurable Implementation
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
        #endregion
    }
}