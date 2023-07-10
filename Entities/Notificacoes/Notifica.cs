﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notificacoes
{
    public class Notifica
    {
        public Notifica() 
        {
            notificacoes = new List<Notifica>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string mensagem { get; set; }

        [NotMapped]

        public List<Notifica> notificacoes;


        public bool ValidarPropriedadeString(string valor,string nomePropriedades)
        {
            if(string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedades))
            {
                notificacoes.Add(new Notifica
                {
                      mensagem = "Campo Obrigatório",
                      NomePropriedade = nomePropriedades,

                });

                return false;
            }

            return true;
        }


        public bool ValidarPropriedadeInt(int valor, string nomePropriedades)
        {
            if ( valor < 1 || string.IsNullOrWhiteSpace(nomePropriedades))
            {
                notificacoes.Add(new Notifica
                {
                    mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedades,

                });

                return false;
            }

            return true;
        }






    }
}
