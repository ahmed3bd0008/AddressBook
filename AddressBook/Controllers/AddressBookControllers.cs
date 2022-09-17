using Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookControllers : ControllerBase
    {
        private readonly IServiceManger _serviceManger;

        public AddressBookControllers(IServiceManger serviceManger)
        {
            _serviceManger = serviceManger;
        }
        [HttpGet]
        public IActionResult GetAddressBook()
        {
            return Ok(_serviceManger.addressBookService.GetAddressBooks(false));
        }
        [HttpPost]
        public IActionResult AddAddressBook(AddAddressBookDto addressBook)
        {
            return Ok(_serviceManger.addressBookService.Add(addressBook));
        }
        [HttpPut]
        public IActionResult UpdateAddressBook(UpdateAddressBookDto addressBook)
        {
            return Ok(_serviceManger.addressBookService.Update(addressBook));
        }
        [HttpDelete]
        public IActionResult DeleteAddressBook(int   Id)
        {
            return Ok(_serviceManger.addressBookService.Delete(Id));
        }
    }
}
