using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebRecruit.Services.Entities;

namespace MyWebRecruit.Services.Interfaces
{
    public interface IClientService
    {
        IQueryable<ClientDto> GetClientList(UserDto user);
        void CreateClient(ClientDto clientDto);
        void UpdateClient(ClientDto clientDto);
        void DeleteClient(ClientDto client);
    }
}
