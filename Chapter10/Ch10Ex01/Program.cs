using System;

namespace Ch10Ex01
{
    public class Program
    {
        public class MyClass
        {
            public readonly string Name;
            private int intVal;
            public int Val
            {
                get { return intVal; }
                set
                {
                    if (value >= 0 && value <= 10)
                    {
                        intVal = value;
                    }
                    else
                        throw (new ArgumentOutOfRangeException("Val", value, "Val must be assigned a value between 0 and 10."));
                }
            }
            public override string ToString() => "Name: " + Name + "\nVal: " + Val;
            private MyClass() : this("Default Name") { }
            public MyClass(string newName)
            {
                Name = newName;
                intVal = 0;
            }
            private int myDoubledInt = 5;
            public int myDoubledIntProp => (myDoubledInt * 2);

            static void Main(string[] args)
            {
                Console.WriteLine("Creating object myObj...");
                MyClass myObj  = new MyClass("My Object");
                Console.WriteLine("myObj created.");

                for (int i = -1; i <= 0; i++)
                {
                    try
                    {
                        Console.WriteLine($"\nAttempting to assign {i} to myObj.Val...");
                        myObj.Val = i;
                        Console.WriteLine($"Valie {myObj.Val} assigned to myObj.Val.");

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Exception {e.GetType().FullName} thrown.");
                        Console.WriteLine($"Message: \n\"{e.Message}\"");

                    }
                    Console.WriteLine("\nOutputting myObj.ToString()...");
                    Console.WriteLine(myObj.ToString());
                    Console.WriteLine("myObj.ToString() Output.");
                    Console.WriteLine("\nmyDoubledIntProp = 5...");
                    Console.WriteLine($"Getting myDoubledIntProp of 5 is {myObj.myDoubledIntProp}");
                    Console.ReadKey();
                }
            }
        }
    }
}