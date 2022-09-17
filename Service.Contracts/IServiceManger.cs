using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
  public  interface IServiceManger
    {
        public IAddressBookService addressBookService  { get; }
        public IJobService jobService { get;  }
        public IDepartmentService departmentService    { get;  }
    }
}
