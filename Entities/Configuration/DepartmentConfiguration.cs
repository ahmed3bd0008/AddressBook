using Entities.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(new Department { DepartmentId = 1, DepartmentName = "School" },
             new { DepartmentId = 2, DepartmentName = "dev" },
          new { DepartmentId = 3, DepartmentName = "Hos" }
              );
        }
    }
}
