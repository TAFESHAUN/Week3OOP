//START
using Wk5APIE;

List<Antique> antiques = new List<Antique>();\


var necklace = new Jewellery(150,"poor",90.50, "The necklace is ornate. This necklace was found around the neck of Tutankhamun!", "Chain, Pearl", "Copper", true);
var watch = new Jewellery(75,"Good",250, "A simple military watch", "Analog", "Metal, Gold", false);

antiques.Add(necklace);
antiques.Add(watch);

Console.WriteLine("Welcome to class of 2025 Antiques Roadshow: \n");

foreach (var antique in antiques)
{
    antique.PrintDetails();
}

//END
Console.ReadKey();
