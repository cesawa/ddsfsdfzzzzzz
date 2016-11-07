using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New line");

            Console.WriteLine("Second line! ... and his COOL!!");

            Console.WriteLine("Thred line! ... and his SO COOL!! ~!!!!!!!");


            Console.WriteLine("Hmmmm");

            Console.WriteLine("!!!!! Hmmmm !!!!!!");

        }

        static void branch1()
        {
<<<<<<< HEAD
            Console.WriteLine("Its new branch. Woohoo ;)");
=======
            Console.WriteLine("Its 3 branch. Woohoo ;)");
>>>>>>> master
        }
    }
}
