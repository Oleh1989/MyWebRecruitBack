﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebRecruit.Domain.Entities;
namespace MyWebRecruit.Domain.Services
{
    public interface IClientService
    {
        IQueryable<Client> GetClientList(User user);
        void CreateClient(int userId);
        void UpdateClient(Client client, int userId);
        void DeleteClient(Client client);
    }
}
