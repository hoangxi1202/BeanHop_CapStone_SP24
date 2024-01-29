using BeanHop.Database.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BeanHop.Bussiness.Repository
{
    public abstract class RepositoryBase<T> where T : class
    {
        private readonly BeanHopDBContext _dbContext;
        public DbSet<T> Data;

        public RepositoryBase(BeanHopDBContext dbContext)
        {
            _dbContext = dbContext;
            Data = _dbContext.Set<T>();
        }

        public IQueryable<T> GetAll() => Data.AsQueryable();

        public T Get(int id) =>  Data.Find(id);

        public void Create(T entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbContext.Remove(entity);
             _dbContext.SaveChanges();
        }
    }
}