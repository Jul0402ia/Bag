using System;
using System.Collections.Generic;
using System.Linq;
using Bag.Models;

public class PenRepo<TKey, TEntity> : IRepositoryD<TKey, TEntity>
    where TEntity : class
{
    // Dictionary gemmer data: Key = Id, Value = Objektet
    private readonly Dictionary<TKey, TEntity> _storage = new Dictionary<TKey, TEntity>();

    // Func til at udtrække Id fra entiteten
    private readonly Func<TEntity, TKey> _keySelector;

    public PenRepo(Func<TEntity, TKey> keySelector)
    {
        _keySelector = keySelector;
    }

    public void Add(TEntity entity)
    {
        TKey key = _keySelector(entity);
        if (_storage.ContainsKey(key))
        {
            throw new ArgumentException("En entitet med dette ID eksisterer allerede.");
        }
        _storage.Add(key, entity);
    }

    public TEntity GetById(TKey id)
    {
        if (id != null)
        {
            _storage.TryGetValue(id, out TEntity? entity);
            return entity; 
        }
        return null; 
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _storage.Values.ToList();
    }

    public void Update(TKey id, TEntity entity)
    {
        if (_storage.ContainsKey(id))
        {
            _storage[id] = entity;
        }
    }

    public void Delete(TKey id)
    {
        if (_storage.ContainsKey(id))
        {
            _storage.Remove(id);
        }
    }
}

