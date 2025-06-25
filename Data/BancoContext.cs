using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_Dotnet8.Models;
using Microsoft.EntityFrameworkCore;

namespace Projeto_Dotnet8.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<SalaModels> Salas { get; set; }
        public DbSet<ComputadorModels> Computadores { get; set; }
    }
}