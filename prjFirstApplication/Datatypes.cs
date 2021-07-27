using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFirstApplication
{
    class Datatypes
    {
        //Creating Method -Syntax
        /*accesssspecifier returntype methodname(parameterlist){code}*/
        void Types()
        {
            String name;
            int age;
            float salary = 67997.90f;
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());
            //Placeholder
            Console.WriteLine("Name:{0} && Age:{1} && Salary:{2}", name, age, salary);
                    
        }
        void TypeConversion()
        {
            //Implicit and Explicit type conversion
            //Implicit -int<float<double
            int num = 100;
            float petrol = num;
            double disel = petrol;
            Console.WriteLine("Implicit type conversion:{0},disel");
            //Explicit type
            float percentage = 90.22f;
            Console.WriteLine("Enter Percentage");
            percentage = Convert.ToInt32(Console.ReadLine());

        }
        void BoxingandUnboxing()
        {
            int salary = 20000;
            Object obj = salary;//coverting int to obj--boxing
            int number = (int)obj;//unboxing
            Console.WriteLine("BoxingandUnboxing:{0}", number);
        }

        void nullableTypes()
        {
            //Value Nullable type
            //int age1=null
            int? age = null;
            Console.WriteLine();
            //Reference Nullable type
            String? City = null;
            Console.WriteLine("City is{0}",City??"Chennai");
        }
        static void Main()
        {
            Datatypes t1 = new Datatypes();
            t1.Types();
            Console.WriteLine("-------------------");
            t1.TypeConversion();
            Console.WriteLine("-------------------");
            t1.BoxingandUnboxing();
            Console.WriteLine("-------------------");
            t1.nullableTypes();
        }



    }
}
