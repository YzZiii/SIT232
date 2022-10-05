using System;
using System.Collections.Generic;
using System.Linq;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] myArray = new double[10];//declaring array of type double with 10 elements

            myArray[0] = 1.0; // first element of the array
            myArray[1] = 1.1;
            //rest elements one by one
            myArray[2] = 1.2;
            myArray[3] = 1.3;
            myArray[4] = 1.4;
            myArray[5] = 1.5;
            myArray[6] = 1.6;
            myArray[7] = 1.7;
            myArray[8] = 1.8;
            myArray[9] = 1.9;


            Console.WriteLine("\n****************************");
            Console.WriteLine("**Question 1 ");
            Console.WriteLine("**************************");
            //printing 0-9 of element
            Console.WriteLine("The element at index 0 in the array is " + myArray[0]);
            Console.WriteLine("The element at index 1 in the array is " + myArray[1]);
            Console.WriteLine("The element at index 2 in the array is " + myArray[2]);
            Console.WriteLine("The element at index 3 in the array is " + myArray[3]);
            Console.WriteLine("The element at index 4 in the array is " + myArray[4]);
            Console.WriteLine("The element at index 5 in the array is " + myArray[5]);
            Console.WriteLine("The element at index 6 in the array is " + myArray[6]);
            Console.WriteLine("The element at index 7 in the array is " + myArray[7]);
            Console.WriteLine("The element at index 8 in the array is " + myArray[8]);
            Console.WriteLine("The element at index 9 in the array is " + myArray[9]);

            Console.WriteLine("\n***********************");
            Console.WriteLine("** Question 2");
            Console.WriteLine("*************************");

            int[] myIntArray = new int[10];// declaring an array of type integer wwith ten elements and assign increment value
            for (int i = 0; i < myIntArray.Length; i++)
            {
                myIntArray[i] = i;
            }

            for (int i = 0; i < myIntArray.Length; i++) //  For loop print the values in the array
            {
                Console.WriteLine("The element at position {0} is {1}", i, myIntArray[i]);
            }

            Console.WriteLine("\n***********************");
            Console.WriteLine("** Question 3");
            Console.WriteLine("*************************");

            int[] studentArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };//Creating an array
            int total = 0;

            for (int i = 0; i < studentArray.Length; i++)// Sum of studentArray
            {
                total += studentArray[i];
            }
            // Testing the result
            Console.WriteLine("The total marks for the student is " + total);
            Console.WriteLine("This consists of " + studentArray.Length + " marks");
            // Printing the average 
            Console.WriteLine("Therefore the average is " + (total / studentArray.Length));

            Console.WriteLine("\n***********************");
            Console.WriteLine("** Question 4");
            Console.WriteLine("*************************\n");

            String[] studentNames = new string[6];

            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.Write("Student {0} name: ", i + 1);
                studentNames[i] = Console.ReadLine();
            }

            for (int i = 0; i < studentNames.Length; i++)// testing and printing each line
            {
                Console.WriteLine("Student {0} {1}", i + 1, studentNames[i]);
            }

            Console.WriteLine("\n***********************");
            Console.WriteLine("** Question 5");
            Console.WriteLine("*************************\n");

            double[] values = new double[10];
            double currentLargest;
            double currentSmallest;

            for (int i = 0; i < values.Length; i++)
            {
                Console.Write("Enter a double for position {0}: ", i);
                String input = Console.ReadLine();
                values[i] = Convert.ToDouble(input);
            }

            currentLargest = values[0];

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > currentLargest)
                    currentLargest = values[i];
                Console.WriteLine(values[i]);
            }

            Console.WriteLine("The largest value os " + currentLargest);

            currentSmallest = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < currentSmallest)
                    currentSmallest = values[i];
            }

            Console.WriteLine("The Smallest value os " + currentSmallest);

            Console.WriteLine("\n***********************");
            Console.WriteLine("******* Question 6******");
            Console.WriteLine("*************************\n");

            int[,] myMultArray = new int[3, 4] { {1,2,3,4},
                                                 {1,1,1,1},
                                                 {2,2,2,2}};
            for (int i = 0; i < myMultArray.GetLength(0); i++)
            {
                for (int j = 0; j < myMultArray.GetLength(1); j++)
                {
                    Console.Write(myMultArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n***********************");
            Console.WriteLine("******* Question 7******");
            Console.WriteLine("*************************");

            List<String> myStudentlist = new List<string>();//Creating new List

            //Generate a random number as the list size
            Random randomVaule = new Random();
            int randomNumber = randomVaule.Next(1, 12);

            //Add element to the list
            Console.WriteLine("You now need to add  " + randomNumber + " Student to your class list");

            for (int i = 0; i < randomNumber; i++)
            {
                Console.Write("Please enter the name of Student " + (i + 1) + ": ");
                myStudentlist.Add(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("The Students are: ");

            for (int i = 0; i < myStudentlist.Count; i++)// printing each element
            {
                Console.WriteLine(myStudentlist[i]);
            }

            Console.WriteLine();

            Console.WriteLine("\n***********************");
            Console.WriteLine("** Question 8 TestArray");
            Console.WriteLine("*************************");

            int[] test1 = { 1, 2, 3, 1, 3, 2, 1 };
            int[] test2 = { 3,2,1 };
            Console.WriteLine(Palindrome(test1));
            Console.WriteLine(Palindrome(test2));

            static bool Palindrome(int[] array)
            {
                if (array.Length < 1)
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < array.Length / 2; i++)
                    {
                        if (array[i] != array[array.Length - i - 1])
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }

            Console.WriteLine("\n***********************");
            Console.WriteLine("** Question 9 ");
            Console.WriteLine("*************************");

            Console.WriteLine("This the result of 2 Sorted list: ");
            List<int> testList_a = new List<int> { 1, 2, 2, 5 };
            List<int> testList_b = new List<int> { 1, 3, 4, 5, 7 };
            List<int> mergeResult = Merge(testList_a, testList_b);// Expecting 1,1,2,2,3,4,5,5,7
            for (int i=0; i<mergeResult.Count; i++)
            {
                Console.WriteLine(mergeResult[i]);
            }

            Console.WriteLine("This the result of empty list and 1 sorted list: ");
            testList_a = new List<int> {            };
            testList_b = new List<int> { 1, 2, 2, 5 };
            mergeResult = Merge(testList_a, testList_b);// Expecting 1,1,2,2,3,4,5,5,7
            for (int i = 0; i < mergeResult.Count; i++)
            {
                Console.WriteLine(mergeResult[i]);
            }

            //Console.WriteLine("This is the result of 1 unsorted list: ");
            //testList_a = new List<int> { 5, 2, 2, 1 };
            //testList_b = new List<int> { 1, 3, 4, 5, 7 };
            //mergeResult = Merge(testList_a, testList_b);
            //for (int i = 0; i < mergeResult.Count; i++)
            //{
            //    Console.Write(mergeResult[i]);
            //}
            

            static List<int> Merge(List<int> list_a, List<int> list_b)
            {
                bool isSorted = true;
                for (int i = 0; i < list_a.Count - 1; i++)
                {
                    if (list_a[i] > list_a[i + 1])
                    {
                        isSorted = false;
                        break;
                    }
                }
                for (int i = 0; i < list_b.Count - 1; i++)
                {
                    if (list_b[i] > list_b[i + 1])
                    {
                        isSorted = false;
                        break;
                    }
                }
                if (isSorted == false)
                {
                    return null;
                }
                else
                {
                    list_a.AddRange(list_b);
                    list_a.Sort();
                    return list_a;
                }
            }



            Console.WriteLine("\n***********************");
            Console.WriteLine("** Question 10");
            Console.WriteLine("*************************");

            int[,] array_of_conversion = new int[4, 6]   { { 0, 2, 4, 0, 9, 5 }, 
                                                         {   7, 1, 3, 3, 2, 1 }, 
                                                         {   1, 3, 9, 8, 5, 6 }, 
                                                         {   4, 6, 7, 9, 1, 0 } };
            MaxSumSubMatrix(array_of_conversion);
            static void MaxSumSubMatrix(int[,] array)
            {
                int MaxSum = 0;
                int[,] subMatrix = new int[2, 2] { { 0, 0 }, { 0, 0 } };
                for (int i = 0; i < array.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < array.GetLength(1) - 1; j++)
                    {
                        int tempSum = array[i, j] + array[i + 1, j] + array[i, j + 1] + array[i + 1, j + 1];
                        if (tempSum > MaxSum)
                        {
                            MaxSum = tempSum;
                            subMatrix[0, 0] = array[i, j];
                            subMatrix[1, 0] = array[i + 1, j];
                            subMatrix[0, 1] = array[i, j + 1];
                            subMatrix[1, 1] = array[i + 1, j + 1];
                        }
                    }
                }
                Console.WriteLine("The maximal sum is: " + MaxSum);
                Console.WriteLine("The matrix is: ");
                for (int i = 0; i < subMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < subMatrix.GetLength(1); j++)
                    {
                        Console.Write(subMatrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
