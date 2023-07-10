using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    [Table("SistemaFinaceiro")]
    public class SistemaFinanceiro :Base
    {
       
        public int Mes { get; set; }

        public int Ano { get; set;}

        public int DiaFechamento { get; set; }

        public bool GerarCopiaDespesa { get; set; }

        public int Mescopia { get; set; }

        public int AnoCopia { get; set; }
    }
}
