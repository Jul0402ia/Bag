namespace Bag.Models
{
        public interface IRepositoryD<TKey, TEntity> where TEntity : class
        {
            void Add(TEntity entity);
            TEntity GetById(TKey id);
            IEnumerable<TEntity> GetAll();
            void Update(TKey id, TEntity entity);
            void Delete(TKey id);
        }
}
