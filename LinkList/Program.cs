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

        public void AddSorted(int data)
        {
            if(next==null)
            {
                next = new Noda(data);
            }
            else if(data < next.data)
            {
                Noda temp = new Noda(data);
                temp.next = this.next;
                this.next = temp;       
            }

            else
            {
                next.AddSorted(data);
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

        public void AddtoBegin(int data)
        {
            if (Head == null)
            {
                Head = new Noda(data);
            }

            else
            {
                Noda temp = new Noda(data);
                temp.next = Head;
                Head = temp;
            }
        }

        public void Print()
        {            
            if (Head != null)
            {
                Head.Print();
            }

        }

        public void AddSorted(int data)
        {
            if(Head==null)
            {
                Head = new Noda(data);
            }

            else if(data < Head.data)
            {
                AddtoBegin(data);
            }

            else
            {
                Head.AddSorted(data);
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
            x.AddSorted(4);
            x.AddSorted(5);
            x.AddSorted(2);
            x.AddSorted(54);
            x.AddSorted(41);
            x.Print();           
            Console.ReadLine();
        }
    }

}