using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3] {10,20,30};
            int[] arr2 = new int[4];
           

            ArrayList list=new ArrayList();

          
          
                
            list.Add(11);
            list.Add(12);
                list.Add(13);

            list.Insert(0,1);
            list.Insert(2, 200);

            list.AddRange(arr);

            list.Remove("hello");
            list.RemoveAt(0);
            list.RemoveRange(1,3);

            list.Sort();
            list.Reverse();

            list.CopyTo(arr2);

            bool res = list.Contains(250);
            Console.WriteLine(res);

            Console.WriteLine("no element present in collection"+ list.Count);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();





        }
    }
}
