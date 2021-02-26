﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;
        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public void Add(Car car)
        {
            if (data.Count <= Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car car = data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);

            if (car == null)
            {
                return false;
            }

            data.Remove(car);

            return true;
        }

        public Car GetLatestCar()
        {
            Car car = data.OrderByDescending(c => c.Year).FirstOrDefault();

            if (car == null)
            {
                return null;
            }

            return car;
        }

        public Car GetCar(string manufacturer, string model)
        {
            Car car = data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);

            if (car == null)
            {
                return null;
            }
            return car;
        }

        public string GetStatistics()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {this.Type}:");

            foreach (var car in data)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
