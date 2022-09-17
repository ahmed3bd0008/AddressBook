using AutoMapper;
using Contracts;
using Entities.Dto;
using Entities.Exceptions;
using Entities.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AddressBookService : IAddressBookService
    {
        private readonly IRepositoryManger _repositoryManger;
        private readonly IMapper _mapper;

        public AddressBookService(IRepositoryManger repositoryManger,IMapper mapper)
        {
            _repositoryManger = repositoryManger;
            _mapper = mapper;
        }
        public AddressBookDto Add(AddAddressBookDto addressBook)
        {
            try
            {
                var Isexist = _repositoryManger.AddressBookRepsitory.
              IsexistAddressBook(x => x.FullName.Trim() == addressBook.FullName.Trim() && x.JobId == addressBook.JobId && x.DepartmentId == addressBook.DepartmentId);
                if (Isexist) throw new NotFoundAddressBook(addressBook.FullName);
                var model = _mapper.Map<AddressBook>(addressBook);
                _repositoryManger.AddressBookRepsitory.CreateAddressBook(model);
                int res = _repositoryManger.Save();
                if (res <= 0) throw new NotFoundAddressBook();
                AddressBookDto addressBookDto = _mapper.Map<AddressBookDto>(model);
                return addressBookDto;
            }
            catch (Exception x)
            {

                 throw new NotFoundAddressBook();
            }
          

        }

        public int  Delete(int Id)
        {
            var modal = _repositoryManger.AddressBookRepsitory.GetAddressBookModalById(Id, true);
            if (modal is null) throw new NotFoundAddressBook(Id);
             _repositoryManger.AddressBookRepsitory.DeleteAddressBook(modal);
              int res=   _repositoryManger.Save();
            if (res <= 0) throw new NotFoundAddressBook();
            return res;

        }

        public IEnumerable<AddressBookDto> GetAddressBooks(bool EnableTracking)
        {
            return _repositoryManger.AddressBookRepsitory.GetAddressBookAll(EnableTracking);
        }

        public AddressBookDto GetAddressBooksById(int Id, bool EnableTracking)
        {
            return _repositoryManger.AddressBookRepsitory.GetAddressBookDtoById(Id, false);
        }

        public IEnumerable<AddressBookDto> GetAddressBooksByName(string Name, bool EnableTracking)
        {
            throw new NotImplementedException();
        }

        public AddressBookDto Update(UpdateAddressBookDto addressBook)
        {
            try
            {
                var modal = _repositoryManger.AddressBookRepsitory.GetAddressBookModalById(addressBook.Id, false);
                if (modal is null) throw new NotFoundAddressBook(addressBook.FullName);
                _mapper.Map(addressBook, modal);
                int res = _repositoryManger.Save();
                if (res <= 0) throw new NotFoundAddressBook();
                var addressBookDto = _mapper.Map<AddressBookDto>(modal);
                return addressBookDto;
            }
            catch (Exception ex)
            {

                throw new NotFoundAddressBook(ex.Message);
            }
            
           
        }
    }
}
