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

namespace MyWebRecruit.Services.Services
{
    class ClientService : BaseService, IClientService
    {
        public ClientService(MyWebRecruitDataBaseContext dataBaseContext) : base(dataBaseContext)
        {

        }

        public IQueryable<ClientDto> GetClientList(UserDto user)
        {
            IQueryable<ClientDto> clients;
            using (var context = new MyWebRecruitDataBaseContext())
            {
                clients = context.Client
                    .Cast<ClientDto>()
                    .Where(x => !x.IsDeleted && x.CreatedBy == user.Id)
                    .OrderBy(x => x.Name);
            }

            return clients;
        }

        public void CreateClient(ClientDto clientDto)
        {            
            using (var context = new MyWebRecruitDataBaseContext())
            {
                context.Client.Add(clientDto.ToData());
                context.SaveChanges();
            }
        }

        public void UpdateClient(ClientDto client, int userId)
        {
            string clientNameDummy = string.Empty, clientWebSite = string.Empty;
            string addressLineDummy = string.Empty, addressCityDummy = string.Empty, addressIndexDummy = string.Empty;
            int countryDummy = 0;
            string phoneDummy = string.Empty;

            using (var context = new MyWebRecruitDataBaseContext())
            {
                var clientToUpdate = context.Client.FirstOrDefault(c => c.Id == client.Id);
                if (clientToUpdate != null)
                {

                    clientToUpdate.Name = clientNameDummy;
                    clientToUpdate.WebSite = clientWebSite;
                    clientToUpdate.AddressLine = addressLineDummy;
                    clientToUpdate.AddressCity = addressCityDummy;
                    clientToUpdate.AddressIndex = addressIndexDummy;
                    clientToUpdate.CountryId = countryDummy;
                    clientToUpdate.TelNo = phoneDummy;
                    clientToUpdate.CreatedBy = userId;

                    context.Client.Update(clientToUpdate);
                    context.SaveChanges();
                }
            }
        }

        public void DeleteClient(ClientDto client)
        {
            using (var context = new MyWebRecruitDataBaseContext())
            {
                var clientToDelete = context.Client.FirstOrDefault(c => c.Id == client.Id);
                if (clientToDelete != null)
                {
                    clientToDelete.IsDeleted = true;

                    context.Client.Update(clientToDelete);
                    context.SaveChanges();
                }
            }
        }
    }
}
