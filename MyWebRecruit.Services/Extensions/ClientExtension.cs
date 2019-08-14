using MyWebRecruit.Data.Entities;
using MyWebRecruit.Services.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Services.Extensions
{
    public static class ClientExtension
    {
        public static ClientDto ToDto(this Client client)
        {
            if (client == null)
                return null;

            var clientDto = new ClientDto
            {
                Id = client.Id,
                Name = client.Name,
                AddressCity = client.AddressCity,
                AddressIndex = client.AddressIndex,
                AddressLine = client.AddressLine,
                CountryId = client.CountryId.Value,
                Country = client.CountryNavigation.CountryName,
                CreatedBy = client.CreatedBy,
                TelNo = client.TelNo,
                WebSite = client.WebSite
            };

            return clientDto;
        }

        public static Client ToData(this ClientDto clientDto)
        {
            if (clientDto == null)
                return null;


        }
    }
}
