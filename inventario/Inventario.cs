using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

/* Classe Inventario */
class Inventario{
  Random rnd = new Random(); /* Semente do número aleatório que será o código */
	public List<Produto> allProdutos = new List<Produto>(); /* Lista dos produtos */
	public void inventarioCadastro(string nome,double preco){ /* Método para cadastrar produtos */
        allProdutos.Add(new Produto(rnd.Next(),nome,preco)); /* Adição dos produtos */
	}

	public void getProdutos(){ /* Método par imprimir os produtos */
    foreach (var produtos in  allProdutos)
    {
      Console.WriteLine("Produto: {0},{1},{2}", produtos.id, produtos.nome, produtos.preco);
    }
	}
}
