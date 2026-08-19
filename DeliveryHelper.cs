using System;
namespace OOP_01
{
    public static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            Console.WriteLine($"{shipment.ShipmentType} Printed Successfully.");
        }
    }
}