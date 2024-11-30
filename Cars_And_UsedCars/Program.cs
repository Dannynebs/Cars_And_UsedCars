// See https://aka.ms/new-console-template for more information
using Cars_And_UsedCars;
using System.Xml;

Console.WriteLine("Hello, World!");

Car car1 = new Car("Chevy", "Corvette", 2022, 120000);
Car car2 = new Car("Lamborghini", "Diablo", 2020, 200000);
Car car3 = new Car("Ford","Mustang", 2024, 110000);
UsedCar usedCar1 = new UsedCar("Honda", "Civic", 2010, 25000, 86000);
UsedCar usedCar2 = new UsedCar("Chevy","Impala",2009, 20000, 90000);
UsedCar usedCar3 = new UsedCar("Toyota","Accord",2005,15000,130000);

Car.Cars.Add(car1);
Car.Cars.Add(car2);
Car.Cars.Add(car3);
Car.Cars.Add(usedCar1);
Car.Cars.Add(usedCar2);
Car.Cars.Add(usedCar3);



Console.WriteLine("Here is a list of cars to choose from:");
Car.ListCars();
Console.WriteLine("Which car would you like to buy? Please enter the index of the car as shown above.");

int userChoice = int.Parse(Console.ReadLine());

switch (userChoice)
{
    case 0:
        Console.WriteLine(car1.ToString());
        Car.RemoveCar(userChoice);
        break;
    case 1:
        Console.WriteLine(car2.ToString());
        Car.RemoveCar(userChoice);
        break;
    case 2:
        Console.WriteLine(car3.ToString());
        Car.RemoveCar(userChoice);
        break;
    case 3:
        Console.WriteLine(usedCar1.ToString());
        Car.RemoveCar(userChoice);
        break;
    case 4:
        Console.WriteLine(usedCar2.ToString());
        Car.RemoveCar(userChoice);
        break;
    case 5:
        Console.WriteLine(usedCar3.ToString());
        Car.RemoveCar(userChoice);
        break;
}

Console.WriteLine("Remaining list of cars:");
Console.WriteLine("\n");
Car.ListCars();


