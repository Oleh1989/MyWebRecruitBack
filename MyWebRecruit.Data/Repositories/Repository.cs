using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyWebRecruit.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyWebRecruit.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IIdentified, IDeletable
    {
        protected readonly MyWebRecruitDataBaseContext _dbContext;

        public Repository(MyWebRecruitDataBaseContext dbContext) => _dbContext = dbContext;

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>()
                .Where(x => !x.IsDeleted);
        }

        public TEntity GetById(int id)
        {
            TEntity entity = _dbContext.Set<TEntity>()
                .Find(id);
            return !entity.IsDeleted ? entity : null;
        }

        public int Add(TEntity entity)
        {
            _dbContext.Add(entity);
            return entity.Id;
        }

        public void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            TEntity entity = _dbContext.Set<TEntity>().Find(id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _dbContext.Entry(entity).State = EntityState.Modified;
            }
        }

        
    }
}
