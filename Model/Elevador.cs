using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {
        //Um classe possui: 

        //  1)  Propriedades (atributos)
        //  2)  Métodos (ações)
        //  3)  Eventos (o que é feito durante uma ação)

        //------------------------------------------------------------------------------------------------
        // 1) Propriedades (atributos) - todas as variavel se tornam propriedades.
        //      Propriedades são as caracteriticas.
        //------------------------------------------------------------------------------------------------

        // O usuário vai informar quantos andares o elevador possui e a capacidade de pessoas.
        public int TotalAndar { get; set; }
        public int CapacidadeElevador { get; set; } // capacidade de pessoas

        public int AndarAtual { get; set; } // andar atual (térreo = 0)

        public int AndarUsuário { get; set; } // Andar do usuário!!

        public int PersoasElevador { get; set; } // Persoas no Elevador inicia vazio.
        //------------------------------------------------------------------------------------------------
        //  2)  Construtor Da Clase
        //------------------------------------------------------------------------------------------------
        public Elevador() //CONSTRUTOR DA CLASSE  <--- quando a classe for construida o que será executado.
        {
            Inicializar();
        }

        //------------------------------------------------------------------------------------------------
        //  2) Método (ações) :  Fuctions => Métodos:
        //------------------------------------------------------------------------------------------------
        // Funcao vai executar o Elevador.



        //------------------------------------------------------------------------------------------------
        //  2) Método (ações) : Inicializar()
        //      Deve receber como parâmetros a capacidade do elevador e o total
        //      andares no prédio (os elevadores sempre começam no térreo e vazio);
        //------------------------------------------------------------------------------------------------
        public void Inicializar()
        {
            // O usuário vai informar quantos andares o elevador possui e a capacidade de pessoas.
            Console.WriteLine(" O usuário primeiro vai informar quantos andares o elevador possui e a capacidade de pessoas.\n");
            Console.WriteLine(" \n Entrar capacidade do elevador");
            CapacidadeElevador = int.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine(" \n Entrar Andares Total");
            TotalAndar = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($" \n Entrar capacidade do elevador: {CapacidadeElevador}");
            Console.WriteLine($" \n   Entrar Andares Total: {TotalAndar}");

            // (os elevadores sempre começam no térreo e vazio);

            // andar atual(térreo = 0)
            AndarAtual = 0;
            // Persoas no Elevador inicia vazio = 0
            PersoasElevador = 0;

            //Mostra estado do Elevador
            StateElevator();
        }

        //------------------------------------------------------------------------------------------------
        //  Método (ações) :  0) Entrar:
        //  Deve acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);
        //------------------------------------------------------------------------------------------------
        public void Entrar()
        {
            if (PersoasElevador < CapacidadeElevador)
            {
                PersoasElevador++;
                StateElevator();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Elevador cheio!!\n");
            }
        }
        //------------------------------------------------------------------------------------------------
        // Método (ações) : 1) Sair :
        // Deve remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);
        //------------------------------------------------------------------------------------------------
        public void Sair()
        {
            if (PersoasElevador > 0)
            {
                PersoasElevador--;
                StateElevator();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(" Elevador Vazio!!\n");
            }
        }
        //------------------------------------------------------------------------------------------------
        // Método (ações) : 2) Subir :
        // Deve subir um andar (não deve subir se já estiver no último andar);
        //------------------------------------------------------------------------------------------------
        public void Subir()
        {
            if (AndarAtual < TotalAndar)
            {
                AndarAtual++;
                StateElevator();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Elevador Ta no Ultimo Andar!!\n");
            }
        }
        //------------------------------------------------------------------------------------------------
        // Método (ações) :3) Descer :
        // Deve descer um andar (não deve descer se já estiver no térreo);
        //------------------------------------------------------------------------------------------------
        public void Decer()
        {
            if (AndarAtual > 0)
            {
                AndarAtual--;
                StateElevator();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Elevador Ta no Terreo!!\n");
            }

        }
        //------------------------------------------------------------------------------------------------
        // Método(ações) : Estado Do Elevador
        //------------------------------------------------------------------------------------------------
        public void StateElevator()
        {
            Console.Clear();
            Console.WriteLine($"Capacidade do elevador: {CapacidadeElevador}");
            Console.WriteLine($"     Numero de Andares: {TotalAndar}");
            Console.WriteLine($"         Andares Atual: {AndarAtual}");
            Console.WriteLine($"   Persoas No Elevador: {PersoasElevador}\n");
        }

    }
}
