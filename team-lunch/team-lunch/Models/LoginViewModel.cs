using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace team_lunch.Models
{
    public class LoginViewModel
    {
        public string ErrorMessage { get; }
        public LoginViewModel(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
