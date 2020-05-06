using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Ilie_Paul_Rp.Models;

namespace Asp_Ilie_Paul_Rp.Data
{
    public class Asp_Ilie_Paul_RpContext : DbContext
    {
        public Asp_Ilie_Paul_RpContext (DbContextOptions<Asp_Ilie_Paul_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Ilie_Paul_Rp.Models.Movie> Movie { get; set; }
    }
}
