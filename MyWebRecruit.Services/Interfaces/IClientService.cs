﻿using System;
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
        void CreateClient(int userId);
        void UpdateClient(ClientDto client, int userId);
        void DeleteClient(ClientDto client);
    }
}
