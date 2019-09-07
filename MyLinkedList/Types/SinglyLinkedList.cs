using System.Collections;
using MyLinkedList.Models;

namespace MyLinkedList.Types
{
    public class SinglyLinkedList<T> : IEnumerable
    {
        public SinglyLinkedListNode<T> First { get; private set; }
        public SinglyLinkedListNode<T> Last { get; private set; }
        public int Count { get; private set; }

        public SinglyLinkedListNode<T> AddFirst(T value)
        {
            var node = new SinglyLinkedListNode<T>(value);

            if (Count < 1)
            {
                First = node;
                Last = node;
            }
            else
            {
                node.Next = First;
                First = node;
            }

            Count++;

            return node;
        }
        public SinglyLinkedListNode<T> AddLast(T value)
        {
            var node = new SinglyLinkedListNode<T>(value);

            if (Count <  1)
            {
                First = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }

            Count++;

            return node;
        }
        public void Clear()
        {
            First = null;
            Last = null;
            Count = 0;
        }
        public bool Contains(T value)
        {
            var current = First;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }
        public IEnumerator GetEnumerator()
        {
            var current = First;

            while (current != null)
            {
                yield return current.Value;

                current = current.Next;
            }
        }
    }
}