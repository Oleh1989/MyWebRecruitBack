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
using MyWebRecruit.Data.UnitOfWorks;

namespace MyWebRecruit.Services.Services
{
    public class ClientService : BaseService, IClientService
    {
        public ClientService(IUnitOfWork uow) : base(uow)
        {

        }

        public List<ClientDto> GetClientList(int userId)
        {
            return _uow.ClientRepository.GetAll().
                Where(x => x.CreatedBy == userId)
                .Select(x => x.ToDto()).ToList();
        }

        public ClientDto GetClient(int id)
        {
            return _uow.ClientRepository.GetById(id).ToDto();
        }

        public void CreateClient(ClientDto clientDto)
        {
            _uow.ClientRepository.Add(clientDto.ToData());
            _uow.Save();
        }

        public void UpdateClient(ClientDto clientDto)
        {
            _uow.ClientRepository.Update(clientDto.ToData());
        }

        public void DeleteClient(int id)
        {
            _uow.ClientRepository.Delete(id);
            _uow.Save();
        }
    }
}