namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chicken chicken = new Chicken("Poe", 4);
            chicken.Age++;
            chicken.EatFood();
            chicken.Cluck();

            chicken = new Chicken();
            chicken.Name = "Alan";
            chicken.Age = 1;
            chicken.EatFood();
            chicken.Cluck();

            Cow cow = new Cow("Milka", 12);
            cow.Breed();
            cow.SupplyMilk();
            cow.Moo();

            Animal newChicken = new Chicken("Iva", 2);
            newChicken.EatFood();

            IAnimal newChickenInt = new Chicken();
            newChickenInt.Age = 2;
            newChickenInt.Name = "Sero";

            newChickenInt.EatFood();


        }
    }
}
