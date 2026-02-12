namespace Bag.Models
{
    public class Bag
    {
        public int Id { get; set; } 
        public string? Color { get; set; }
        public int Size { get; set; }

        public override string ToString()
        {
            return $"Bag(Id={Id}, Color={Color}, Size={Size})";
        }
    }
}
