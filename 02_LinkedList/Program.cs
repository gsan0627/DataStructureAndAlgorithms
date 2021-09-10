using System;

namespace _02_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList items = new LinkedList();

            items.Add(3);
            items.Add(4);
            items.Add(5);
            items.Add(7);
            items.Add(9);
            items.Add(10);
            items.Add(15);

            items.Transverse();
            Console.WriteLine(items.ItIsEmpty());
            items.Clear();

            items.Transverse();
            Console.WriteLine(items.ItIsEmpty());

            Node searched = items.Search(7);
            Console.WriteLine(searched?.Data);

            Console.ReadKey();
        }
    }
}
