/**
 * LinkedStack
 * A stack implemented using a singly linked list
 */
using System;

namespace StackDataStructure
{
    public class LinkedStack<T> : IStack<T>
    {
        private SinglyLinkedList<T> list = new SinglyLinkedList<T>();
        public LinkedStack() { }    // Constructor: Stack begins empty
        public int Size() { return list.Size(); }
        public Boolean IsEmpty() { return list.IsEmpty(); }
        public void Push(T element) { list.AddFirst(element); }
        public T Top() { return list.First(); }
        public T Pop() { return list.RemoveFirst(); }
    }
}
