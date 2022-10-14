using Ch11Ex01;
using System.Collections;

Console.WriteLine("Create an array type collection of " +
    "Animal objects and use it");
//Animal[] animalArray = new Animal[2];
//Cow myCow1 = new Cow("Lea");
//animalArray[0] = myCow1;
//animalArray[1] = new Chicken("Noa");

//foreach (Animal myAnimal in animalArray)
//{
//    Console.WriteLine($"New {myAnimal} object added to array" +
//        $"collection, Name = {myAnimal.Name}");
//}
//Console.WriteLine($"Array collection contains {animalArray.Length} objects");
//animalArray[0].Feed();
//((Chicken)animalArray[1]).LayEgg();
//Console.WriteLine();
Console.WriteLine("Create an ArrayList type collection of Animal" +
    "objects and use it:");
//ArrayList animalArrayList = new ArrayList();
//Cow myCow2 = new Cow("Donna");
//animalArrayList.Add(myCow2);
//animalArrayList.Add(new Chicken("Andrea"));
//foreach (Animal myAnimal in animalArrayList)
//{
//    Console.WriteLine($"New {myAnimal} object added to arrayList" +
//        $"collection , Name = {myAnimal.Name}");
//}
//Console.WriteLine($"ArrayList collection contains {animalArrayList.Count} objects");
//((Animal)animalArrayList[0]).Feed();


Animal[] myAnimalArray = new Animal[2];
Cow myCow1 = new Cow("Sara");
myAnimalArray[0] = myCow1;
myAnimalArray[1] = new Cow("Lea");

foreach (Animal myAnimal in myAnimalArray)
{
    Console.WriteLine($"{myAnimal} has been created. The name is {myAnimal.Name}");
}
myCow1.Feed();
myAnimalArray[1].Feed();
Console.WriteLine($"The lenght of the array is {myAnimalArray.Length}");

ArrayList myAnimalArrayList = new ArrayList();
Chicken myChicken = new Chicken("Poe");
myAnimalArrayList.Add(myChicken);
myAnimalArrayList.Add(new Cow("stevo"));

foreach (Animal myAnimal in myAnimalArrayList)
{
    Console.WriteLine($"{myAnimal} created in Array List. Name is : {myAnimal.Name}");
    myAnimal.Feed();

}

Console.WriteLine($"The lenght of myArrayList is {myAnimalArrayList.Count}");

myChicken.LayEgg();
myCow1.Milk();


Console.WriteLine("Additional manipulation of ArrayList: ");
myAnimalArrayList.RemoveAt(0);
((Animal)myAnimalArrayList[0]).Feed();
myAnimalArrayList.AddRange(myAnimalArray);
((Animal)myAnimalArrayList[0]).Feed();
myAnimalArrayList.AddRange(myAnimalArray);
((Cow)myAnimalArrayList[2]).Milk();
Console.WriteLine($"{myCow1.Name} is at index {myAnimalArrayList.IndexOf(myCow1)}");
((Animal)myAnimalArrayList[0]).Name = "Marry";
Console.WriteLine($"The cow is now called {((Animal)myAnimalArrayList[0]).Name}");