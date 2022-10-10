using static System.Console;

namespace Objects
{
    public class Chicken:Animal
    {

        public Chicken() : base()
        {

        }

        public Chicken(string Name, int Age) : base (Name, Age)
        {

        }

        public void Cluck()
        {
            WriteLine($"{Name} is clucking");
        }

        public void LayEgg()
        {
            WriteLine($"{Name} is laying eggs");
        }
    }
}
