﻿using Core.Entities.Abstract;
using System.Linq.Expressions;

namespace Core.DataAccess
{   //generic constraint
    //class --> referance type
    //IEntity --> IEntity or class implements from IEntity 
    //new() --> must be newable(IEntity cannot be renewed)
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
