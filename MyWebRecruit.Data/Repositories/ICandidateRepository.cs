using System;
using System.Collections.Generic;
using System.Text;
using MyWebRecruit.Data.Entities;
using MyWebRecruit.Data.UnitOfWorks;

namespace MyWebRecruit.Data.Repositories
{
    public interface ICandidateRepository : IRepository<Candidate>
    {
        string GetTelNo(int id);
    }
}
