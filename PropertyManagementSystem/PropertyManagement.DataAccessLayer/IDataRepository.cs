using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.DataAccessLayer
{
    public interface IDataRepository<T>
    {
        IList<T> GetAllList(params Expression<Func<T, object>>[] expressions);
        IList<T> GetSelectedList(Func<T, bool> where, params Expression<Func<T, object>>[] expressions);

        T GetSingle(Func<T,bool> where, params Expression<Func<T,object>>[] expressions);

        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);



    }
}
