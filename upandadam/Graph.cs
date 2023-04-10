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

        public string[] Neighbors { get; private set; }

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
            this.Neighbors = new string[neighborsArray.Length];
            this.Neighbors = neighborsArray;
        }
        public void Print()
        {
            Console.WriteLine(this.Name);
            foreach(string neighbor in Neighbors)
            {
                Console.WriteLine("\t- " + neighbor);
            }
        }
    }


    class Graph
    {
        IDictionary<string, Node> Connections;

        public Graph()
        {
            this.Connections = new Dictionary<string, Node>();
        }

        public void AddNewNode(Node newNode)
        {
            this.Connections.Add(new KeyValuePair<string, Node>(newNode.Name, newNode));
        }

        public double CalcDistFrom(Node node1, Node node2)
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
