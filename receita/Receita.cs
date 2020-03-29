using System.IO;
using System;
using System.Collections.Generic;
using System.Text;


namespace receita
{
    class Receita
    {

        List<string> ingredientes = new List<string>(); /* Lista de ingredientes */

        public void inserirItem(){
            Console.WriteLine("Digite o nome do prato.");
            ingredientes.Add(Console.ReadLine()+": ");
            Console.WriteLine("Digite quantos ingredientes tem o prato.");
            int numProdutos = Convert.ToInt32(Console.ReadLine());
            int cont = 0; 
            while(cont < numProdutos){
                ingredientes.Add(Console.ReadLine());
                cont ++;
            }
            ingredientes.Add(" ");
        }

        public void listarReceitas(){
            foreach (var item in  ingredientes)
            {
                Console.WriteLine(item);
            }
        }

    }
}
