using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Repositorys<T> where T :class
    {
        public Repositorys()
        {
            CurrentContext = new SQLContext();
            entities = CurrentContext.Set<T>();
        }

        public SQLContext CurrentContext { get; set; }
        protected DbSet<T> entities { get; set; }

        public void Flush()
        {
            CurrentContext.SaveChanges();
        }

        public T Save(T entity)
        {
            entities.Add(entity);

            //必须要SaveChanges()
            CurrentContext.SaveChanges();

            return entity;
        }

        public T Get(int id)
        {
            return entities.Single(u => u.Id == id);
        }
    }
}
