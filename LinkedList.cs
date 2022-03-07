using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListUC1
{
    public class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = node;
            }

            Console.WriteLine("{0} inserted into linked list ", node.data);
        }


        public void Display()
        {
            Node tmp = this.head;

            if (tmp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (tmp != null)
            {
                Console.WriteLine(tmp.data + " ");
                tmp = tmp.Next;
            }
        }
    }
}