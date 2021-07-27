using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFirstApplication
{
    class ArrayEg
    {
        //
        //
        //datatype[] arrayname = new datatype[size];
        string[] fruits = new string[3];
        int[] mark = { 89, 78, 90 };
      internal void GetFruits()
        {
            for(int i=0; i < fruits.Length; i++)
            {
                Console.WriteLine("Enter Fruit name");
                fruits[i] = Console.ReadLine();
            }
            //implicit typed variable
            foreach(var fu in fruits)
            {
                Console.WriteLine("FruitName:{0}", fu);
            }
        }
    }
    class StringEg
    {
        internal void StringFunctionEg()
        {
            string Firstname = "Sai";
            string name = "Aakanksha Kapure";
            Console.WriteLine("To Upper :{0}", Firstname.ToUpper());
            Console.WriteLine("To Lower :{0}", Firstname.ToLower());
            bool isContains = name.Contains("UP");
            Console.WriteLine("Contains UP :{0}", isContains);
            Console.WriteLine("Substring:{0}", name.Substring(3,5));



        }
    }
    class Array_Static
    {
        static void Main()
        {
            ArrayEg arrayEg = new ArrayEg();
            arrayEg.GetFruits();

            StringEg stringEg = new StringEg();
            stringEg.StringFunctionEg();

        }
        
    }
}
