using Contracts;
using Contracts.Interface;
using Entities;
using Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManger : IRepositoryManger
    {
        private readonly RepoDbContext _context;
        private Lazy< IJobRepository >_jobRepository;
        private Lazy< IDepartmentRepository> _departmentRepository;
        private Lazy<IAddressBookRepsitory>_addressBookRepsitory;

        public RepositoryManger(RepoDbContext repoDbContext)
        {
            _context = repoDbContext;
            _addressBookRepsitory = new Lazy<IAddressBookRepsitory>(() => new AddressBookRepository(_context));
            _departmentRepository = new Lazy<IDepartmentRepository>(() => new DepartmentRepository(_context));
            _jobRepository = new Lazy<IJobRepository>(() => new JobRepository(_context));
        }

        public IJobRepository JobRepository { get => _jobRepository.Value; }
        public IDepartmentRepository DepartmentRepository { get => _departmentRepository.Value; }
        public IAddressBookRepsitory AddressBookRepsitory { get => _addressBookRepsitory.Value; }
        
    }
}
