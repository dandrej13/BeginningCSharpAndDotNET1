using Ch11Ex02;

AnimalCollection animalCollection = new();
animalCollection.Add(new Chicken("Donna"));
animalCollection.Add(new Cow("Marry"));

foreach (Animal animal in animalCollection)
{
    animal.Feed();
}

animalCollection[1] = new Chicken("Noah");

foreach (Animal animal in animalCollection)
{
    animal.Feed();
}

((Chicken)animalCollection[0]).LayEgg();

Chicken donna = ((Chicken)animalCollection[0]);
donna.LayEgg();