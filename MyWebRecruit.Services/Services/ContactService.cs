using System;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Entities;
using MyWebRecruit.Services.Interfaces;
using MyWebRecruit.Services.Extensions;
using MyWebRecruit.Data.UnitOfWorks;

namespace MyWebRecruit.Services.Services
{
    public class ContactService : BaseService, IContactService
    {
        public ContactService(IUnitOfWork uow) : base(uow)
        {

        }

        public List<ContactDto> GetContactList(ClientDto client)
        {
            return _uow.ContactRepository.GetAll().Select(x => x.ToDto()).ToList();
        }

        public void ContactCreate(ContactDto contactDto)
        {
            _uow.ContactRepository.Add(contactDto.ToData());
            _uow.Save();
        }

        public void UpdateContact(ContactDto contactDto)
        {
            _uow.ContactRepository.Update(contactDto.ToData());
            _uow.Save();
        }

        public void DeleteContact(int id)
        {
            _uow.ContactRepository.Delete(id);
            _uow.Save();
        }
    }
}
