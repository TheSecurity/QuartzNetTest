using System;
using System.Linq.Expressions;

namespace QuartzNetTest.Core.Database
{
    public interface IDatabase<T>
    {
        void Create(T data);
        T Get(Expression<Func<T, bool>> filter);
        void Update(Expression<Func<T, bool>> filter, T data);
        void Delete(T data);
    }
}