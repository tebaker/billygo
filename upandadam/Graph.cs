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
            foreach(string neighbor in neighborsArray)
            {
                this.NeighborsWeights.Add(new KeyValuePair<string, double>(neighbor, 0.0));
            }
        }

        public void Print()
        {
            Console.WriteLine(this.Name);
            foreach(KeyValuePair<string, double> kvp in NeighborsWeights)
            {
                Console.WriteLine("\t- " + kvp.Key + ": " + kvp.Value);
            }
        }
    }

    class Graph
    {
        public IDictionary<string, Node> Connections { get; private set; }

        public Graph()
        {
            this.Connections = new Dictionary<string, Node>();
        }

        public void AddNewNode(Node newNode)
        {
            // If graph alreacy contains key, update; if not, add
            if (this.Connections.ContainsKey(newNode.Name))
            {
                this.Connections[newNode.Name] = newNode;
            }
            else
            {
                this.Connections.Add(new KeyValuePair<string, Node>(newNode.Name, newNode));
            }
        }

        public double CalcEdgeCost(Node node1, Node node2)
        {
            return Math.Sqrt(Math.Pow((node1.X - node2.X), 2) + Math.Pow((node1.Y - node2.Y), 2));
        }

        public void Print()
        {
            foreach(KeyValuePair<string, Node> kvp in this.Connections)
            {
                kvp.Value.Print();
            }
        }
    }
}
