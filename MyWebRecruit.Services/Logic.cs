using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebRecruit.Services
{
    class Logic
    {
        public static string NullOrEmptyField(params string[] fields)
        {
            foreach (string field in fields)
            {
                if (string.IsNullOrEmpty(field))
                {
                    return "Several fields can not be empty";                    
                }                
            }
            return null;
        }
    }
}
