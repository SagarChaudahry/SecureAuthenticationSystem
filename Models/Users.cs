﻿using Microsoft.AspNetCore.Identity;

namespace SecureAuthenticationSystem.Models
{
    public class Users:IdentityUser
    {
        public string FullName { get; set; }
       
    }
}
