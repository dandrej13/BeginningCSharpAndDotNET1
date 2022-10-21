string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe",
"Small", "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };
    var queryResults =
    from n in names
    where n.StartsWith("S")
    select n;
    
Console.WriteLine("Names beginning with S:"); foreach (var item in queryResults)
{
    Console.WriteLine(item);
}
    Console.Write("Program finished, press Enter/Return to continue:");