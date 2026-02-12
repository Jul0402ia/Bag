namespace Bag.Models
{
    //Get GetById Add Delete Update
    public interface Repository<T>

    {
public IEnumerable<T> GetAll(); 
        public T? GetById(int id);
        public T Add(T t);
        public T? Remove(int id);
        public T? Update(int id, T t, T updatedItemData);
    }
}
