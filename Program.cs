using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // selection
            int age;
            Console.WriteLine("What is your age?");
            age = Convert.ToInt16(Console.ReadLine());
            if (age > 16)
            {
                Console.WriteLine("you don't need to be in school!");
            }
            else if (Age > 21)
            {
                Console.WriteLine("you don't need to be in education!");

            }
