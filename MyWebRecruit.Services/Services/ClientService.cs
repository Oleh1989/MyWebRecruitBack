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
    class ClientService : BaseService, IClientService
    {
        public ClientService(IUnitOfWork uow) : base(uow)
        {

        }

        public List<ClientDto> GetClientList(UserDto user)
        {
            return _uow.ClientRepository.GetAll().Select(x => x.ToDto()).ToList();
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