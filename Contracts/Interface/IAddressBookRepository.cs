using Entities.Dto;
using Entities.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
    public interface IAddressBookRepsitory
    {
        IEnumerable<AddressBookDto> GetAddressBookAll(bool EnableTrackingChange);
        IEnumerable<AddressBookDto> GetAddressBookByName(string Name, bool EnableTrackingChange);
        AddressBookDto GetAddressBookDtoById(int Id, bool EnableTrackingChange);
        AddressBook GetAddressBookModalById(int Id, bool EnableTrackingChange);
        void CreateAddressBook(AddressBook addressBook);
        void DeleteAddressBook(AddressBook addressBook);
        void UpdateAddressBook(AddressBook addressBook);
        bool IsexistAddressBook(Expression<Func<AddressBook,bool>>expression );
    }
}
