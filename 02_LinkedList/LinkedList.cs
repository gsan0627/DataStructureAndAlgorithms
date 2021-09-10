using System;
using System.Collections.Generic;
using System.Text;

namespace _02_LinkedList
{
    public class LinkedList
    {
        private Node anchor;
        private Node job;
        private Node job2;

        public LinkedList()
        {
            anchor = new Node();
            anchor.Next = null;
        }
                
        public void Transverse()
        {            
            job = anchor;
                        
            while (job.Next != null)
            {               
                job = job.Next;
                                
                int d = job.Data;
                Console.WriteLine("{0}", d);
            }
           
            Console.WriteLine();
        }
               
        public void Add(int data)
        {
            job = anchor;
            while (job.Next != null)
            {
                job = job.Next;
            }

            Node @new = new Node();
            @new.Data = data;
            @new.Next = null;                        
            job.Next = @new;
        }

        public void Clear()
        {
            anchor.Next = null;
        }

        public bool ItIsEmpty()
        {
            return anchor.Next == null;
        }

        public Node Search(int data)
        {
            if (ItIsEmpty())
                return null;

            job2 = anchor;

            while (job2.Next != null)
            {
                job2 = job2.Next;

                if (job2.Data == data)
                    return job2;
            }

            return null;
        }

    }
}