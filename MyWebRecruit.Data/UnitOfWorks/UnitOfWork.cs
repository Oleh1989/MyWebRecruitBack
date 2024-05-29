using MyWebRecruit.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyWebRecruit.Data.Repositories;

namespace MyWebRecruit.Data.UnitOfWorks
{
    class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly MyWebRecruitDataBaseContext _dbContext;
        private bool disposed = false;

        public UnitOfWork(DbContextOptions<MyWebRecruitDataBaseContext> options)
        {
            _dbContext = new MyWebRecruitDataBaseContext(options);
        }

        public IRepository<Candidate> CandidateRepository =>
            new Repository<Candidate>(_dbContext);
        public IRepository<Client> ClientRepository =>
            new Repository<Client>(_dbContext);
        public IRepository<Assignment> AssignmentRepository =>
             new Repository<Assignment>(_dbContext);
        public IRepository<Contact> ContactRepository =>
            new Repository<Contact>(_dbContext);
        public IRepository<JobGeneral> JobRepository =>
             new Repository<JobGeneral>(_dbContext);
        public IRepository<User> UserRepository =>
            new Repository<User>(_dbContext);

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
