using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
        static void Main(string[] args)
        {
            #region Question02 Asignment01
            ArrayList arraylist = new ArrayList(5) { 1, 2, 3, 4, 5 };
            ReverseArrayList(arraylist);
            foreach (int item in arraylist)
            {
                Console.WriteLine(item + " ");
            } 
            #endregion












        }
    }
}
