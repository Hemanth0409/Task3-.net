using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class genericClass<T1,T2,T3>
    {
        public  genericClass(T1 val1 ,T2 val2,T3 val3)
        {
            Console.WriteLine("value:{0}",typeof(T1),val1);
            Console.WriteLine("value:{0}", typeof(T2), val2);
            Console.WriteLine("value:{0}", typeof(T3), val3);

        }
    }
    public class Test
    {

        static void Swap<T> (ref T x,ref T y )
        {
            T temp;
            temp = x;
            x = y;
            y = temp;

        } 

  
        static void Main(string[] args)
        {
            //Console.Write("Please enter array size:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[size];
            //Console.WriteLine("*****Array sort and reverse for numbers ******");
            //for (int i = 0; i < size; i++)
            //{

            //    Console.WriteLine($"Enter the value {i}:");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //    //  array[i] = ReadInt32FromConsole("Please enter element " + i);
            //}

            //Console.WriteLine("reversed array for number:");
            //Array.Sort(array);
            //Array.Reverse(array);
            //foreach (int i in array)
            //{
            //    Console.Write(i+"\t");
            //}
            //Console.Write("Please enter array size:");
            //int sizeChar = Convert.ToInt32(Console.ReadLine());
            //char[] arrayChar = new char[sizeChar];
            //Console.WriteLine("*****Array sort and reverse for Char (Enter only charcter)******");
            //for (int j = 0; j < sizeChar; j++)
            //{
            //    Console.WriteLine($"Enter the value {j}:");
            //    arrayChar[j] = Convert.ToChar(Console.ReadLine());

            //}
            //Console.WriteLine("reversed array for number:");
            //Array.Sort(arrayChar);
            //Array.Reverse(arrayChar);
            //foreach (char j in arrayChar)
            //{
            //    Console.Write(j+"\t");
            //}

            //Console.WriteLine("Swaping Number");
            //Console.WriteLine("Enter number 1:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number 2:");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Swaping char");
            //Console.WriteLine("Enter char 1:");
            //char char1 = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Enter char 2:");
            //char char2 = Convert.ToChar(Console.ReadLine());

            //Swap<int>(ref num1, ref num2);
            //Swap<char>(ref char1, ref char2);

            //Console.WriteLine("After swaping number");
            //Console.WriteLine("number 1:{0},number 2:{1}", num1,num2+"\n");


            //Console.WriteLine("After swaping Char");
            //Console.WriteLine("Char1:{0},char2:{1}", char1,char2);

            ////Generic to identify the datatype
            //genericClass<int,char,string> generic1 = new genericClass <int,char,string>(10,'c',"String");
            //Console.Write(generic1);

            prg2 taskprg2 = new prg2();
            taskprg2.task3prg2();

            Console.ReadKey();

            //prg3 prgObj = new prg3();
            //prgObj.displayFunction(prgObj);

        }


    }
}