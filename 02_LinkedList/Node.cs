using System;
using System.Collections.Generic;
using System.Text;

namespace _02_LinkedList
{
    public class Node
    {       
        private int data;
               
        private Node next = null;
              
        public int Data { get => data; set => data = value; }
        internal Node Next { get => next; set => next = value; }
               
       
    }
}
