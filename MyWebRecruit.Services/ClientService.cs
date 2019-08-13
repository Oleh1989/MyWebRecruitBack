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
    class ClientService : BaseService, IClientService
    {
        public ClientService(MyWebRecruitDataBaseContext dataBaseContext) : base(dataBaseContext)
        {

        }

        public IQueryable<Domain.Entities.Client> GetClientList(Domain.Entities.User user)
        {
            IQueryable<Domain.Entities.Client> clients;
            using (var context = new MyWebRecruitDataBaseContext())
            {
                clients = context.Client
                    .Cast<Domain.Entities.Client>()
                    .Where(x => x.IsDeleted == false && x.CreatedBy == user.Id)
                    .OrderBy(x => x.Name);
            }

            return clients;
        }

        public void CreateClient(int userId)
        {
            string clientNameDummy = string.Empty, clientWebSite = string.Empty;
            string addressLineDummy = string.Empty, addressCityDummy = string.Empty, addressIndexDummy = string.Empty;
            int countryDummy = 0;
            string phoneDummy = string.Empty;

            using (var context = new MyWebRecruitDataBaseContext())
            {
                var newClient = new Client
                {
                    Name = clientNameDummy,
                    WebSite = clientWebSite,
                    AddressLine = addressLineDummy,
                    AddressCity = addressCityDummy,
                    AddressIndex = addressIndexDummy,
                    CountryId = countryDummy,
                    TelNo = phoneDummy,
                    CreatedBy = userId
                };
                context.Client.Add(newClient);
                context.SaveChanges();

            }
        }

        public void UpdateClient(Domain.Entities.Client client, int userId)
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

        public void DeleteClient(Domain.Entities.Client client)
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
