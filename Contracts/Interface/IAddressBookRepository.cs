using Entities.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
    public interface IAddressBookRepsitory
    {
        IEnumerable<AddressBook> GetAddressBookAll(bool EnableTrackingChange);
        IEnumerable<AddressBook> GetAddressBookByName(string Name, bool EnableTrackingChange);
        AddressBook GetAddressBookById(int Id, bool EnableTrackingChange);
        void CreateAddressBook(AddressBook addressBook);
        void DeleteAddressBook(AddressBook addressBook);
        void UpdateAddressBook(AddressBook addressBook);
    }
}
