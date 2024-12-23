using System.Collections;
ArrayList names = new ArrayList();
names.Add("pikachu");
names.Add("bulbasaur");
names.Add("charmander");
names.Add("squirtle");

foreach (var poke in names)
{
    Console.WriteLine(poke);
}