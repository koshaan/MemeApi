﻿using System.ComponentModel.DataAnnotations;

namespace MemeApi.Models.DTO
{
    public class UserUpdateDTO
    {
        [Required]
        public string NewUsername { get; set; }
        public string NewEmail { get; set; }
        public string NewPassword { get; set; }
    }
}