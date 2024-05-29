using MyWebRecruit.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MyWebRecruit.Data.Repositories;

namespace MyWebRecruit.Data.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IRepository<Candidate> CandidateRepository { get; }
        IRepository<Client> ClientRepository { get; }
        IRepository<Assignment> AssignmentRepository { get; }
        IRepository<Contact> ContactRepository { get; }
        IRepository<JobGeneral> JobRepository { get; }
        IRepository<User> UserRepository { get; }
        void Save();
    }
}
