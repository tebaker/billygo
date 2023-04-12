using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
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
            // If edge cost has been set, return
            if (node1.NeighborsWeights[node2.Name] == Double.NaN)
            {
                // Calculating -- setting both directions to cost
                double holdCost = Math.Sqrt(Math.Pow((node1.X - node2.X), 2) + Math.Pow((node1.Y - node2.Y), 2));
                node1.NeighborsWeights[node2.Name] = holdCost;
                node2.NeighborsWeights[node1.Name] = holdCost;
            }

            // Returning calculated edge cost
            return node1.NeighborsWeights[node2.Name];
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
