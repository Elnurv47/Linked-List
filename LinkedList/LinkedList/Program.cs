using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int value)
        {
            this.data = value;
            next = null;
        }
    }
    class LinkedList
    {
        private int size = 0;
        public int Size
        {
            get { return size; }
            private set { size = value; }
        }

        public Node head;
        public Node tail;
        public LinkedList()
        {
            head = tail = null;
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
                head = tail = newNode;
            else
            {
                newNode.next = head;
                head = newNode;
            }
            Size++;
            Console.WriteLine("The node {0} is inserted at the beginning of the Linked List \n", data);
        }
        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
                head = tail = newNode;
            else
            {
                tail.next = newNode;
                tail = newNode;
                tail.next = null;
            }
            Size++;
            Console.WriteLine("The node {0} is inserted at the end of the Linked List \n", data);
        }
        public void AddMiddle(int data, int position)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                Node tempNode = head;
                int index = 1;
                // Traverse through till the reaching the index we search for
                while (index < position)
                {
                    tempNode = tempNode.next;
                    index++;
                }
                Node nextNode = tempNode.next;
                tempNode.next = newNode;
                newNode.next = nextNode;
            }
            Size++;
            Console.WriteLine("The node {0} is inserted at the middle of the Linked List \n", data);
        }
        public void RemoveFirst()
        {
            // If the linked list is empty, we don't continue
            if (head == null)
            {
                Console.WriteLine("The Linked List is empty \n");
                return;
            }
            else
            {
                // If head == tail, in other words there is only 1 element in the Linked List
                // We set both of them to null;
                if (head == tail)
                    head = tail = null;
                else
                    head = head.next;
            }
            Size--;
            Console.WriteLine("The first node is removed successfully \n");
        }
        public void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("The Linked List is empty \n");
                return;
            }
            else
            {
                if (head == tail)
                    head = tail = null;
                else
                {
                    Node tempNode = head;
                    while (tempNode.next != tail)
                    {
                        tempNode = tempNode.next;
                    }
                    // tempNode -> the node which is before the tail node
                    tempNode.next = null;
                    tail = tempNode;
                }
            }
            Size--;
            Console.WriteLine("The last node is removed successfully \n");
        }
        public void RemoveMiddle(int position)
        {
            if (head == null)
            {
                Console.WriteLine("The Linked List is empty \n");
                return;
            }
            else
            {
                if (head == tail)
                    head = tail = null;
                else
                {
                    int index = 1;
                    Node tempNode = head;
                    
                    // Traversing through the Linked List
                    while (index < position)
                    {
                        tempNode = tempNode.next;
                        index++;
                    }
                    Node tempNodeNext = tempNode.next;
                    tempNode.next = tempNodeNext.next;
                }
            }
            Size--;
            Console.WriteLine("The node is removed successfully \n");
        }
        public void RemoveEntireLinkedList()
        {
            if (head == null)
            {
                Console.WriteLine("The Linked List is empty \n");
                return;
            }
            else
            {
                head = tail = null;
            }
            Size = 0;
            Console.WriteLine("Linked List is deleted entirely \n");
        }
        public void PrintLinkedList()
        {
            if (head == null)
            {
                Console.WriteLine("There is no element to print");
                return;
            }
            else
            {
                Node currentNode = head;
                // Traversing through the Linked List
                while (currentNode != null)
                {
                    Console.Write(currentNode.data + " ");
                    currentNode = currentNode.next;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Linked List
            LinkedList llist = new LinkedList();
            // Adding Some Nodes at the Beginning
            llist.AddFirst(2);
            llist.AddFirst(5);
            // Adding Some Nodes at the End
            llist.AddLast(10);
            llist.AddLast(20);
            // Adding Some Nodes at the Middle
            llist.AddMiddle(30, 2);
            llist.AddMiddle(40, 3);
            // Printing the Linked List
            llist.PrintLinkedList();
        }
    }
}
