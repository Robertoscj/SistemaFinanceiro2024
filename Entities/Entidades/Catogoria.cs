using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    [Table("Categoria")]
    public class Catogoria : Base
    {
        public string Id { get; set; }


        public int IdSistema { get; set; }

        [ForeignKey("SistemaFinanceiro")]
        [Column(Order = 1)]
        public virtual SistemaFinanceiro SistemaFinanceiro { get; set; }
    }
}
