using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Modal
{
 public   class Job
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public ICollection<AddressBook> AddressBooks { get; set; }
    }
}
