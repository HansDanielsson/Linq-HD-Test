// See https://aka.ms/new-console-template for more information
string[] cities = { "Boston", "Los Engeles", "Seattle", "London", "Hyderabad" };

Console.WriteLine(cities.Length);
IEnumerable<string> fileredList = cities.Where((string s) =>
{
  return s.ToLower().StartsWith("l");
});

Console.WriteLine("Nu kommer listan:");
foreach (var Item in fileredList)
{
  Console.WriteLine(Item);
}
Console.WriteLine(fileredList.Count());