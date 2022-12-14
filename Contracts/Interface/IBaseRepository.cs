using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll(bool EnableTrackingChange);
        IQueryable<T> GetFilter( Expression<Func<T,bool>>expression , bool EnableTrackingChange);
        bool IsExist( Expression<Func<T,bool>>expression );
        void Create(T Entity);
        void Delete(T Entity);
        void Update(T Entity);
    }
}
