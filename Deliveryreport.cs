using System;
namespace OOP_01
{
    public class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public void PrintInsurance(IInsurable shipment)
        {
            string type = (shipment is Shipment s) ? s.ShipmentType : "Shipment";
            Console.WriteLine($"{type} Insurance : {shipment.CalculateInsurance():0.00} EGP");
        }
    }
}