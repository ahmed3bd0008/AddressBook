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
   public class AddressBookRepository: BaseRepository<AddressBook>,IAddressBookRepsitory
    {
        private readonly RepoDbContext _context;

        public AddressBookRepository(RepoDbContext repoDbContext ) :base(repoDbContext)
        {
            _context = repoDbContext;
        }

        public void CreateAddressBook(AddressBook addressBook)
        {
            Create(addressBook);
        }

        public void DeleteAddressBook(AddressBook addressBook)
        {
            Delete(addressBook);
        }

        public IEnumerable<AddressBook> GetAddressBookAll(bool EnableTrackingChange)
        {
            return GetAll(EnableTrackingChange).ToList();
        }

        public AddressBook GetAddressBookById(int Id, bool EnableTrackingChange)
        {
            return GetFilter(x => x.Id == Id, EnableTrackingChange).FirstOrDefault();
        }

        public IEnumerable<AddressBook> GetAddressBookByName(string Name, bool EnableTrackingChange)
        {
            return GetFilter(x => x.FullName.Contains(Name), EnableTrackingChange).ToList();
        }

        public void UpdateAddressBook(AddressBook addressBook)
        {
            Update(addressBook);
        }
    }
}
