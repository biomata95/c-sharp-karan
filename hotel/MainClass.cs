using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
    List<Quarto> quartos = new List<Quarto>(); /* Lista de quartos */
    Hotel hotel = new Hotel();
    quartos = hotel.alocacaoQuartos();
    hotel.getQuartos();
    int opcao = 0;
    int quartoEscolhido;
    while(opcao != -1){
      Console.WriteLine("1 - Reservar Quarto; 2 - Liberar Quarto; Depois Escolher Número de Quarto");
      opcao = Convert.ToInt32(Console.ReadLine());
      quartoEscolhido = Convert.ToInt32(Console.ReadLine());
      if(opcao == 1){
        hotel.geraReserva(quartoEscolhido);
        hotel.getQuartos();  
      }
      if(opcao == 2){
        hotel.liberaReserva(quartoEscolhido);
        hotel.getQuartos();  
      }
    }
  }
}
