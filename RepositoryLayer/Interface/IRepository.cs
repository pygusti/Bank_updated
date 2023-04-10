using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
    public interface IRepository<T> where T: class
    {
        public Task<IEnumerable<T>> Get();
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();

    }
}
