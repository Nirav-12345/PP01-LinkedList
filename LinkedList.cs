using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUC6
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

        


        internal void pop()
        {
            if (this.head == null)
            {
                Console.WriteLine("Deletion is not possible");
            }

            Console.WriteLine("Vlaue popped" + this.head.data);
            this.head = this.head.Next;
        }


        internal Node popmethod()
        {
            if (head==null)
            {
                return null;
            }

            if (head.Next==null)
            {
                return null;
            }

            Node newNode = head;
            while(newNode.Next.Next !=null)
            {
                newNode = newNode.Next;
            }

            newNode.Next = null;

            return head;


           
        }


    }








    }







    
