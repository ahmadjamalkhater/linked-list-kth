using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_kth
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedList
    {
        public Node Head { get; set; }

        public int KthFromEnd(int k)
        {
            if (Head == null)
            {
                throw new Exception("The linked list is empty.");
            }

            if (k < 0)
            {
                throw new Exception("Invalid value for k.");
            }

            Node slowPtr = Head;
            Node fastPtr = Head;

            for (int i = 0; i < k; i++)
            {
                if (fastPtr.Next != null)
                {
                    fastPtr = fastPtr.Next;
                }
                else
                {
                    throw new Exception("The linked list does not have k nodes.");
                }
            }

            while (fastPtr.Next != null)
            {
                slowPtr = slowPtr.Next;
                fastPtr = fastPtr.Next;
            }

            return slowPtr.Value;
        }

        public Node FindMiddleNode()
        {
            if (Head == null)
            {
                return null;
            }

            Node slowPtr = Head;
            Node fastPtr = Head;

            while (fastPtr != null && fastPtr.Next != null)
            {
                slowPtr = slowPtr.Next;
                fastPtr = fastPtr.Next.Next;
            }

            return slowPtr;
        }
    }

}
