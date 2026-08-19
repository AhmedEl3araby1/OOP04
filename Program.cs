using OOP_01;
using System;

namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1  Abstraction
            // a) Hiding complex internal details and showing only the essentials the user needs.
            // b) It simplifies code, separates usage from implementation, and gives flexibility to change internals without affecting the rest of the program.
            #endregion
            #region Q2  Abstract Classes vs. Interfaces
            /*
            a) Difference:
            Abstract Class: has both implemented and abstract methods, can have state
            Interface: defines only required methods, usually no state
            
            b) When a class needs to follow more than one behavior, or there's no shared code to reuse.
             
             c) Multiple inheritance:
              Abstract Class: no, only one
             Interface: yes, multiple
             
             */
            #endregion

            #region Delivery Center Setup

            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            DeliveryCenter center = new DeliveryCenter();
            DeliveryReport report = new DeliveryReport();

            #endregion

            #region a. Create one StandardShipment
            DeliveryAddress standardAddress = new DeliveryAddress("Cairo", "Tahrir St", 10);
            StandardShipment standardShipment = new StandardShipment("SH001", "Laptop", 3, 80, standardAddress);
            #endregion

            #region b. Create one ExpressShipment
            DeliveryAddress expressAddress = new DeliveryAddress("Giza", "Pyramids Rd", 5);
            ExpressShipment expressShipment = new ExpressShipment("SH002", "Mobile Phone", 2, 60, expressAddress, 30);
            #endregion

            #region c. Create one InternationalShipment
            DeliveryAddress internationalAddress = new DeliveryAddress("Berlin", "Alexanderplatz", 1);
            InternationalShipment internationalShipment = new InternationalShipment("SH003", "Television", 8, 120, internationalAddress, "Germany", 100);
            #endregion

            #region d. Add all shipments to the DeliveryCenter
            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);
            #endregion

            #region e. Print all shipment details
            center.PrintAllShipments();
            #endregion

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Tracking Status");
            Console.WriteLine();

            #region f. Print the tracking status of every shipment
            center.PrintTrackingStatuses();
            #endregion

            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Insurance");
            Console.WriteLine();

            #region g. Print the insurance cost of every shipment
            report.PrintInsurance(standardShipment);
            Console.WriteLine();
            report.PrintInsurance(expressShipment);
            Console.WriteLine();
            report.PrintInsurance(internationalShipment);
            Console.WriteLine();
            #endregion

            Console.WriteLine("==========================================");
            Console.WriteLine();

            #region h. Store the shipment objects in an ITrackable[] array and print their tracking statuses
            ITrackable[] trackables = { standardShipment, expressShipment, internationalShipment };
            foreach (ITrackable t in trackables)
            {
                report.PrintShipment(t);
            }
            Console.WriteLine();
            #endregion

            #region i. Store the shipment objects in an IInsurable[] array and print their insurance values
            IInsurable[] insurables = { standardShipment, expressShipment, internationalShipment };
            foreach (IInsurable ins in insurables)
            {
                report.PrintInsurance(ins);
            }
            #endregion

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
        }
    }
}