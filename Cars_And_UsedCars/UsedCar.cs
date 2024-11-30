using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_And_UsedCars
{
    internal class UsedCar:Car
    {
        public double Mileage { get; set; }

        public UsedCar()
        {

        }
        public UsedCar(string make, string model, int year, double price, double mileage) : base(make, model, year, price)
        {

        }
        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}, Mileage: {Mileage}";
        }

    }
}
