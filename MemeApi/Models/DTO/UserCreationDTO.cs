﻿using System.ComponentModel.DataAnnotations;

namespace MemeApi.Models
{
    public class UserCreationDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string password { get; set; }
    }
}