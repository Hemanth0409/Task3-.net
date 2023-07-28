using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class prg2
    {
        public void task3prg2()
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add(2);
            arrList.Add(null);
            arrList.Add("hi");

            foreach (var i in arrList)
            {
                var y = i ?? "I have null";
                Console.WriteLine(y);
            }
        }
    }
}

