using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = -1; /* Opção para escolher qual tipo de conta deseja selecionar */
            ContaCorrente contaCorrente = new ContaCorrente(); /* Instanciação da conta corrente */
            ContaPoupanca contaPoupanca = new ContaPoupanca(); /* Instanciação da conta poupança */
            ContaEmpresarial contaEmpresarial = new ContaEmpresarial(); /* Instanciação da conta empresarial */
            while(opcao != 0){ /* Enquanto a opção da conta desejado for diferente de 0... */
                Console.WriteLine("Qual espécie de conta você deseja selecionar:");
                Console.WriteLine("1 - Conta Corrente.");
                Console.WriteLine("2 - Conta Poupança.");
                Console.WriteLine("3 - Conta Empresarial.");
                Console.WriteLine("0 - Sair.");
                opcao = Convert.ToInt32(Console.ReadLine()); /* Ler a opção desejada */
                switch (opcao)
                {
                    case 1: /* Opção da conta corrente */
                        int opcaoCorrente = -1; /* Operação desejada na conta corrente */
                        while(opcaoCorrente != 0){ /* Enquanto a operação desejada for diferente de 0... */
                            Console.WriteLine("1 - Saldo.");
                            Console.WriteLine("2 - Depositar.");
                            Console.WriteLine("3 - Sacar.");
                            Console.WriteLine("0 - Sair.");
                            opcaoCorrente = Convert.ToInt32(Console.ReadLine()); /* Ler a opção desejada */
                            switch (opcaoCorrente)
                            {
                                case 1: /* Saldo */
                                    Console.WriteLine("Seu saldo eh de : "+contaCorrente.getSaldo()+" R$");
                                    break;
                                case 2: /* Depositar */
                                    Console.WriteLine("Digite o valor desejado para depositar:");
                                    contaCorrente.setDeposito(Convert.ToDouble(Console.ReadLine()));
                                    break;
                                case 3: /* Sacar */
                                    Console.WriteLine("Digite o valor desejado para sacar:");
                                    contaCorrente.setSaque(Convert.ToDouble(Console.ReadLine()));
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida:");
                                    break;
                            }
                        }
                        break;
                    case 2: /* Opção da conta poupança */
                        int opcaoPoupanca = -1; /* Operação desejada na conta corrente */
                        while(opcaoPoupanca != 0){  /* Enquanto a operação desejada for diferente de 0... */
                            Console.WriteLine("1 - Saldo.");
                            Console.WriteLine("2 - Depositar.");
                            Console.WriteLine("3 - Sacar.");
                            Console.WriteLine("0 - Sair.");
                            opcaoPoupanca = Convert.ToInt32(Console.ReadLine()); /* Ler operação desejada */
                            switch (opcaoPoupanca)
                            {
                                case 1: /* Saldo */
                                    Console.WriteLine("Seu saldo eh de : "+contaPoupanca.getSaldo()+" R$");
                                    break;
                                case 2: /* Deposito */
                                    Console.WriteLine("Digite o valor desejado para depositar:");
                                    contaPoupanca.setDeposito(Convert.ToDouble(Console.ReadLine()));
                                    break;
                                case 3: /* Sacar */
                                    Console.WriteLine("Digite o valor desejado para sacar:");
                                    contaPoupanca.setSaque(Convert.ToDouble(Console.ReadLine()));
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida:");
                                    break;
                            }
                        }
                        break;
                    case 3: /* Opção conta empresarial */
                        int opcaoEmpresarial = -1; /* Operação desejada na conta corrente */
                        while(opcaoEmpresarial != 0){  /* Enquanto a operação desejada for diferente de 0... */
                            Console.WriteLine("1 - Saldo.");
                            Console.WriteLine("2 - Depositar.");
                            Console.WriteLine("3 - Sacar.");
                            Console.WriteLine("0 - Sair.");
                            opcaoEmpresarial = Convert.ToInt32(Console.ReadLine()); /* Ler operação desejada */
                            switch (opcaoEmpresarial)
                            {
                                case 1: /* Saldo */
                                    Console.WriteLine("Seu saldo eh de : "+contaEmpresarial.getSaldo()+" R$");
                                    break;
                                case 2: /* Deposito */
                                    Console.WriteLine("Digite o valor desejado para depositar:");
                                    contaEmpresarial.setDeposito(Convert.ToDouble(Console.ReadLine()));
                                    break;
                                case 3: /* Sacar */
                                    Console.WriteLine("Digite o valor desejado para sacar:");
                                    contaEmpresarial.setSaque(Convert.ToDouble(Console.ReadLine()));
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida:");
                                    break;
                            }
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida:");
                        break;
                }
            }
        }
    }
}
