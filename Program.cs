﻿using System;

namespace LinkedListUC4
{
    class rogram
    {
        static void Main(string[] args)
        {
            //int Choice,data,p;

            Console.WriteLine("Welcome to Linked List operation");
            LinkedList list = new LinkedList();

            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();

            list.InsertAtParticularPosition(1, 30);
        }
    }
}
