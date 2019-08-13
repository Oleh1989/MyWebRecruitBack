using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebRecruit.Services.Entities;

namespace MyWebRecruit.Services.Interfaces
{
    public interface IContactService
    {
        IQueryable<ContactDto> GetContactList(ClientDto client);
        void ContactCreate(int clientId);
        void UpdateContact(ContactDto contact);
        void DeleteContact(ContactDto contact);
    }
}
