using MyWebRecruit.Data.MyWebRecruit.Data.Entities;
using MyWebRecruit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Domain.Extensions
{
    public static class JobGeneralExtensions
    {
        public static JobDto ToDto(this JobGeneral job)
        {
            if (job == null)
                return null;

            return new JobDto();
        }
    }
}
