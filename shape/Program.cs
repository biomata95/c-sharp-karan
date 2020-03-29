using System;

namespace shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();
            Retangulo retangulo = new Retangulo();
            Triangulo triangulo = new Triangulo();
            int opcao = -1;
            while(opcao != 0){ /* Enquanto a opção da conta desejado for diferente de 0... */
                Console.WriteLine("Qual operação você deseja selecionar:");
                Console.WriteLine("1 - Circulo");
                Console.WriteLine("2 - Retângulo.");
                Console.WriteLine("3 - Triângulo.");
                Console.WriteLine("0 - Sair.");
                opcao = Convert.ToInt32(Console.ReadLine()); /* Ler a opção desejada */
                switch (opcao)
                {
                    case 1:
                        int opcaoCirculo = -1;
                        while(opcaoCirculo != 0){ /* Enquanto a operação desejada for diferente de 0... */
                            Console.WriteLine("1 - Área.");
                            Console.WriteLine("2 - Perímetro.");
                            Console.WriteLine("0 - Sair.");
                            opcaoCirculo = Convert.ToInt32(Console.ReadLine()); /* Ler a opção desejada */
                            double raio;
                            switch (opcaoCirculo)
                            {
                                case 1: 
                                    Console.WriteLine("Digite o raio do circulo");
                                    raio = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("A área do circulo eh: "+circulo.getArea(raio));
                                    break;
                                case 2: 
                                    Console.WriteLine("Digite o raio do circulo");
                                    raio = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("O perímetro do circulo eh: "+circulo.getPerimetro(raio));
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida:");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        int opcaoRetangulo = -1;
                        while(opcaoRetangulo != 0){ /* Enquanto a operação desejada for diferente de 0... */
                            Console.WriteLine("1 - Área.");
                            Console.WriteLine("2 - Perímetro.");
                            Console.WriteLine("0 - Sair.");
                            opcaoRetangulo = Convert.ToInt32(Console.ReadLine()); /* Ler a opção desejada */
                            double lado1;
                            double lado2;
                            switch (opcaoRetangulo)
                            {
                                case 1: 
                                    Console.WriteLine("Digite o lado 1");
                                    lado1 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Digite o lado 2");
                                    lado2 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("A área do retângulo eh: "+retangulo.getArea(lado1,lado2));
                                    break;
                                case 2: 
                                    Console.WriteLine("Digite o lado 1");
                                    lado1 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Digite o lado 2");
                                    lado2 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("O perímetro do retângulo eh: "+retangulo.getPerimetro(lado1,lado2));
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida:");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        int opcaoTriangulo = -1;
                        while(opcaoTriangulo != 0){ /* Enquanto a operação desejada for diferente de 0... */
                            Console.WriteLine("1 - Área.");
                            Console.WriteLine("2 - Perímetro.");
                            Console.WriteLine("0 - Sair.");
                            opcaoTriangulo = Convert.ToInt32(Console.ReadLine()); /* Ler a opção desejada */
                            double lado1;
                            double lado2;
                            double lado3;
                            double baseTri;
                            double alturaTri;
                            switch (opcaoTriangulo)
                            {
                                case 1: 
                                    Console.WriteLine("Digite a base");
                                    baseTri = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Digite a altura");
                                    alturaTri = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("A área do triângulo eh: "+triangulo.getArea(baseTri,alturaTri));
                                    break;
                                case 2: 
                                    Console.WriteLine("Digite o lado 1");
                                    lado1 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Digite o lado 2");
                                    lado2 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Digite o lado 3");
                                    lado3 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("O perímetro do triângulo eh: "+triangulo.getPerimetro(lado1,lado2,lado3));
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida:");
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
