using System.IO;
using System;
using System.Collections.Generic;
using System.Text;
					
public class Program
{
	public static void Main()
	{
        var inventario = new Inventario(); /* Instancia a Classe inventario */
        int opcao = 0; /* Auxiliar para continuar a inserção dos produtos */
        while(opcao != -1){ /* Enquanto a opção for diferente de -1 faça */
            string nome; /* Nome do produto que será inserido */
            double preco; /* Preço do produto a ser inserido */
            nome = Console.ReadLine(); /* Leitura do nome do produto */
            preco = Convert.ToDouble(Console.ReadLine()); /* Leitura do preço do produto */
            inventario.inventarioCadastro(nome,preco); /* Atribuição do nome e preço do produto no inventario */
            Console.WriteLine("Deseja continuar a inserção. Se não digite -1.");
            opcao = Convert.ToInt32(Console.ReadLine()); /* Opção se é para continuar a leitura */
        }
        inventario.getProdutos(); /* Após as inserções, listagem dos produtos */
	}
}
