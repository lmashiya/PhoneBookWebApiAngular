using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;
using PhoneBookWebApi.Data.Interfaces;

namespace PhoneBookWebApi.Models
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext(DbContextOptions<PhoneBookContext> options) : base(options)
        {
            
        }

        public DbSet<PhoneBookContact> PhoneBookContacts { get; set; }
    }
}
