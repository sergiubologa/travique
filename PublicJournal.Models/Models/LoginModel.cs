using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PublicJournal.Models.Models
{
    public class LoginModel
    {
        [ScaffoldColumn(false)]
        public int IdUser { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address")]
        [RegularExpression("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$", ErrorMessage = "Username must be a valid email")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a Valid Password")]
        public string Password { get; set; }

        [ScaffoldColumn(false)]
        public string WrongUsername { get; set; }

        [ScaffoldColumn(false)]
        public string WrongPassword { get; set; }

        [ScaffoldColumn(false)]
        public int WrongPasswordCounter { get; set; }
    }
}
