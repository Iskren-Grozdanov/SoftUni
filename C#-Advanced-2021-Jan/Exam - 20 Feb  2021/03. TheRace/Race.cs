using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name,int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Racer>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public void Add(Racer Racer)
        {
            if (data.Count < Capacity)
            {
                data.Add(Racer);
            }

        }
        public bool Remove(string name)
        {
            Racer racer = data.FirstOrDefault(p => p.Name == name);
            if (racer == null)
            {
                return false;
            }
            data.Remove(racer);
            return true;
        }
        public Racer GetOldestRacer()
        {
            return data.OrderByDescending(p => p.Age).FirstOrDefault();
        }
        public Racer GetRacer(string name)
        {
            Racer racer = data.FirstOrDefault(p => p.Name == name);
            return racer;
        }
        public Racer GetFastestRacer()
        {
            Racer racer = data.OrderByDescending(p => p.Car.Speed).FirstOrDefault();
            return racer;
        }
        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Racers working at {Name}:");
            foreach (var racer in data)
            {
                result.AppendLine($"Racer: {racer.Name}, {racer.Age} ({racer.Country})");
            }

            return result.ToString();
        }

    }
}
