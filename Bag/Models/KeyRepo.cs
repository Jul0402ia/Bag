using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace Bag.Models
{
    public class KeyRepo : IRepositoryD<int, Key>

    {
        private List<Key> keys = new List<Key>();
       // private Dictionary<int, Key> keys = new Dictionary<int, Key>();
        private int nextId = 1;

        
        public IEnumerable<Key> GetAll()
        {
            return keys;
        }
        
        public Key Add(Key key)
        {
            key.Id= nextId++;
            keys.Add(key);
            return key; 
        }
        public Key? GetById(int id)
        {
            return keys.FirstOrDefault(k => k.Id == id);
        }
        public Key? Remove(int id)
        {
            Key?key = GetById(id);
            if (key != null)
            {
                keys.Remove(key);
                return key;
            }
            return null;
        }
        public Key? Update (int id, Key key, Key updatedKeyData)
        {
            Key? existingKeyData = GetById(id);
            if (existingKeyData != null)
            {
                existingKeyData.Color = updatedKeyData.Color;
                existingKeyData.Size = updatedKeyData.Size;
                return existingKeyData;
            }
            return null;
        }

    }
}
