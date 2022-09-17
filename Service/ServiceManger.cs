using AutoMapper;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ServiceManger : IServiceManger
    {
        private readonly IRepositoryManger _RepositoryManger;
        private readonly IMapper _mapper;
        private Lazy<IAddressBookService> _addressBookService;
        private Lazy<IJobService> _jobService;
        private Lazy<IDepartmentService> _departmentService;
        public ServiceManger(IRepositoryManger repositoryManger,IMapper mapper )
        {
            _RepositoryManger = repositoryManger;
            _mapper = mapper;
            _addressBookService = new Lazy<IAddressBookService>(() => new AddressBookService(_RepositoryManger, _mapper));
            _jobService = new Lazy<IJobService>(() => new JobService(_RepositoryManger, _mapper));
            _departmentService = new Lazy<IDepartmentService>(() => new DepartmentService(_RepositoryManger, _mapper));
        }
        public IAddressBookService addressBookService => _addressBookService.Value;

        public IJobService jobService => throw new NotImplementedException();

        public IDepartmentService departmentService => throw new NotImplementedException();

       
    }
}
