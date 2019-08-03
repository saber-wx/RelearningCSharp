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

        public void Delete(T entity)
        {
            entities.Remove(entity);
            Flush();
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

        public IQueryable<T> Get(int id)
        {
            return entities.Where(u => u.Id == id);
        }
        
        public IQueryable<T> Get()
        {
            return entities;
        }

        public IQueryable<T> Paged(IQueryable<T> entities, int pageIndex, int pageSize)
        {
            return entities
            .Skip((pageIndex) * pageSize)
            .Take(pageSize);
        }
    }
}
