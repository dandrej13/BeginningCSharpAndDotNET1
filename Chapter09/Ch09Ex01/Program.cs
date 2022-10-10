static void main()
{
    MyComplexClass myObj = new MyComplexClass();
    Console.WriteLine(myObj.ToString());
    Console.ReadKey();
}

public abstract class MyBase{ }
internal class MyClass : MyBase{ }

public interface IMyBaseInterface { }

internal interface IMyBaseInterface2 { }

internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2 { }

internal sealed class MyComplexClass : MyClass, IMyInterface { };

