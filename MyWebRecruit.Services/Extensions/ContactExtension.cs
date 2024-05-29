using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Services.Extensions
{
    public static class ContactExtension
    {
        public static ContactDto ToDto(this Contact contact)
        {
            if (contact == null)
                return null;

            var contactDto = new ContactDto
            {
                Department = contact.Department,
                DisturbYn = contact.DisturbYn.Value,
                Email = contact.Email,
                FirstName = contact.FirstName,
                Id = contact.Id,
                JobTitle = contact.JobTitle,
                LastName = contact.LastName,
                TelNo = contact.TelNo
            };

            return contactDto;
        }

        public static Contact ToData(this ContactDto contactDto)
        {
            if (contactDto == null)
                return null;

            var contact = new Contact
            {
                Department = contactDto.Department,
                DisturbYn = contactDto.DisturbYn.Value,
                Email = contactDto.Email,
                FirstName = contactDto.FirstName,
                Id = contactDto.Id.Value,
                JobTitle = contactDto.JobTitle,
                LastName = contactDto.LastName,
                TelNo = contactDto.TelNo
            };

            return contact;
        }
    }
}
