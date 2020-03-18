using System;

namespace atendimento_medico
{
    class Program
    {
        static void Main(string[] args)
        {
            Medico medico = new Medico();
            int opcao = -1;
            while(opcao != 0){ /* Enquanto a opção da conta desejado for diferente de 0... */
                Console.WriteLine("Qual operação você deseja selecionar:");
                Console.WriteLine("1 - Reservar Atendimento.");
                Console.WriteLine("2 - Liberar Atendimento.");
                Console.WriteLine("3 - Listar Pacientes.");
                Console.WriteLine("0 - Sair.");
                opcao = Convert.ToInt32(Console.ReadLine()); /* Ler a opção desejada */
                switch (opcao)
                {
                    case 1:
                        medico.reservarAtendimento(); /* Função para reservar atendimento */
                        break;
                    case 2:
                        Console.WriteLine("Digite o código do paciente desejado para realizar o atendimento.");
                        int codigoDesejado = Convert.ToInt32(Console.ReadLine()); /* Digitar código do paciente desejado para liberá-lo da lista */
                        medico.liberarAtendimento(codigoDesejado); /* Função para liberar atendimento */
                        break;
                    case 3:
                        medico.listarAtendimentos(); /* Listar pacientes */
                    break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Operação não encontrada.")
                }
            }
        }
    }
}
