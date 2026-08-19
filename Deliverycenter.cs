using System;
namespace OOP_01
{
    public class DeliveryCenter
    {
        private Shipment[] shipments;
        public string CenterName { get; set; }
        public Driver Driver { get; set; }
        public DeliveryCenter()
        {
            shipments = new Shipment[20];
        }

        #region Integer Indexer
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }
        #endregion

        #region String Indexer
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                        return shipments[i];
                }
                return null;
            }
        }
        #endregion

        #region AddShipment
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region RemoveShipment
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region PrintAllShipments
        public void PrintAllShipments()
        {
            bool isFirst = true;
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    if (!isFirst)
                    {
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine();
                    }
                    isFirst = false;
                    shipments[i].PrintShipment();
                }
            }
        }
        #endregion

        #region PrintTrackingStatuses
        public void PrintTrackingStatuses()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] is ITrackable trackable)
                {
                    Console.WriteLine(trackable.GetTrackingStatus());
                    Console.WriteLine();
                }
            }
        }
        #endregion

    }
}