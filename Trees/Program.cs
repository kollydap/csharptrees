using System;
using System.Collections.Generic;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BSTrees bSTrees1 = new BSTrees(70);
            PreOrderTraverseBST(bSTrees1);
            List<int> arr = new List<int>(){
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };
            populateTree(bSTrees1,arr);
            //LinkedList linkedList = new LinkedList();
            //AddNewNodeTOFirst(linkedList, 56);
            //AddNewNodeTOLast(linkedList, 56);
            //AddNewNodeTOLast(linkedList, 56);



            isFound(bSTrees1, 6);
            //traverseLinkedList(linkedList);
            
        }
        public static void populateTree(BSTrees bSTrees,List<int> values)
        {
            foreach (int item in values)
            {
                AddNewNode(item,bSTrees);
            }
            PreOrderTraverseBST(bSTrees);
        }
        public static void isFound(BSTrees bSTrees, int value)
        {
            if(bSTrees == null)
            {
                Console.WriteLine("this BsTree is null");
            }
            else
            {
                if(bSTrees.Value == value)
                {
                    Console.WriteLine("Found");
                    return;
                }
                else if(bSTrees.Value > value)
                {
                    isFound(bSTrees.LeftChild, value);
                }
                else if(bSTrees.Value < value)
                {
                    isFound(bSTrees.RightChild, value);
                }
                else
                {
                    Console.WriteLine(" Not Found");
                    return;
                }
            }
        }
        public static void traverseLinkedList(LinkedList linkedList)
        {
            Node node = linkedList.Head;
            while (node !=  null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

        }
        public static void AddNewNodeTOFirst(LinkedList linkedList,int data)
        {
            Node newNode = new Node(data);
            newNode.Next = linkedList.Head;
            linkedList.Head = newNode;

        }
        public static void AddNewNodeTOLast(LinkedList linkedList, int data)
        {
            Node newNode = new Node(data);
            newNode.Next = null;
            linkedList.Tail.Next = newNode;
            linkedList.Tail = newNode;

        }
        public static void PreOrderTraverseBST(BSTrees bSTrees)
        {
            if(bSTrees is null)
            {
                return;
            }
            Console.WriteLine(bSTrees.Value);
            PreOrderTraverseBST(bSTrees.LeftChild);
            PreOrderTraverseBST(bSTrees.RightChild);


        }
        public static void AddNewNode(int value, BSTrees bSTrees)
        {
            BSTrees newChild = new BSTrees(value);
            if (bSTrees.Value > value)
            {
                if (bSTrees.LeftChild is null)
                {
                    bSTrees.LeftChild = newChild;
                }
                else
                {
                    AddNewNode(value, bSTrees.LeftChild);
                }
            }
            else
            {
                if (bSTrees.RightChild is null)
                {
                    bSTrees.RightChild = newChild;
                }
                else
                {
                    AddNewNode(value, bSTrees.RightChild);
                }
            }

        }
    }

    class BSTrees
    {
        public BSTrees(int value)
        {
            this.Value = value;
        }
       
        public int Value;
        public BSTrees LeftChild;
        public BSTrees RightChild;

    }
    class Node
    {
        public Node(int value)
        {
            this.Value = value;
        }
        public Node Next;
        public int Value;
    }
    class LinkedList
    {
        public Node Tail;
        public Node Head;
    }
}
