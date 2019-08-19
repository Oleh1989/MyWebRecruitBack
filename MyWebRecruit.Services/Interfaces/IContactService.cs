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
        List<ContactDto> GetContactList(ClientDto client);
        ContactDto GetContact(int id);
        void ContactCreate(ContactDto contactDto);
        void UpdateContact(ContactDto contactDto);
        void DeleteContact(int id);
    }
}
