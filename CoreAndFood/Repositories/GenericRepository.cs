using CoreAndFood.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CoreAndFood.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        Context context = new();

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id = 0)
        {
            var result = context.Set<T>().Find(id);
            context.Set<T>().Remove(result);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }

        public T GetById(int id = 0)
        {
            return context.Set<T>().Find(id);
        }
        public List<T> Include(string table)
        {
            return context.Set<T>().Include(table).ToList();
        }

        public List<T> FilterList(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().Where(filter).ToList();
        }
    }
}
