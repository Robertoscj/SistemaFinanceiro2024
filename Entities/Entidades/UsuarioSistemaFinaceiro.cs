using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    [Table("UsuarioSistemaFinaceiro")]
    public class UsuarioSistemaFinaceiro
    {
        public int Id { get; set; }

        public string EmailUsuario { get; set;}

        public bool Administrador { get; set; }

        public bool SistemaAtual { get; set; }




        public int IdSistema { get; set; }

        [ForeignKey("SistemaFinanceiro")]
        [Column(Order = 1)]
        public virtual SistemaFinanceiro SistemaFinanceiro { get; set; }
    }
}
