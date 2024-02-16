﻿using System.ComponentModel.DataAnnotations;

namespace BookStore2.Models.viewmodels
{
    public class Loginviewmodel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }=false;



    }
}
