using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_And_UsedCars
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public static List<Car> Cars = new List<Car>();

        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }
        public Car(string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price:c}";
        }
        public static void ListCars()
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"Make: {Cars[i].Make}, Model: {Cars[i].Model}, Year: {Cars[i].Year}, Price: {Cars[i].Price:c}, Index: {i}");
            }
        }
        public static void RemoveCar(int carIndex)
        {
            Cars.RemoveAt(carIndex);
        }
    } 
}
