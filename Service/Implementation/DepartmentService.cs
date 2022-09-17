using AutoMapper;
using Contracts;
using Entities.Dto;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DepartmentService: IDepartmentService
    {

        public DepartmentService(IRepositoryManger repositoryManger, IMapper mapper)
        {

        }

        public int Add(DepartmentDto Department)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DepartmentDto> GetDepartments(bool EnableTracking)
        {
            throw new NotImplementedException();
        }

        public DepartmentDto GetDepartmentsById(int Id, bool EnableTracking)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DepartmentDto> GetDepartmentsByName(string Name, bool EnableTracking)
        {
            throw new NotImplementedException();
        }

        public int Update(DepartmentDto Department)
        {
            throw new NotImplementedException();
        }
    }
}
