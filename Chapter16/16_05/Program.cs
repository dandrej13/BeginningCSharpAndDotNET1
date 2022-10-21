string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small",
"Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };
Console.WriteLine("Names beginning with S ordered alphabetically:");

var orderNames =
    from n in names
    where n.StartsWith("S")
    orderby n
    select n;

foreach (var item in orderNames)
{
    Console.WriteLine(item);

}

Console.WriteLine("\n\n\n");
var methodOrderNames = names.Where(x => x.StartsWith("S")).OrderBy(x => x.Length);


foreach (var item in methodOrderNames)
{
    Console.WriteLine(item);

}
