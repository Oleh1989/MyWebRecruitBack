using System;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Entities;
using MyWebRecruit.Services.Interfaces;

namespace MyWebRecruit.Services.Services
{
    public class ContactService : BaseService, IContactService
    {
        public ContactService(MyWebRecruitDataBaseContext dataBaseContext) : base(dataBaseContext)
        {

        }



        public IQueryable<ContactDto> GetContactList(ClientDto client)
        {
            IQueryable<ContactDto> contacts;
            using (var context = new MyWebRecruitDataBaseContext())
            {
                contacts = context.Contact.Cast<ContactDto>()                    
                    .Where(x => x.IsDeleted == false && x.ClientId == client.CountryId)
                    .OrderBy(x => x.LastName)
                    .AsQueryable();
            }
            return contacts;
        }

        public void CreateContact(int clientId)
        {
           
        }

        public void ContactCreate(int clientId)
        {
           
        }

        public void UpdateContact(ContactDto contact)
        {
            
        }

        public void DeleteContact(ContactDto contact)
        {
            
        }
    }
}
