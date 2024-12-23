using System.Collections;

List<string> names = new List<string>();
names.Add("pikachu");
names.Add("bulbasaur");
names.Add("charmander");
names.Add("squirtle");

foreach (var poke in names)
{
    Console.WriteLine(poke);
}