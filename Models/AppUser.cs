﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleAuthAPI.Models;

public class AppUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "nvarchar(150)")]
    public string FullName { get; set; }
}
