using Ch11Ex05;
using System.Collections;

ArrayList list = new ArrayList();
list.Add(new Person("Rual", 30));
list.Add(new Person("Donna", 25));
list.Add(new Person("marry", 27));
list.Add(new Person("Ben", 44));
Console.WriteLine("Unsorted people");

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"{((Person)list[i]).Name} ({((Person)list[i]).Age})");
}
Console.WriteLine();
Console.WriteLine("People sorted with default comparer (by age):");
list.Sort();
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"{((Person)list[i]).Name} ({((Person)list[i]).Age})");
}
Console.WriteLine();
Console.WriteLine("People sorted with nondefault comparer (by name):");
list.Sort(PersonNameComparer.Default);
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"{((Person)list[i]).Name} ({((Person)list[i]).Age})");
}
Console.ReadKey();


public class Person : IComparable
{
    public string Name;
    public int Age;
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public int CompareTo(object obj)
    {
        if (obj is Person)
        {
            Person otherPerson = obj as Person;
            return this.Age - otherPerson.Age;
        }
        else
        {
            throw new ArgumentException(
                "Object to compare to is not a Person object");
        }
    }
}
