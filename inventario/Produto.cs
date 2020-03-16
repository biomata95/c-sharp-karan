using System.IO;
using System;
using System.Collections.Generic;
using System.Text;
					
/* Classe Produto */
class Produto
{
	public long id { get; set;} /* Código do produto */
	public string nome { get; set;} /*  Nome do produto */
	public double preco { get; set;} /* Preço do produto */
	public Produto(long id,string nome, double preco) /* Método principal */
	{
    this.id = id; /* Atribuição do código do produto */
    this.nome = nome; /* Atribuição do nome do produto */
		this.preco = preco; /* Atribuição do preço do produto */
	}
}
