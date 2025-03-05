namespace Wk5APIE
{
    public class Jewellery : Antique
    {
        public string Type { get; set; }
        public string Materials { get; set; }
        public bool HasGem { get; set; }
        public Jewellery(int age, string cond, double value, string desc, string type, string materials, bool hasGem) : base(age, cond, value, desc)
        {
            Type = type;
            Materials = materials;
            HasGem = hasGem;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Condition: {Condition}");
            Console.WriteLine($"Value: ${Value}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Materials: {Materials}");
            Console.WriteLine($"Has Gem: {HasGem} \n");
        }
    }
}
