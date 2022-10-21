using _16_04_QueryPersonObject;
List<Person> people = new List<Person>()
{
    new Person() {FirstName = "Alonso", LastName = "Sherman", Age =23},
    new Person() {FirstName = "Smith", LastName = "Howells", Age =16},
    new Person() {FirstName = "Smythe", LastName = "Warner", Age =32},
    new Person() {FirstName = "Ilyich", LastName = "King", Age =64},
    new Person() {FirstName = "Jones", LastName = "Bright", Age =26},
    new Person() {FirstName = "Smith", LastName = "Walton", Age =45},
    new Person() {FirstName = "Samba", LastName = "Warren", Age =25},
    new Person() {FirstName = "Singh", LastName = "Flynn", Age =18},
    new Person() {FirstName = "Fatimah", LastName = "Torres", Age =10},
    new Person() {FirstName = "Zhneg", LastName = "Chen", Age =53},
    new Person() {FirstName = "Ruiz", LastName = "Flowers", Age =33},
    new Person() {FirstName = "Jorgenson", LastName = "Frank", Age =37},
    new Person() {FirstName = "Hsieh", LastName = "Howwels", Age =21}
};

//LINQ query syntax
var lNameSelector =
    from lN in people
    where lN.LastName.StartsWith("F")
    select lN.LastName;

foreach (var item in lNameSelector)
{
    Console.WriteLine(item);
};

//LINQ method syntax

var methodResult = people.Where(x => x.LastName.StartsWith("F"));
foreach (var item in methodResult)
{
    Console.WriteLine(item.LastName);
}

//LINQ syntax for filtering age that is higer or equal than 21

var ageSelector =
    from age in people
    where age.Age >= 21
    select age.Age;

foreach (var item in ageSelector)
{
    Console.WriteLine(item);
}

var ageMethod = people.Where(x => x.Age >= 21);
foreach (var item in ageMethod)
{
    Console.WriteLine(item.Age);
}