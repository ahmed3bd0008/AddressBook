using Entities.Dto;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IDepartmentService
    {

        public IEnumerable<DepartmentDto> GetDepartments(bool EnableTracking);
        public IEnumerable<DepartmentDto> GetDepartmentsByName(string Name, bool EnableTracking);
        DepartmentDto GetDepartmentsById(int Id, bool EnableTracking);
        void Delete(int Id);
        int Update(DepartmentDto Department);
        int Add(DepartmentDto Department);
    }
}
