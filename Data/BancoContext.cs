using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projeto_Dotnet8.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options) : base(options)
        {
        }

        /* public DbSet<"..Models"> "Model" {get; set;} */
    }
}