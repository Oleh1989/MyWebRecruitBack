using System;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MyWebRecruit.Domain.Services;
using MyWebRecruit.Domain.Entities;
using MyWebRecruit.Data.MyWebRecruit.Data.Entities;

namespace MyWebRecruit.Services
{
    public class ContactService : BaseService, IContactService
    {
        public ContactService(MyWebRecruitDataBaseContext dataBaseContext) : base(dataBaseContext)
        {

        }



        public IQueryable<Domain.Entities.Contact> GetContactList(Domain.Entities.Client client)
        {
            IQueryable<Domain.Entities.Contact> contacts;
            using (var context = new MyWebRecruitDataBaseContext())
            {
                contacts = context.Contact.Cast<Domain.Entities.Contact>()                    
                    .Where(x => x.IsDeleted == false && x.ClientId == client.CountryId)
                    .OrderBy(x => x.LastName)
                    .AsQueryable();
            }
            return contacts;
        }

        public void CreateContact(int clientId)
        {
            string 
        }
    }
}
