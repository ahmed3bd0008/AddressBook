using Entities.Modal;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
   public interface IDepartmentRepository
    {
        IEnumerable<DepartmentDto> GetDepartmentAll(bool EnableTrackingChange);
        IEnumerable<DepartmentDto> GetDepartmentByName(string Name, bool EnableTrackingChange);
        Department GetDepartmentById(int Id, bool EnableTrackingChange);
        void CreateDepartment(Department DepartmentDto);
        void DeleteDepartment(Department DepartmentDto);
        void UpdateDepartment(Department DepartmentDto);
    }
}
