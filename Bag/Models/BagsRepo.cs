namespace Bag.Models
{
    public class BagsRepo
    {
        private List<Bag> bags = new List<Bag>();

        private int nextId = 1;

        public IEnumerable<Bag> GetAll()
        {
            return bags;
        }
       
        public Bag Add(Bag bag)
        {
            bag.Id= nextId++;
            bags.Add(bag);
            return bag; 
        }
        public Bag? GetById(int id)
        {
            return bags.FirstOrDefault(b => b.Id == id);
        }

        public Bag? Delete(int id)
        {
            Bag?bag = GetById(id);
            if (bag != null)
            {
                bags.Remove(bag);
                return bag;
            }
            return null;
        }

        public Bag? Update (int id, Bag updatedBagData)
        {
            Bag? existingBagData = GetById(id);
            if (existingBagData != null)
            {
                existingBagData.Color = updatedBagData.Color;
                existingBagData.Size = updatedBagData.Size;
                return existingBagData;
            }
            return null;
        }


    }
}
