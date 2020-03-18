using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace atendimento_medico
{
    class Medico : Pessoa
    {
        List<Paciente> pacientes = new List<Paciente>(); /* Lista de pacientes */

        public void reservarAtendimento(){ /* Função para reservar atendimento */
            string nome; /* Nome do paciente que será inserido */
            string email; /* Email do paciente que será inserido */
            int telefone; /* Telefone do paciente que será inserido */
            if(pacientes.Count < 16){ /* Se o número de pacientes na lista for menor que 16, então cadastra o paciente */
                Console.WriteLine("Digite as informações do paciente.");
                Console.WriteLine("Nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Email:");
                email = Console.ReadLine();
                Console.WriteLine("Telefone:");
                telefone = Convert.ToInt32(Console.ReadLine());
                pacientes.Add(new Paciente(nome,email,telefone)); /* Adição do paciente */
            }
            else
            {
                Console.WriteLine("Número de atendimentos já está preenchido.");
            }
        }

        public void liberarAtendimento(int codigoAtendimento){ /* Libera o paciente da lista */
            int posicaoPaciente = 0; /* Auxiliar para contagem de pacientes no loop */
            foreach (var paciente in  pacientes)
            {
                if(paciente.codigo == codigoAtendimento){ /* Se o código do paciente corrente for igual ao códio passado por parâmetro, então o loop será interrompido. */
                    break;  
                }
                posicaoPaciente++; /* Contagem de pacientes na lista do médico */
            }
            if(pacientes.Count == posicaoPaciente) /* Se o número de pacientes na lista for igual à contagem da variável auxiliar posicaoPaciente, então o paciente não existe */
            {
                Console.WriteLine("Paciente não encontrado.");
            }
            else
            {
                pacientes.RemoveAt(posicaoPaciente);
            }
        }

        public void listarAtendimentos(){
            Console.WriteLine("Pacientes: ");
            foreach (var paciente in  pacientes) /* Loop para percorrer pacientes */
            {
                Console.WriteLine("Nome: {0}, Email: {1}, Telefone: {2}, Código: {3}", paciente.nome, paciente.email,paciente.telefone,paciente.codigo);
            }
        }

    }
}