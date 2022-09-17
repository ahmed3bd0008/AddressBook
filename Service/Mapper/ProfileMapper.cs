using AutoMapper;
using Entities.Dto;
using Entities.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapper
{
  public  class ProfileMapper:Profile
    {
        public ProfileMapper()
        {
            CreateMap<AddressBook, AddressBookDto>().
                ForMember(x => x.FullName, d => d.MapFrom(y => y.FullName)).
                ForMember(x => x.DateOfBirth, d => d.MapFrom(y => y.DateOfBirth)).
                ForMember(x => x.Id, d => d.MapFrom(y => y.Id)).
                ForMember(x => x.MobileNumber, d => d.MapFrom(y => y.MobileNumber)).
                ForMember(x => x.Photo, d => d.MapFrom(y => y.Photo)).
                ForMember(x=>x.Job,d=>d.MapFrom(y=>y.JobTitle.JobName)).
                ForMember(x=>x.Department,d=>d.MapFrom(y=>y.Department.DepartmentName)).
                ReverseMap();
            CreateMap<AddressBook, AddAddressBookDto>().ReverseMap();
            CreateMap<AddressBook, UpdateAddressBookDto>().ReverseMap();
        }
    }
}
