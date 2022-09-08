using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreSD.Models;

namespace AspCoreSD.Models
{
    public class LecturaContext : DbContext
    {
        public LecturaContext(DbContextOptions<LecturaContext> options) : base(options)
        {

        }

        public virtual DbSet<Lecturacontador> Lecturacontadors { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Contador> Contadores { get; set; }
        public virtual DbSet<Contadorescliente> Contadoresclientes { get; set; } 
    }
}
