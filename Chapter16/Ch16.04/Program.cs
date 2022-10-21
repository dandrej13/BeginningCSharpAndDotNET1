string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small",
"Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };
var queryResults = 
    names.Where(n => n.StartsWith("S")); 
Console.WriteLine("Names beginning with S:"); 
foreach (nvar item in queryResults)
{
    Console.WriteLine(item);
    Console.Write("Program finished, press Enter/Return to continue :");
}