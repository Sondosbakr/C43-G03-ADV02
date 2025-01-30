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
            string str = "SWSSIO";
            int index = FirstNonReapetedCharIndex(str);
            Console.WriteLine(index);

            #endregion









        }
    }
}
