using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DbMigration
{
    public class Noda
    {
        public int data;
        public Noda next;


        public Noda(int i)
        {
            this.data = i;
            this.next = null;
        }

        public void AddtoEnd(int data)
        {
            if(next==null)
            {
                next = new Noda(data);
            }

            else
            {
                next.AddtoEnd(data);
            }
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("|" + data + "|->");

            if (next!=null)
            {
                next.Print();
            }

        }
    }

    public class MyList
    {
        public Noda Head;

        public MyList(int data)
        {
            Head = null;
        }

        public void AddtoEnd(int data)
        {
            if (Head == null)
            {
                Head = new Noda(data);
            }

            else
            {
                Head.AddtoEnd(data);
            }
        }

        public void Print()
        {            
            if (Head != null)
            {
                Head.Print();
            }

        }
    }

    public class LinkList
    {
        static void Main()
        {
            MyList x = new MyList(1);
            //x.next = new Node(2);
            //x.next.next = new Node(3);
            //x.next.next.next = new Node(8);
            //x.next.next.next.next = new Node(4);
            //x.AddtoEnd(2);
            //x.AddtoEnd(3);
            //x.AddtoEnd(4);
            //x.AddtoEnd(5);
            x.AddtoEnd(4);
            x.AddtoEnd(5);
            x.AddtoEnd(2);
            x.AddtoEnd(54);
            x.AddtoEnd(41);
            x.Print();           
            Console.ReadLine();
        }
    }

}