using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithProtected
{

    class protectedbaseclass
    {
        protected int a, b;
        public void setvalue(int x , int y)
        {
            a = x;
            b = y;

        }

        public void getvalue()
        {
            Console.WriteLine(a + " " + b);

        }

    }

    class derivedclass : protectedbaseclass
    {
        int k; // private
               // D can access B's i and j
        public void mul()
        {
            k = a * b;
        }
        public void Showk()
        {
            Console.WriteLine(k);
        }

    }
        class Program
    {
        static void Main(string[] args)
        {
            derivedclass derivedclassobj = new derivedclass();
            derivedclassobj.setvalue(10, 20);
            derivedclassobj.getvalue();
            derivedclassobj.mul();
            derivedclassobj.Showk();

            Console.Read();

        }
    }
}
