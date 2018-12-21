using System;

namespace _06VehicleCatalogue
{
    public class Vehicles
    {
        public Vehicles(string typeOfVehicle, string model, string color, string horsePower)
        {
            TypeOfVehicle = typeOfVehicle;
            Model = model;
            Color = color;
            HorsePowers = horsePower;
        }

        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string HorsePowers { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                

                var splittedInput = Console.ReadLine().Split();

                string typeOfVehicle = splittedInput[0];
                string model = splittedInput[1];
                string color = splittedInput[2];
                string horsePowers = splittedInput[3];

                var vehicle = new Vehicles(typeOfVehicle, model, color, horsePowers);

                if (input == "End")
                {
                    string modelsToPrint = Console.ReadLine();
                }

                string command = Console.ReadLine();

                if (command == "Close the Catalogue")
                {

                }
            }
        }
    }
}
