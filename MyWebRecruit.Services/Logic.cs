using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

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

        public static bool EmailValidation(string input)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(input);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
