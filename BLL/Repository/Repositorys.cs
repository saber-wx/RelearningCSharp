using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Repositorys<T> where T : Entity
    {
        public DbContext _dbContext;
        public Repositorys(DbContext context)
        {
            _dbContext = context;
            entities = _dbContext.Set<T>();
        }

        public DbSet<T> entities { get; set; }

        public void SetEntities(SQLContext context)
        {
            _dbContext = context;
            entities = _dbContext.Set<T>();
        }


        public void Flush()
        {
            _dbContext.SaveChanges();
        }

        public T Save(T entity)
        {
            entities.Add(entity);

            //必须要SaveChanges()
            _dbContext.SaveChanges();

            return entity;
        }

        public T Get(int id)
        {
            return entities.Single(u => u.Id == id);
        }

        public IList<T> Paged(IList<T> entities, int pageIndex, int pageSize)
        {
            return entities
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToList();
        }
    }
}
