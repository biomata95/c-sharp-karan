using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace atendimento_medico
{
    class Paciente : Pessoa
    {
        public int codigo;

        public Paciente(string nome,string email, int telefone){
            Random random = new Random(); /* Semente do número aleatório que será o código */
            this.nome = nome;
            this.email = email.ToLower();
            this.telefone = telefone;
            this.codigo = random.Next(1000,10000);
        }
        

    }
}