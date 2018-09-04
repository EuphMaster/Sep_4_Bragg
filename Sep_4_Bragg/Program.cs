using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep_4_Bragg
{
    enum Color { Black, Blue, Red, NeonGreen};
    enum VehicleType { Car, Truck, Motorcycle };

    struct Vehicle
    {
        public VehicleType type;
        public Color color;

        public string make;
        public string model;
        public int year;
    }


    class Program
    {
        static void Main(string[] args)
        {
            var porsche924s =
                new Vehicle
                {
                    type = VehicleType.Car,                            
                    color = Color.Red,
                    make = "Porsche",                           
                    model = "924s",                           
                    year = 1987};

            Console.WriteLine(MyFirstVehicleMessage(porsche924s));
        }

        private static string MyFirstVehicleMessage(Vehicle firstVehicle)
        {
            var msg = $"My first vehicle was a {firstVehicle.type}, specifically a " +
                $"{ firstVehicle.color} { firstVehicle.year} " +
                $"{firstVehicle.make} {firstVehicle.model}.";

            return msg;
            
        }

    }
}
