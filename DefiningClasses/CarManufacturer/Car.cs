﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        public string Make {  get; set; }

        public string Model {  get; set; }

        public int Year { get; set; }

        public double FuelQuantity {  get; set; }

        public double FuelConsumption { get; set; }
        public Engine Engine {  get; set; }
        public Tire[] Tire { get; set; }


        public void Drive(double distance)
        {
            if (this.FuelQuantity - distance * this.FuelConsumption > 0)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make:{this.Make}\n" +
                $"Model:{this.Model}\n" +
                $"Year:{this.Year}\n" +
                $"Fuel:{this.FuelQuantity:f2}";

        }
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
   
        }
        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity,
            double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string everything) : this()
        {
            string[] data = everything.Split("").ToArray();
            this.Make = data[0];
            this.Model = data[1];
            this.Year = int.Parse(data[2]);
            this.FuelQuantity = double.Parse(data[3]);
            this.FuelConsumption = double.Parse(data[4]);
        }
        public Car(string make, string model, int year, double fuelQuantity,
            double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tire = tires;
        }

    }


    

   
}
