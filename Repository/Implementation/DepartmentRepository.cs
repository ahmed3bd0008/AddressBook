using Contracts.Interface;
using Entities;
using Entities.Modal;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
   public class DepartmentRepository:BaseRepository<Department>,IDepartmentRepository
    {
        private readonly RepoDbContext _context;


        public DepartmentRepository(RepoDbContext repoDbContext) : base(repoDbContext)
        {
            _context = repoDbContext;
        }
        public void CreateDepartment(Department Department)
        {
            Create(Department);
        }

        public void DeleteDepartment(Department Department)
        {
            Delete(Department);
        }



        public Department GetDepartmentById(int Id, bool EnableTrackingChange)
        {
            return GetFilter(x => x.DepartmentId == Id, EnableTrackingChange).FirstOrDefault();
        }

       
        public void UpdateDepartment(Department Department)
        {
            Update(Department);
        }

        IEnumerable<DepartmentDto> IDepartmentRepository.GetDepartmentAll(bool EnableTrackingChange)
        {
            return GetAll(EnableTrackingChange).
                Select(x=>new DepartmentDto() {DepartmentName=x.DepartmentName,DepartmentId=x.DepartmentId } ).
                ToList();
        }

        IEnumerable<DepartmentDto> IDepartmentRepository.GetDepartmentByName(string Name, bool EnableTrackingChange)
        {
            return GetFilter(x => x.DepartmentName.Contains(Name), EnableTrackingChange).
                Select(x => new DepartmentDto() { DepartmentName = x.DepartmentName, DepartmentId = x.DepartmentId }).
                ToList();
        }
    }
}
