﻿using System;

namespace console
{
    public class A
    {
        public int a = 1;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var val = Environment.GetEnvironmentVariable("SOMEVAR");
            Console.WriteLine($"Hello World! {val}");

        }
    }
}