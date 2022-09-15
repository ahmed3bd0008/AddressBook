
using Contracts.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManger
    {
        public IJobRepository JobRepository { get;  }
        public IDepartmentRepository DepartmentRepository { get;  }
        public IAddressBookRepsitory AddressBookRepsitory { get; }

    }
}
