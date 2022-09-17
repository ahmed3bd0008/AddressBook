using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IAddressBookService
    {
        public IEnumerable<AddressBookDto> GetAddressBooks(bool EnableTracking);
        public IEnumerable<AddressBookDto> GetAddressBooksByName(string Name,bool EnableTracking);
       AddressBookDto GetAddressBooksById(int Id,bool EnableTracking);
        int Delete (int Id);
        AddressBookDto Update (UpdateAddressBookDto addressBook);
        AddressBookDto Add (AddAddressBookDto addressBook);
    }
}
