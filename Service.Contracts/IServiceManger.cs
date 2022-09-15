using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
  public  interface IServiceManger
    {
        public IJobService jobService { get; set; }
        public IDepartmentService departmentService    { get; set; }
    }
}
