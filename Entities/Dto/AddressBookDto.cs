using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class AddressBookDto
    {
        public int Id { get; set; }
        public string FullName { set; get; }
        public string MobileNumber { set; get; }
        public string DateOfBirth { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public string Photo { set; get; }
      
        public string Job { get; set; }
    
        public string Department { set; get; }
       
    }
    public class AddAddressBookDto
    {
       
        public string FullName { set; get; }
        public string MobileNumber { set; get; }
        public string DateOfBirth { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public string Photo { set; get; }

        public int JobId { get; set; }

        public int DepartmentId { set; get; }

    }
    public class UpdateAddressBookDto
    {
        public int Id { get; set; }
        public string FullName { set; get; }
        public string MobileNumber { set; get; }
        public string DateOfBirth { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public string Photo { set; get; }

        public int JobId { get; set; }

        public int DepartmentId { set; get; }

    }
}
