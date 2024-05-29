using MyWebRecruit.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class, IIdentified, IDeletable
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        int Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
