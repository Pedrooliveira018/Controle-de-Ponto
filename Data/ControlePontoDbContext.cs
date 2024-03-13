using Controle_de_Ponto.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controle_de_Ponto.Data
{
    internal class ControlePontoDbContext : DbContext
    {
        public ControlePontoDbContext(DbContextOptions<ControlePontoDbContext> opitions) : base(opitions)
        {
        }  

        public DbSet<Cargo> Cargos { get; set; }

    }
}
