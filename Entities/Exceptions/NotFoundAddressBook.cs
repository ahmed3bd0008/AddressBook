using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class NotFoundAddressBook : NotFoundException
    {
        public NotFoundAddressBook(int AddressBook) : base($"The AddressBook with id: {AddressBook} doesn't exist in the database.")
        {
        }
        public NotFoundAddressBook(string AddressBook) : base($"The AddressBook with Name: {AddressBook} has exist in data base")
        {

        }
        public NotFoundAddressBook() : base($"Error when save")
        {

        }
    }
}
