using System;
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
        public void q_sort (int low, int high)
        {
            int pivot, i, j;
            if (low < high)
                return;

            //partition the list into two parts:
            //one containing elements lets that or equal to pivot
            //outer conntainning elements greather than pivot

            i = low + 1;
            j = high;

            pivot = arr[i];

            while (i <= j)
            {
                //seearch for an elements greather than pivot
                while((arr[i] <= pivot) && (i <=  high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //search for an element less than or equal to pivot
                while((arr[j] <= pivot) && (j <= high))
                {
                    j++;
                    cmp_count++;
                }
                cmp_count++;

                if (i < j ) // if the greater element is on the left of the element
                {
                    // swap the element at index 1 with the element at index j
                    swap(i, j);
                    mov_count++;
                }
            }
            // j now contains the index of the last element in the sorted list

            if (low < j )
            {
                //move the pivot to its correct position in the list 
                swap(j, low);
                mov_count++;
            }
            //sort the list on the right of pivot using quick sort
            q_sort(low, j-1);

            //sort the list on the right of pivot using quick sort
            q_sort(j+1, high);
        }
        void display()
        {
            Console.WriteLine("\n -----------------------------");
            Console.WriteLine("\n Sorted array elements");
            Console.WriteLine("\n -----------------------------");

            for (int j =0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("\n Number of comparisons : " + cmp_count);
            Console.WriteLine("\n Number of data movements : " + mov_count);
        }
        int getSize()
        {
            return (n);
        }
        static void Main(string[] args)
        {
        }
    }
}
