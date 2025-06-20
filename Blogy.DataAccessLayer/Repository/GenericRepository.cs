﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.Context;

namespace Blogy.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly BlogyContext _context;
        public void Delete(int id)
        {
            var values = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(values);
            _context.SaveChanges();
            
        }

        public T GetbyId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
           return _context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
           _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
