using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public interface IEntityRepository<T> where T:class,new()
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
