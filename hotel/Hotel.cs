class Hotel{
  public List<Quarto> quartos = new List<Quarto>(); /* Lista de quartos */
  Random random = new Random(); /* Semente do número aleatório que será o código */
  public List<Quarto> alocacaoQuartos(){ /* Método para cadastrar produtos */
    for(int i = 1;i < random.Next(10, 21);i++){
      int numeroQuarto = i;
      int diaria = random.Next(80, 500);
      int suite =  random.Next(0, 2);
      if(suite == 1)
        diaria += random.Next(300, 600);
      quartos.Add(new Quarto(numeroQuarto,diaria,suite,0,-1)); /* Adição dos quartos */
    }
    return quartos;
	}

  public void getQuartos(){ /* Método par imprimir os produtos */
    Console.WriteLine("Quartos do Hotel: ");
    foreach (var quarto in  quartos)
    {
      Console.WriteLine("Quarto: {0}, Diária: {1} R$, Suíte: {2}, Ocupado: {3}, Cliente: {4}", quarto.numeroQuarto, quarto.diaria, quarto.suite,quarto.ocupado,quarto.codigoCliente);
    }
	}

  public void geraReserva(int numeroQuarto){
    foreach (var quarto in  quartos)
    {
      if(quarto.numeroQuarto == numeroQuarto && quarto.ocupado == 0){
        quarto.ocupado = 1;
        quarto.codigoCliente = random.Next(1000,10000);
        break;
      }
      else if(quarto.numeroQuarto == numeroQuarto && quarto.ocupado == 1){
        Console.WriteLine("Quarto Ocupado");
        break;
      }
      else if(numeroQuarto >= quartos.Count){
        Console.WriteLine("Quarto Não Existe");
        break;
      }
    }
  }

  public void liberaReserva(int numeroQuarto){
    foreach (var quarto in  quartos)
    {
      if(quarto.numeroQuarto == numeroQuarto && quarto.ocupado == 1){
        quarto.ocupado = 0;
        quarto.codigoCliente = -1;
        break;
      }
      else if(quarto.numeroQuarto == numeroQuarto && quarto.ocupado == 0){
        Console.WriteLine("Quarto já está Liberada");
        break;
      }
      else if(numeroQuarto > quartos.Count){
        Console.WriteLine("Quarto Não Existe");
        break;
      }
    }
  }
}
