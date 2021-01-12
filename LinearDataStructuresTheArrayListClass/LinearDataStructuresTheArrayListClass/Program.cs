using System;
using System.Collections;
using System.Collections.Generic;

namespace LinearDataStructuresTheArrayListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GetprimesAnotherType();


            /*
            List<int> firstList = new List<int>();
            for (int i = 1; i <= 5 ; i++)
            {
                firstList.Add(i);
            }
            Console.Write("firstList = ");
            PrintList(firstList);

            List<int> secondList = new List<int>();
            secondList.Add(2);
            secondList.Add(4);
            secondList.Add(6);
            Console.Write("secondList = ");
            PrintList(secondList);

            List<int> unionList = Union(firstList, secondList);
            Console.Write("Union = ");
            PrintList(unionList);

            List<int> intersectionList = Intersect(firstList, secondList);
            Console.Write("Intersection = ");
            PrintList(intersectionList);
            */


            /*
            List<int> primes = GetPrimes(200, 300);
            foreach (var item in primes)
            {
                Console.Write("{0} ", item);
            }
            */

            //NumbersFromArrayList();

            //CreateListFromArrayList();
        }

        static void GetprimesAnotherType()
        {
            List<int> firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(4);
            firstList.Add(5);
            Console.Write("firstList = ");
            PrintList(firstList);

            List<int> secondList = new List<int>();
            secondList.Add(2);
            secondList.Add(4);
            secondList.Add(6);
            Console.Write("secondList = ");
            PrintList(secondList);

            List<int> unionList = new List<int>();
            unionList.AddRange(firstList);

            for (int i = unionList.Count - 1; i >= 0; i--)
            {
                if (secondList.Contains(unionList[i]))
                {
                    unionList.RemoveAt(i);
                }
            }

            unionList.AddRange(secondList);
            Console.Write("union = ");
            PrintList(unionList);
            
            List<int> intersectList = new List<int>();
            intersectList.AddRange(firstList);
            
            for (int i = intersectList.Count - 1; i >= 0; i--)
            {
                if (!secondList.Contains(intersectList[i]))
                {
                    intersectList.RemoveAt(i);
                }
            }
            Console.Write("intersect = ");
            PrintList(intersectList);
        }

        static List<int> Union(List<int> firstList, List<int> secondList)
        {
            List<int> union = new List<int>();
            union.AddRange(firstList);
            foreach (var item in secondList)
            {
                if (!union.Contains(item))
                {
                    union.Add(item);
                }
            }

            return union;
        }

        static List<int> Intersect(List<int> firstList, List<int> secondList)
        {
            List<int> intersection = new List<int>();
            foreach (var item in firstList)
            {
                if (secondList.Contains(item))
                {
                    intersection.Add(item);
                }
            }

            return intersection;
        }

        static void PrintList(List<int> list)
        {
            Console.Write("{ ");
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine("}");
        }

        static List<int> GetPrimes(int start, int end)
        {
            List<int> primeList = new List<int>();
            for (int num = start; num <= end; num++)
            {
                bool prime = true;
                double numSqrt = Math.Sqrt(num);
                for (int div = 2; div <= numSqrt; div++)
                {
                    if (num % div == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    primeList.Add(num);
                }
            }
            return primeList;
        }
        static void NumbersFromArrayList()
        {
            ArrayList list = new ArrayList();
            
            list.Add(2);
            list.Add(3.5f);
            list.Add(25u);
            list.Add(" EUR");
            
            dynamic sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                dynamic value = list[i];
                sum = sum + value;
            }
            Console.WriteLine("Sum = " + sum);
        }

        static void CreateListFromArrayList()
        {
            ArrayList list = new ArrayList();
            list.Add("Hello");
            list.Add(5);
            list.Add(3.14159);
            list.Add(DateTime.Now);

            for (int i = 0; i < list.Count; i++)
            {
                object value = list[i];
                Console.WriteLine("Index = {0} - Value = {1}", i, value);
            }
        }
    }
}
