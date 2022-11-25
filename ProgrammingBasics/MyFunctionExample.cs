using ProgrammingBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    public class MyFunctionExample
    {
        public  static void Disply()
        {
            Console.WriteLine("This is Display Line");
        }


        public void MyMainFunction()
        {
            int[] ar1 = { 1, 32, 32, 3, 43, 4, 34, 3, 43, 43, 43, 4 };
            int[] ar2 = { 34,34,3,43,43,4,32,33,2,5,2,323,55234,24,24 };

            int sumofArray1 =  CalculateSum(ar1);
            int sumofArray2 = CalculateSum(ar2);

            sum(3, 3);
            Console.WriteLine("Sum of Array1 is {0} ", sumofArray1);
            Console.WriteLine("Sum of Array2 is {0} ", sumofArray2);

        }
        public int CalculateSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
        ///Function OverLoading
        ///
        public int CalculateSum(int[] arr,int[] arr2,int abc)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
        public int sum(int a, int b)
        {
            return a + b;
        }
        public void showProducts()
        {
            var products = ProductsData.producst;
            foreach(var product in products)
            {
                Console.WriteLine(product);
            }
        }

        //function table value,,, range => table value = 2 , range 20 =>
    }
}
