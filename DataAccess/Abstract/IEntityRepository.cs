using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        //GENERIC REPOSITORY  
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter = null); //tek bir şeyin detayı için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
