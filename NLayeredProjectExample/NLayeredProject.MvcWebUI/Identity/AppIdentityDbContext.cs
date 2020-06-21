﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayeredProjectExample.MvcWebUI.Identity
{
    public class AppIdentityDbContext:IdentityDbContext<AppIdentityUser,AppIdentityRole,string>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options):base(options)
        {

        }
        public DbSet<AppIdentityUser> AppIdentityUsers { get; set; }
        public DbSet<AppIdentityRole> AppIdentityRoles { get; set; }
    }
}
