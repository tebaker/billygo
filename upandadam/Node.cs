using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Node
    {
        public string Name { get; private set; }

        public double X { get; private set; }
        public double Y { get; private set; }

        public IDictionary<string, double> NeighborsWeights { get; private set; }

        public Node()
        {
            this.Name = string.Empty;
            this.X = Double.NaN;
            this.Y = Double.NaN;

            this.NeighborsWeights = new Dictionary<string, double>();
        }

        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetX(double x)
        {
            this.X = x;
        }
        public void SetY(double y)
        {
            this.Y = y;
        }
        public void SetNeighbors(string[] neighborsArray)
        {
            foreach (string neighbor in neighborsArray)
            {
                this.NeighborsWeights.Add(new KeyValuePair<string, double>(neighbor, Double.NaN));
            }
        }

        public void Print()
        {
            Console.WriteLine(this.Name);
            foreach (KeyValuePair<string, double> kvp in NeighborsWeights)
            {
                Console.WriteLine("\t- " + kvp.Key + ": " + kvp.Value);
            }
        }
    }
}
