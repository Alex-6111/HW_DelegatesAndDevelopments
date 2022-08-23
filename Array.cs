using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DelegatesAndDevelopments
{
    public class Array
    {
        public int[]? arr;
        public int? size;

        public Array(int[]? arr, int? size)
        {
            this.arr = arr;
            this.size = size;
        }

        public void Fill()
        {
            Random rnd = new Random();
            for(int i = 0; i < size; i++)
            {
                this.arr[i] = rnd.Next();
            }
        }

        public void Print()
        {
            foreach(int i in arr)
            {
                Console.WriteLine($"{i}\t");
            }
        }

        public void EvenValue(int[] arr1)
        {
            int j = 1;
            for(int i = 0; i < this.arr.Length; i++)
            {
                if(this.arr[i] % 2 == 0)
                {
                    arr1[i] = this.arr[i];
                    j++;
                }
            }
        }

        public void OddValue(int[] arr1)
        {
            int j = 0;
            for(int i = 0; i < this.arr.Length; i++)
            {
                if (this.arr[i] % 2 != 0)
                {
                    arr1[1] = this.arr[i];
                    j++;
                }
            }
        }

        public void PrimeDigit(int[] arr2)
        {
            int j = 0;
            for(int i = 0; i < this.arr.Length; i++)
            {
                bool IsPrime = true;
                for(int k = 0; k < this.arr[i]; k++)
                {
                    if (this.arr[i] % k == 0)
                    {
                        IsPrime = false;
                    }
                }
                if (IsPrime)
                {
                    arr2[j] = this.arr[i];
                    j++;
                }
            }
        }

        public void FibonacciDigit(int[] arr2)
        {
            arr2[0] = 0;
            arr2[1] = 1;
            for(int i = 2; i < this.arr.Length; i++)
            {
                arr2[i] = this.arr[i - 2] + arr2[i - 1];
            }
        }
    }
}
