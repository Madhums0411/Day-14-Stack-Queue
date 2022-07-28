using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    public class Queue
    {
        //Use linkedlist to perform operations
        LinkedLists linkedList;

        public Queue()
        {
            linkedList = new LinkedLists();
        }

        public void Enqueue(int value)
        {
            //Adding node in  queue
            linkedList.AppendNode(value);
        }

        public void DisplayQueue()
        {
            //Display the nodes in queue
            Console.WriteLine("Queue:");
            linkedList.Display();
        }

        public Node Top()
        {
            //Display the topmost node in queue
            return linkedList.Head;
        }
        public void Dequeue()
        {
            //Delete the node from queue
            linkedList.DeleteNodeAtFirst();
        }
    }
}
