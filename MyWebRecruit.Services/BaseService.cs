using System;
using MyWebRecruit.Data.MyWebRecruit.Data.Entities;

namespace MyWebRecruit.Services
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
