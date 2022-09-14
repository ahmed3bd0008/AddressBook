using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Modal
{
    public class AddressBook
    {
        [Key]
        public int Id { get; set; }
        public string FullName { set; get; }
        public string MobileNumber { set; get; }
        public string DateOfBirth { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public string Photo { set; get; }
        [ForeignKey(nameof(JobTitle))]
        public int JobId { get; set; }
        public Job JobTitle { set; get; }
        [ForeignKey(nameof(Department))]
        public int DepartmentId { set; get; }
        public Department Department { set; get; }
    }
}
