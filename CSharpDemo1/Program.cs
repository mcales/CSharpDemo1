using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo1
{
    /// <summary>
    /// Demo project for first cSharp console application
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is my main function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var myString = "I am just here to learn";
            var myArray = myString.Split(' ');
            for (var i = 0;i< myArray.Length; i++) {
                Console.Write(myArray[i] + i + " ");
            }
            Console.Write("\nEnter a string to be processed:");
            var myString2 = Console.ReadLine();
            var myArray2 = myString2.Split(' ');
            for (var i = 0; i < myArray2.Length; i++)
            {
                Console.Write(myArray2[i] + i + " ");
            }
            Console.ReadLine();
        }
    }
}
