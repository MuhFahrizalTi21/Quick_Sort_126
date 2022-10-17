﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort_126
{
    class Program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0;
        private int mov_count = 0;

        //number of elements in array
        private int n;

        void read()
        {
            while(true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\n array can have maximum 20 elements \n");
            }
            Console.WriteLine("=========================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("=========================");

            //get array elements
            for(int i = 0; i < n; i++)
            {
                Console.Write("<" + (i +1) + ">");
                string s = Console.ReadLine();
                arr[i] = Int32.Parse(s);
            }
        }
        
        //swap the elements at index x with the element at index y
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        static void Main(string[] args)
        {
        }
    }
}
