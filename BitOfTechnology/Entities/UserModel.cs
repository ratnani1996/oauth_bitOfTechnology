using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BitOfTechnology.Entities
{
    public class UserModel
    {
        [Column(TypeName = "varchar(30)")][Required]
        public string Username { get; set; }

        [Column(TypeName = "varchar(40)")][Required]
        public string Password { get; set; }

        [Column(TypeName = "varchar(40)")][Required]
        public string ConfirmPassword { get; set; }
    }
}
