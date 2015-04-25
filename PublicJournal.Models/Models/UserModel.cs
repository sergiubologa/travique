using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PublicJournal.Models.Converter;
using PublicJournal.Dal;


namespace PublicJournal.Models.Models
{
    public class UserModel
    {
        [ScaffoldColumn(false)]
        public int IdUser { get; set;}

        [Required(ErrorMessage = "Please enter a Username")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must have 5-15 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a Valid Password")]
        public string Password { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Created at")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        public string Address { get; set; }

        [Display(Name = "Updated by user")]
        public int? UpdatedByUser { get; set; }

        [Display(Name = "Updated at")]
        public DateTime? UpdatedDate { get; set; }

        public UserRoleModel Role { get; set; }

    }
}
