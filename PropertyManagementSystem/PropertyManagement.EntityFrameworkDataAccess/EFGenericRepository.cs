using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PropertyManagement.DataAccessLayer;

namespace PropertyManagement.EntityFrameworkDataAccess
{
    public class EFGenericRepository<T> : IDataRepository<T> where T : class
    {
        private PropertyManagementContext _context;

        public EFGenericRepository(bool createProxy = true)
        {
            _context = new PropertyManagementContext(createProxy);
        }

        public T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] expressions)
        {
            IQueryable<T> _dbQuery = _context.Set<T>();

            foreach (var expression in expressions)
            {
                _dbQuery = _dbQuery.Include<T, object>(expression);
            }

            return _dbQuery.FirstOrDefault(where);
        }

        public IList<T> GetSelectedList(Func<T, bool> where, params Expression<Func<T, object>>[] expressions)
        {
            IQueryable<T> _dbQuery = _context.Set<T>();
            foreach (var expression in expressions)
            {
                _dbQuery = _dbQuery.Include<T, object>(expression);
            }

            return _dbQuery.Where(where).ToList<T>();
        }

        public IList<T> GetAllList(params Expression<Func<T, object>>[] expressions)
        {
            IQueryable<T> _dbQuery = _context.Set<T>();
            foreach(var expression in expressions)
            {
                _dbQuery = _dbQuery.Include<T, object>(expression);
            }

            return _dbQuery.ToList<T>();
        }

        public void Add(params T[] items)
        {
            foreach (var item in items)
            {
                _context.Entry(item).State = EntityState.Added;
            }
            _context.SaveChanges();
        }

        public void Remove(params T[] items)
        {
            foreach(T item in items)
            {
                _context.Entry(item).State = EntityState.Deleted;
            }

            _context.SaveChanges();
        }

        public void Update(params T[] items)
        {
            foreach(T item in items)
            {
                _context.Entry(item).State = EntityState.Modified;
            }
            _context.SaveChanges();
        }
    }
}
