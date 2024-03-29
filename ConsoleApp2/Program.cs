﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

 
    class Program
    {
        static void Main(string[] args)
        {
            SwapList<string> listOfNames = new SwapList<string>() { "sara", "rivka", "rachel", "lea" };
            Console.WriteLine(listOfNames[0]);
            listOfNames.Swap( 0,  2);
            Console.WriteLine(listOfNames[0]);
            PrintTheObj<string>("michal");
            int x = 2, y = 5;
            Console.WriteLine("X =  " + x + " Y = " + y);
            Swap<int>(ref x, ref y);
            Console.WriteLine("X =  " + x + " Y = " + y);

            Console.WriteLine();

            double z = 1.1, w = 8.1;
            Console.WriteLine("Z =  " + z + " W = " + w);
            Swap<double>(ref z, ref w);
            Console.WriteLine("Z =  " + z + " W = " + w);
            Console.Read();
        }
        static void PrintTheObj<T>(T obj)
        {
            Console.WriteLine(obj);
        }


        static void Swap<T>(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }
    
    }
}
