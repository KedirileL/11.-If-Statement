using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;

            //NB ! means not, or negation
            if (isMale)
            {
                Console.WriteLine("You are male");
            }
            else
            {
                Console.WriteLine("You are female");
            }

            bool isTall = true;

            if(isTall && isMale)
            {
                Console.WriteLine("You are tall and a male");
            }

            else if(!isTall && isMale)
            {
                Console.WriteLine("Your are a short male");
            }

            else if(isTall && !isMale)
            {
                Console.WriteLine("You are tall and not male");
            }

            else if (!(isMale && isTall)) 
            {
                Console.WriteLine("You are neither a male nor tall");
            }
        }
    }
}
