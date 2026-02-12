namespace Bag.Models
{
    public class Notebook
    {
        public int Id { get; set; }
        public string? Color { get; set; }

        public override string ToString()
        {
            return $"Notebook(Id={Id}, Color={Color})";
        }
    }
}
