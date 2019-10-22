using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_second.Models
{
    public class MobileDB:DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        public MobileDB(DbContextOptions<MobileDB> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
