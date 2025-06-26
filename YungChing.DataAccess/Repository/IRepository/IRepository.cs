using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace YungChing.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // This interface defines the basic CRUD operations for a repository pattern.
        // Update 較難統一實作 需要個別Class自行實作

        IEnumerable<T> GetAll();

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);
    }
}
