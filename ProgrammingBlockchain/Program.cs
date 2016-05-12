using System;
using System.Linq;
using ProgrammingBlockchain.Chapters;

namespace ProgrammingBlockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            var chapter = new Chapter1();

            chapter.Lesson1();
            chapter.Lesson2();
            chapter.Lesson3();
            //chapter.lesson4();

            Console.WriteLine("\n\n\nPress enter to continue");
            Console.ReadLine();
        }
    }
}
