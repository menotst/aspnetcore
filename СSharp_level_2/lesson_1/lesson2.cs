using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    public class lesson2
    {
        public static void Method1()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("string");
            list.Add(new int[] { 1,2,3});
            foreach (object obj in list)
            {
                Console.WriteLine(obj.ToString());                
            }
            Console.ReadKey();
        }
        
    }
}
