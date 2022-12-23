using System;

namespace Homework7_3
{


    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }

    class Program
    {
        static void Main(string[] args)
        {

            MyClass myClass = new MyClass();

            
            MyStruct myStruct; // - з класами так не працює.

            //Console.WriteLine(myClass.change); // ok
            //Console.WriteLine(myStruct.change); // -error
            myStruct.change = ""; // Спроба виведення значення неініціалізованого поля призведе до помилки.

            

            ClassTaker(myClass);

            Console.WriteLine($"Class: {myClass.change}");

            StruktTaker(myStruct);
            Console.WriteLine($"Class: {myClass.change}");


            { 
                myClass.change = "not changed (class)";
                myStruct.change = "not changed (struct)";
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Class: {myClass.change}");
                Console.WriteLine($"Class: {myClass.change}");
            }

            static void ClassTaker(MyClass myClass)
            {
                myClass.change = "changed (class)";
            }

            static void StruktTaker(MyStruct myStruct)
            {
                myStruct.change = "changed (struct)";
            }

            Console.ReadKey();
        }
    }
}
