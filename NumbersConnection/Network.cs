using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersConnection
{
    public class Network
    {
        private int[] elements;
        private List<int>[] connections;

        public Network(int numberOfElements)
        {
            elements = new int[numberOfElements + 1];
            connections = new List<int>[numberOfElements + 1];

            for (int i = 0; i <= numberOfElements; i++)
            {
                elements[i] = i;
                connections[i] = new List<int> { i };
            }
        }

        public void Connect(int element1, int element2)
        {
            if (AreConnected(element1, element2)) 
            {
                return;
            }

            List<int> connections1 = connections[element1];
            List<int> connections2 = connections[element2];

            if (connections1.Count < connections2.Count)
            {
                foreach (int element in connections1)
                {
                    elements[element] = element2;
                    connections2.Add(element);
                }
                connections[element1] = connections2;
            }
            else
            {
                foreach (int element in connections2)
                {
                    elements[element] = element1;
                    connections1.Add(element);
                }
                connections[element2] = connections1;
            }
        }

        public bool Query(int element1, int element2)
        {
            return AreConnected(element1, element2);
        }

        private bool AreConnected(int element1, int element2)
        {
            return FindRoot(element1) == FindRoot(element2);
        }

        private int FindRoot(int element)
        {
            for (; element != elements[element]; element = elements[element])
            {
                elements[element] = elements[elements[element]];
            }
            return element;
        }
    }
}
