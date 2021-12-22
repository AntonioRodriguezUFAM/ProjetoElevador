//------------------------------------------------------------------------------------------------
// PROJETO FINAL - JORNADA MS
// Projeto :    Gerenciamento de um elevador
// Nome:        Antonio Souto Rodriguez
// Data :       22/12/2021
//------------------------------------------------------------------------------------------------
/*
Description: 
  O projeto será um software que tem como função o gerenciamento de um elevador,
  ele terá as funções de inicializar, entrar, sair, subir e descer.
*/

using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Selection options
            bool continuar = true;

            // Creao objeto Elevador
            Elevador elevador = new Elevador();


            do
            {
                Console.WriteLine(@"Usuário Pulse Uma Opcao do Elevador:
                            0 - Entrar 
                            1 - Sair
                            2 - Subir
                            3 - Decer
                            4 - Sair Do Programa!!
                ");
                string OpctionChoose = Console.ReadLine();
                Console.WriteLine(" Sua Opção Escolha:" + OpctionChoose);

                switch (OpctionChoose)
                {
                    case "0":
                        Console.WriteLine("Voce Pulsou: Entrar");
                        elevador.Entrar();
                        break;

                    case "1":
                        Console.WriteLine("Voce Pulsou: Sair");
                        elevador.Sair();
                        break;
                    case "2":
                        Console.WriteLine("Voce Pulsou: Subir");
                        elevador.Subir();
                        break;

                    case "3":
                        Console.WriteLine("Voce Pulsou:  Decer");
                        elevador.Decer();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine(" Voce Pulsou :Sair Do Programa!!\n ");
                        continuar = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Escolha Errada!!\n");
                        break;
                }

            } while (continuar);


        }

    }
}
