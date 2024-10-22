﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.or
{
    public class Cantor
    {
        public virtual int id_cantor { get; set; }
        public virtual string nome { get; set; }
        public virtual string email { get; set; }
        public virtual string contato { get; set; }
        public virtual string cpf { get; set; }
        public virtual string rg { get; set; }
        public virtual string observacao { get; set; }
        public virtual string cidade { get; set; }
        public virtual string estado { get; set; }
        public virtual string idade { get; set; }
        public virtual string nascimento { get; set; }
        public virtual int id_apresentacao { get; set; }
        public virtual string nomeartista { get; set; }


        public Cantor()
        {

        }

        public Cantor(string nome, string email, string contato, string cpf, 
                string rg, string observacao, string cidade, string estado, string idade, string nascimento)
        {
            this.nome = nome;
            this.email = email;
            this.contato = contato;
            this.cpf = cpf;
            this.rg = rg;
            this.observacao = observacao;
            this.cidade = cidade;
            this.estado = estado;
            this.idade = idade;
            this.nascimento = nascimento;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.id_cantor, this.nomeartista, this.nome);
        }

    }
}
