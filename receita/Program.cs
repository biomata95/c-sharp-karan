using System;

namespace receita
{
    class Program
    {
        static void Main(string[] args)
        {
            Receita receita = new Receita();
            int opcao = -1;
            while(opcao != 0){ /* Enquanto a opção da conta desejado for diferente de 0... */
                Console.WriteLine("Qual operação você deseja selecionar:");
                Console.WriteLine("1 - Inserir Prato.");
                Console.WriteLine("2 - Listar Pratos.");
                Console.WriteLine("0 - Sair.");
                opcao = Convert.ToInt32(Console.ReadLine()); /* Ler a opção desejada */
                switch (opcao)
                {
                    case 1:
                        receita.inserirItem();
                        break;
                    case 2:
                        receita.listarReceitas();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Operação não encontrada.");
                        break;
                }
            }
        }
    }
}
