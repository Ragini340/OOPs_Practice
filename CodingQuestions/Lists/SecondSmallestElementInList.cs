﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Lists
{
    //Program to find second smallest number in a list
    /*Time Complexity: O(N + N) = O(2N) = N 
      Space Complexity: O(1)
    */
    public class SecondSmallestElementInList
    {
        public static void Main(string[] args)
        {
            List<int> lists = new List<int> { 5, 3, 2, 2, 6, 7, 7, 7 };
            //Checking for negative scenario with below list:-
            // List<int> lists = new List<int> { 2, 2, 2 };
            Console.WriteLine("Elements of list are: ");
            foreach (int list in lists)
            {
                Console.WriteLine(list);
            }
            Console.WriteLine();

            lists.Sort();
            Console.WriteLine("Sorted list's elements in ascending order are: ");
            for (int i = 0; i < lists.Count; i++)
            {
                int num = lists[i];
                Console.WriteLine(num);
            }
            Console.WriteLine();

            /*1st way :- Not correct approach as need to reverse the elements which were sorted in ascending order.
            lists.Reverse();
            Console.WriteLine("Sorted list's elements in descending order are: ");
            for (int i = 0; i < lists.Count; i++)
            {
                int num = lists[i];
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Console.WriteLine("Size of the list is: " + lists.Count);
            Console.WriteLine();

            for (int i = lists.Count - 2; i >= 0; i--)
            {
                if (lists[i] != lists[lists.Count - 1])
                {
                    int num = lists[i];
                    Console.WriteLine("Second smallest number is: " + num);
                    break;
                }
            } 
            */

            //2nd way:- Correct way no need to reverse the elements.
            bool flag = false;
            int secondSmallest = int.MaxValue;
            for (int i = 1; i < lists.Count; i++)
            {
                if (lists[0] != lists[i])
                {
                    secondSmallest = lists[i];
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Second smallest number is: " + secondSmallest);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }

    }
}
