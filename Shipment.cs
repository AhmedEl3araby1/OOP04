using System;
namespace OOP_01
{
    public abstract class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        private DeliveryAddress destination;


        #region Properties
        public string TrackingCode
        {
            get { return trackingCode; }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }
        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }
        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }
        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public abstract decimal EstimatedCost { get; }
        public virtual string ShipmentType
        {
            get { return "Shipment"; }
        }
        #endregion

        #region 1st CTOR
        protected Shipment(string code)
        {
            trackingCode = code;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }
        #endregion

        #region 2nd CTOR
        protected Shipment(
            string code,
            string desc,
            decimal w,
            decimal fee,
            DeliveryAddress address)
        {
            trackingCode = code;
            Description = desc;
            Weight = w;
            DeliveryFee = fee;
            Destination = address;
        }
        #endregion

        #region UpdateDeliveryFee
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }
        #endregion

        #region UpdateWeight
        public void UpdateWeight(decimal newWeight)
        {
            Weight = newWeight;
        }
        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            Weight = newWeight + extraPackingWeight;
        }
        #endregion

        #region PrintShipment
        public abstract void PrintShipment();
        #endregion
    }
}