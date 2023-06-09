﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeToTurkeyAPI.Data.Enums;

namespace WelcomeToTurkeyAPI.Data.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Required] 
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string EmailAdress { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public UserTypes UserType { get; set; }





    }
}
