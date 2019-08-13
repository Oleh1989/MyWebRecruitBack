using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebRecruit.Domain.Entities;

namespace MyWebRecruit.Domain.Services
{
    public interface IContactService
    {
        IQueryable<Contact> GetContactList(Client client);
        void ContactCreate(int clientId);
        void UpdateContact(Contact contact);
        void DeleteContact(Contact contact);
    }
}
