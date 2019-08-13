using System;
using MyWebRecruit.Data.Entities;

namespace MyWebRecruit.Services.Services
{
    public class BaseService
    {
        protected MyWebRecruitDataBaseContext DataBaseContext { get; }

        protected BaseService(MyWebRecruitDataBaseContext dataBaseContext)
        {
            DataBaseContext = dataBaseContext ?? throw new ArgumentNullException(nameof(dataBaseContext));
        }
    }
}
