﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator=new FibonacciGenerator();
            foreach (var digit in generator.Generate(15))
            {
                Console.WriteLine(digit);
            }
            // if(args.Length>0)
            // {
            //     Console.WriteLine($"Hello {args[0]}!");
            // }
            // else
            // {
            //     Console.WriteLine("Hello!");
            // }

            // Console.WriteLine("Fibonacci Number 1-15:");
            
            // for(int i=0;i<15;i++)
            // {
            //     Console.WriteLine($"{i+1}:{FibonacciNumber(i)}");
            // }
        }

        static int FibonacciNumber(int n)
        {
            int a=0;
            int b=1;
            int tmp;
            for(int i=0;i<n;i++)
            {
                tmp=a;
                a=b;
                b+=tmp;
            }
            return a;
        }
    }
}
