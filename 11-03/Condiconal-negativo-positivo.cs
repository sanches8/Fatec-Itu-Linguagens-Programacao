﻿namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Forneça um número inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("O número " + num + " é positivo.");
            }
            else if(num < 0){
                Console.WriteLine("O número " + num + " é negativo.");
            }
            else
            {
                Console.WriteLine("Esse número é zero");
            }
        }
    }
}
