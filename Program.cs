namespace linked_list_kth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.Head = new Node(1);
            ll.Head.Next = new Node(3);
            ll.Head.Next.Next = new Node(8);
            ll.Head.Next.Next.Next = new Node(2);

            Node middleNode = ll.FindMiddleNode();
            if (middleNode != null)
            {
                int value = middleNode.Value;
                Console.WriteLine("Middle node value: " + value);
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
        }
    }
}