using Contracts.Interface;
using Entities;
using Entities.Dto;
using Entities.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public IEnumerable<AddressBookDto> GetAddressBookAll(bool EnableTrackingChange)
        {
            var mm= GetAll(EnableTrackingChange).Select(x=>new AddressBookDto()
            {FullName=x.FullName,Address=x.Address,Email=x.Email,DateOfBirth=x.DateOfBirth,Photo=x.Photo ,
                Id=x.Id,Job=x.JobTitle.JobName,Department=x.Department.DepartmentName,MobileNumber=x.MobileNumber}).
                ToList();
            return mm;
        }

       
     

        public IEnumerable<AddressBookDto> GetAddressBookByName(string Name, bool EnableTrackingChange)
        {
            return GetFilter(x => x.FullName.Contains(Name), EnableTrackingChange).
                Select(x => new AddressBookDto()
          { FullName = x.FullName, Address = x.Address, Email = x.Email, DateOfBirth = x.DateOfBirth, Photo = x.Photo }).ToList();
        }

        public bool IsexistAddressBook(Expression<Func<AddressBook, bool>> expression)
        {
          return IsExist(expression);
        }

        public void UpdateAddressBook(AddressBook addressBook)
        {
            Update(addressBook);
        }

        AddressBookDto IAddressBookRepsitory.GetAddressBookDtoById(int Id, bool EnableTrackingChange)
        {
            return GetFilter(x => x.Id == Id, EnableTrackingChange).Select(x => new AddressBookDto() { FullName = x.FullName, Address = x.Address, Email = x.Email, DateOfBirth = x.DateOfBirth, Photo = x.Photo }).FirstOrDefault();

        }

        AddressBook IAddressBookRepsitory.GetAddressBookModalById(int Id, bool EnableTrackingChange)
        {
            return GetFilter(x => x.Id == Id, EnableTrackingChange)

                 .FirstOrDefault();
        }
    }
}
