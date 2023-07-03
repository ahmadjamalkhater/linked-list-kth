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

            Console.WriteLine(ll.KthFromEnd(0));  // Output: 2
            Console.WriteLine(ll.KthFromEnd(2));  // Output: 3

        }
    }
}