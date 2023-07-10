
using Entities.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Configuracao
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions options) : base(options)
        {
           
        }

         
        public DbSet<SistemaFinanceiro> SistemaFinaceiro { get; set; }
        public DbSet<UsuarioSistemaFinaceiro> UsuarioSistemaFinaceiro { get; set; }
        public DbSet<Catogoria> Categoria { get; set; }
        public DbSet<Despesa> Despesa { get; set; }




    }
}
