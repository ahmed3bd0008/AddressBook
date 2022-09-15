using Contracts.Interface;
using Entities;
using Entities.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
   public class AddressBookRepository: BaseRepository<ِAddressBook>,IAddressBookRepsitory
    {
        private readonly RepoDbContext _context;

        public AddressBookRepository(RepoDbContext repoDbContext ) :base(repoDbContext)
        {
            _context = repoDbContext;
        }
    }
}
