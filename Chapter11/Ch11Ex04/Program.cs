Checker check = new Checker();
ClassA try1 = new ClassA();///110
ClassB try2 = new ClassB();///010
ClassC try3 = new ClassC();///000
ClassD try4 = new ClassD();///110

MyStruct try5 = new MyStruct();///011
object try6 = try5;///011
Console.WriteLine("Analazying ClassA type variable: ");
check.Check(try1);
Console.WriteLine("\nAnalazying ClassB type variable: ");
check.Check(try2);
Console.WriteLine("\nAnalazying ClassC type variable: ");
check.Check(try3);
Console.WriteLine("\nAnalazying ClassD type variable: ");
check.Check(try4);
Console.WriteLine("\nAnalazying MyStruct type variable: ");
check.Check(try5);
Console.WriteLine("\nAnalazying boxed MyStruct type variable: ");
check.Check(try6);


public class Checker
{
    public void Check(object param1)
    {
        if (param1 is ClassA)
        {
            Console.WriteLine("Variable can be converted to ClassA.");
        }
        else
            Console.WriteLine("Variable can't be converted to ClassA.");
        if(param1 is IMyInterface)
        {
            Console.WriteLine("Variable can be converted to IMyInteface.");
        }
        else
            Console.WriteLine("Variable can't be converted to IMyInterface.");
        if (param1 is MyStruct)
        {
            Console.WriteLine("Variable can be converted to MyStruct.");
        }
        else
            Console.WriteLine("Variable can't be converted to MyStruct.");
    }
}
interface IMyInterface { }
class ClassA : IMyInterface { }
class ClassB : IMyInterface { }
class ClassC { }

class ClassD : ClassA { } 
struct MyStruct : IMyInterface { }
