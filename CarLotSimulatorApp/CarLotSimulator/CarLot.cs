using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public static class CarLot
    {

        private static List<Car> CarList = new List<Car>();

        static int numberOfCars = 0;


        public static void AddCar(Car car)
        {
            CarList.Add(car);
            numberOfCars++;
            Console.WriteLine($"\nCurrent Number of Cars: {numberOfCars}");
        }

        public static void RemoveCar(Car car)
        {
            CarList.Remove(car);
            numberOfCars--;
        }

        public static void PrintLotData()
        {
            Console.WriteLine($"\nCars available: \n");
            foreach (var car in CarLot.CarList)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make}  Model: {car.Model}\n");
            }
        }



}
}
