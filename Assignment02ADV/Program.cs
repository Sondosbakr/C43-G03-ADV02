using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02ADV
{
    internal class Program
    {
        #region Question02 Assignment01
        public static void ReverseArrayList(ArrayList arrayList)
        {
            int left = 0;
            int right = arrayList.Count - 1;
            while (left < right)
            {
                object temp = arrayList[left];
                arrayList[left] = arrayList[right];
                arrayList[right] = temp;
                left++;
                right--;
            }
        }
        #endregion

        #region Question03 Assignment01
        public static List<int> GetEvenNumbers(List<int> list)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                    result.Add(list[i]);
            }
            return result;
        }
        #endregion

        #region Question05 Assignment01
        public static int FirstNonReapetedCharIndex(string str)
        {
            Dictionary<char, int> charcount = new Dictionary<char, int>();
            foreach(char c in str)
            {
                if (charcount.ContainsKey(c))
                    return charcount[c];
                else
                    charcount[c] = 1;
            }

            for(int i = 0; i < str.Length; i++)
                if(charcount.ContainsKey(str[i]))
                    return i;
            return -1;
        }
        #endregion

        #region Question02 Assignment02 (IsPalindrome) 
        public static bool IsPalindrom(int num)
        {
            int digit, reversed = 0;
            int original = num;
            while (num > 0)
            {
                digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }
            return original == reversed;
        }
        #endregion

        #region Question03 Assignment02(Reverse Queue)
        public static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            while(queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
                queue.Enqueue(stack.Pop());
            
        }
        #endregion

        #region Question05 Assignment02
        public static int[] RemoveDuplicates(int[] array)
        {
            int[] tempArray = new int[array.Length];
            int index = 0;

            for(int i = 0;i < array.Length;i++)
            {
                bool isDuplicate = false;
                for(int j = 0; j < index; j++)
                {
                    if (array[i] == tempArray[j])
                        isDuplicate = true;
                }

                if (!isDuplicate)
                {
                    tempArray[index] = array[i];
                    index++;
                }
            }
            int[] result = new int[index];
            for (int i = 0; i < index; i++)
            {
                result[i] = tempArray[i];
            }
            return result;
        }
        #endregion

        #region Question06 Assignment029(Remove Odd Numbers)
        public static List<int> RemoveOddNumbers(List<int> list)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 ==0)
                {
                    result.Add(list[i]);
                }     
            }   
            return result;
        }
        #endregion

        #region Question08 Assignment02
        public static void PushAndSearch(Stack<int> stack, int[] numbers, int target)
        {
            foreach (var item in numbers)
            {
                stack.Push(item);
            }

            Stack<int> tempStack = new Stack<int>();
            int count = 0;
            bool found = false;
            
            while(stack.Count > 0)
            {
                var item = stack.Pop();
                tempStack.Push(item);
                count++;
                if (item == target)
                {
                    found = true;
                    Console.WriteLine($"Target was found successfully and the count = {count}");
                    break;
                }
            }
            while(tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }
            if(!found)
            {
                Console.WriteLine("Target was not found");
            }
        }
        #endregion

        #region Question09 Assignment02
        public static List<int> FindIntersection(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
            for (int i = 0; i<arr1.Length; i++)
            {
                for (int j = 0; j<arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j] && !result.Contains(arr1[i]))
                        result.Add(arr1[i]);
                }
            }
            return result;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Question02 Asignment01
            //ArrayList arraylist = new ArrayList(5) { 1, 2, 3, 4, 5 };
            //ReverseArrayList(arraylist);
            //foreach (int item in arraylist)
            //{
            //    Console.WriteLine(item + " ");
            //}
            #endregion

            #region Question03 Assignment01
            //You are given a list of integers. Your task is to find and return a new list
            //containing only the even numbers from the given list.
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> result = GetEvenNumbers(list);
            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Question05 Assignment05
            //Given a string, find the first non-repeated character in it and return its index.
            //If there is no such character, return . Hint: you can use dictionary
            //string str = "SWSSIO";
            //int index = FirstNonReapetedCharIndex(str);
            //Console.WriteLine(index);

            #endregion

            #region Question01 Assignment02
            //bool isParsed;
            //int size;
            //int numberofquery;
            //do
            //{
            //    Console.WriteLine("Enter the size of array");
            //    isParsed = int.TryParse(Console.ReadLine(), out size);
            //} while (!isParsed || size <= 0);

            //do
            //{
            //    Console.WriteLine("Enter the number of query");
            //    int.TryParse(Console.ReadLine(), out numberofquery);
            //} while (!isParsed || numberofquery <= 0);

            //int[] array = new int[size];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the number {i + 1} : ");
            //        isParsed = int.TryParse(Console.ReadLine(), out array[i]);
            //    } while (!isParsed);
            //}

            //int[] queries = new int[numberofquery];
            //for (int i = 0; i < queries.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the query {i + 1} : ");
            //        isParsed = int.TryParse(Console.ReadLine(), out queries[i]);
            //    } while (!isParsed);
            //}

            //foreach (var query in queries)
            //{
            //    int count = 0;
            //    foreach (var item in array)
            //    {
            //        if (item > query)
            //            count++;
            //    }
            //    Console.WriteLine("Output");
            //    Console.WriteLine(count);
            //} 
            #endregion

            #region Question02 Assignment02
            //bool isParsed;
            //int number;
            //do
            //{
            //    Console.WriteLine("Enter the number ");
            //    isParsed = int.TryParse(Console.ReadLine(), out number); 
            //} while (!isParsed);

            //if(IsPalindrom(number))
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("NO");
            #endregion

            #region Question03 Assignment02(Reverse Queue)
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //ReverseQueue(queue);
            //foreach (int item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question05 Assignment02
            //int[] array = new int[5] { 1,2,2,3,3};
            //int[] result = RemoveDuplicates(array);
            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question06 Asssignment02
            ////6. Given an array list , implement a function to remove all odd numbers from it.
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> result = RemoveOddNumbers(list);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question08 Assignment02
            //Stack<int> stack = new Stack<int>();
            //int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            //int target;
            //Console.WriteLine("Enter the Number ");
            //int.TryParse(Console.ReadLine(), out target);
            //PushAndSearch(stack, array, target);
            #endregion

            #region Question09 Assignment02
            bool isParesd;
            int size1;
            int size2;
            do
            {
                Console.WriteLine("Enter The Size of the firsy array");
                isParesd = int.TryParse(Console.ReadLine(), out size1);
            } while (!isParesd || size1 <= 0);

            do
            {
                Console.WriteLine("Enter The Size of the second array");
                isParesd = int.TryParse(Console.ReadLine(), out size2);
            } while (!isParesd || size2 <= 0);

            int[] arr1 = new int[size1];
            int[] arr2 = new int[size2];

            for (int i = 0; i < arr1.Length; i++)
            {
                do
                {
                    Console.Write($"Enter the number of array1 {i + 1} : ");
                    isParesd = int.TryParse(Console.ReadLine(), out arr1[i]);
                } while (!isParesd);
            }
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < arr2.Length; i++)
            {
                do
                {
                    Console.Write($"Enter the number of array2 {i + 1} : ");
                    isParesd = int.TryParse(Console.ReadLine(), out arr2[i]);
                } while (!isParesd);
            }
            List<int> list = FindIntersection(arr1, arr2);
            Console.WriteLine("Intersecotion ");
            foreach (var item in list)
            {
                Console.Write($"[ {item} ]");
            }
            Console.WriteLine();
            #endregion

        }
    }
}
