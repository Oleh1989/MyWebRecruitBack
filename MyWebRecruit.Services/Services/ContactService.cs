﻿using System;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Entities;
using MyWebRecruit.Services.Interfaces;
using MyWebRecruit.Services.Extensions;

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
                    .Where(x => !x.IsDeleted && x.ClientId == client.CountryId)
                    .OrderBy(x => x.LastName)
                    .AsQueryable();
            }
            return contacts;
        }

        public void ContactCreate(ContactDto contactDto)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                context.Contact.Add(contactDto.ToData());
                context.SaveChanges();
            }  
        }

        public void UpdateContact(ContactDto contactDto)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                var contactToUpdate = context.Contact.FirstOrDefault(x => x.Id == contactDto.Id);
                if (contactToUpdate != null)
                {
                    context.Contact.Update(contactDto.ToData());
                    context.SaveChanges();
                }
            }
        }

        public void DeleteContact(ContactDto contact)
        {
            
        }
    }
}
