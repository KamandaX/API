﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class User
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}