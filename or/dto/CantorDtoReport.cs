﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
    public class CantorDtoReport
    {
        public virtual int id_cantor { get; set; }
        public virtual string nome { get; set; }
        public virtual string email { get; set; }
        public virtual string contato { get; set; }
        public virtual string cpf { get; set; }
        public virtual string rg { get; set; }
        public virtual string observacao { get; set; }
        public virtual string nomeartistico { get; set; }


        public CantorDtoReport()
        {

        }

        public CantorDtoReport(int id_cantor, string nome, string email, string contato, string cpf, string rg, string observacao, string nomeartistico)
        {
            this.id_cantor = id_cantor;
            this.nome = nome;
            this.email = email;
            this.contato = contato;
            this.cpf = cpf;
            this.rg = rg;
            this.observacao = observacao;
            this.nomeartistico = nomeartistico;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.id_cantor, this.nome);
        }

    }
}
