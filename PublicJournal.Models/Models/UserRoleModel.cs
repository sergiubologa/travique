using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PublicJournal.Models.Models
{
    public class UserRoleModel
    {
        [ScaffoldColumn(false)]
        public int IdUserRole {get; set;}

        public string RoleName { get; set; }

        [ScaffoldColumn(false)]
        public string Description { get; set; }
    }
}
