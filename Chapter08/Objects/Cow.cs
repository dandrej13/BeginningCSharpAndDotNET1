using static System.Console;

namespace Objects
{
    public class Cow : Animal 
    {


        public Cow() : base()
        {

        }

        public Cow(string Name, int Age) : base(Name, Age)
        {

        }
        public void Moo()
        {
            WriteLine($"{Name} is Mooing");
        }

        public void LayEgg()
        {
            WriteLine($"{Name} is laying eggs");
        }

        public void SupplyMilk()
        {
            WriteLine($"{Name} is supplying milk!");
        }
    }
}
