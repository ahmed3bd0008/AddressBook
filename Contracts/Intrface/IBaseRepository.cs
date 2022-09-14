using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Intrface
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll(bool EnableTrackingChange);
        IQueryable<T> GetFilter( Expression<Func<T,bool>>expression , bool EnableTrackingChange);
        void Create(T Entity);
        void Delete(T Entity);
        void Update(T Entity);
    }
}
