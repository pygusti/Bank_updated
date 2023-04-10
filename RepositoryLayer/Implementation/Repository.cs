using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Implementation
{
    public class Repository<T>:IRepository<T> where T:class
    {

        private readonly MyDbContext _context;
        private DbSet<T> _dbSet=null;
      
        public Repository(MyDbContext myDbContext) { 
        _context = myDbContext;
        _dbSet = _context.Set<T>();
        }

      

        public async Task<IEnumerable<T>> Get()
    {
        return await _dbSet.ToListAsync();

    }

        public void Insert(T obj)
        {
            _dbSet.Add(obj);
        }
        public void Update(T obj)
        {
            _dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = (T)_context.Find((Type)id);
            _dbSet.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }

       
    }
}
