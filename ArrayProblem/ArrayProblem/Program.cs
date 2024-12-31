// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Security.Cryptography.X509Certificates;
namespace ArrayProblem
{
    class SecLarge
    {
        static void Main(string[] args)
        { //second largest
            int[] array = { 2, 4, 1, 3, 5 };
            int max = 0;
            int sec_max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                Console.WriteLine(max);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > sec_max && array[i] < max)
                {
                    sec_max = array[i];
                }
                Console.Write(sec_max);
            }

            //remove duplicate
            //int[] arr = { 2, 3, 4, 2, 4 };
            static void RemoveDuplicate(string[] array)
            {
                int[] arr = { 2, 3, 4, 2, 4 };
                int[] unique = new int[arr.Length];
                int j = 0;
                for (int i = 0; arr.Length > 0; i++)
                {
                    if (arr[i] != arr[i + 1])
                    {
                        unique[j++] = arr[i];
                    }
                    Console.WriteLine(unique[i]);

                }
                
      
                
            }

            static void MissingNo()
            {
                int[] arr = { 1, 2, 3, 5, 6, };
                int n = 6;
                int sum = 0;
                int NoSum = n * (n + 1) / 2;
                foreach (int i in arr)
                {
                    sum += i;
                }
                int missingNo = sum - NoSum;
                Console.WriteLine(missingNo);


            }

            static void CommonElements()
            {
                int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
                int[] arr2 = { 2, 3, 4, 8, 9, 10, 11, 12 };
                for (int i = 0; arr1.Length > 0; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            Console.WriteLine(arr1[i]);
                        }
                    }
                    
                }
            }
        }
    }
}
