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
    public class AddressBookConfiguration : IEntityTypeConfiguration<AddressBook>
    {
        public void Configure(EntityTypeBuilder<AddressBook> builder)
        {
            builder.HasData(
                new AddressBook() { Id=1,FullName="Ahmed",DepartmentId=1,JobId=1,Email="Ahmed@gmail.com",MobileNumber="01159510495",Photo=""},
                new AddressBook() { Id=2,FullName="Mohamed",DepartmentId=2,JobId=2,Email= "Mohamed@gmail.com", MobileNumber="01159510495",Photo=""},
                new AddressBook() { Id=3,FullName="Ali",DepartmentId=3,JobId=3,Email= "Ali@gmail.com", MobileNumber="01159510495",Photo=""},
                );
        }
    }
}
