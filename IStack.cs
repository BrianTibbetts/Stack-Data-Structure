/**
 * IStack - Stack functions to be implemented
 */

using System;

namespace StackDataStructure
{
    interface IStack<T>
    {
        /**
         * Returns the number of elements in the stack.
         * @ return number of elements in the stack
         * 
         */
        int Size();

        /**
         * Tests whether the stack is empty.
         * @return true if the stack is empty, false otherwise
         */
        Boolean IsEmpty();

        /**
         * Inserts an element at the top of the stack.
         * @param e the element to be inserted
         */
        void Push(T t);

        /**
         * Returns, but does not remove, the element at the top of the stack.
         * @return top element in the stack (or null if empty)
         */
        T Top();

        /**
         * Removes and returns the top element from the stack.
         * @return element removed (or null if empty)
         */
        T Pop();
    }
}
