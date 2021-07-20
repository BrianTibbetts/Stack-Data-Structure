/**
 * SinglyLinkedList
 * A singly linked list is collection of nodes ordered head to tail.
 * 
 * Unlike arrays, singly linked lists have no fixed capacity limit set when the object is created.
 * The memory used by a singly linked list is proportional to the number of elements in the list.
 */
using System;

namespace StackDataStructure
{
    public class SinglyLinkedList<T>
    {
        /** Node class - Defines the nodes which populate the singly linked list
         * In a singly linked list, each node consists of an element of the list and a reference to the next node.
         */
        private class Node
        {
            private T element;          // reference to the element stored at this node
            private Node next;          // reference to the next node in the list
            public Node(T t, Node n)
            {
                element = t;
                next = n;
            }
            public T GetElement() { return element; }
            public Node GetNext() { return next; }
            public void SetNext(Node n) { next = n; }
        }

        private Node head = null;       // head node of the list (or null if empty)
        private Node tail = null;       // last node of the list (or null if empty)
        private int size = 0;           // number of nodes in the list
        public SinglyLinkedList() { }   // Constructor: List begins empty

        // access functions
        public int Size() { return size; }
        public Boolean IsEmpty() { return size == 0; }
        public T First()                // returns the first element without removing it
        {              
            if (IsEmpty()) return default; // default is null for most types
            return head.GetElement();
        }
        public T Last()                 // returns the last element without removing it
        {
            if (IsEmpty()) return default;
            return tail.GetElement();
        }

        // update functions
        public void AddFirst(T t)       // adds element t to the front of the list
        {
            head = new Node(t, null);
            if (IsEmpty())
                tail = head;            // special case: previously empty list
            size++;
        }
        public void AddLast(T t)        // adds element e to the end of the list
        {
            Node newest = new Node(t, null);
            if (IsEmpty())
                head = newest;          // special case: previously empty list
            else
                tail.SetNext(newest);   // new node after existing tail
            tail = newest;              // new node becomes the tail
            size++;
        }
        public T RemoveFirst()          // removes and returns the first element
        {
            if (IsEmpty()) return default;  // nothing to remove
            T answer = head.GetElement();
            head = head.GetNext();      // will become null if list had only one node
            size--;
            if (size == 0)
                tail = null;            // special case: list is now empty
            return answer;
        }
    }
}
