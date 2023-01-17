using System;

namespace Enum
{
    class Program
    {
        enum Cor { Azul, Verde, Amarelo, Vermelho }
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
        static void Main(string[] args)
        {
            //ENUM
            /*Cor corFavorita = Cor.Amarelo;
            Cor minhaCorFavorita = Cor.Verde;

            //Console.WriteLine((int)corFavorita); //CASTING = CONVERTER UM TIPO PARA OUTRO
            Console.WriteLine((Cor)2); //Outro exemplo
            Console.WriteLine(minhaCorFavorita);
            */


            //ENUM E SWITCH
            Console.WriteLine("Selecione uma das opçôes abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;
            

            switch (opcaoSelecionada) {
                case Opcao.Criar:
                    Console.WriteLine("Você quer criar algo");
                break;

                case Opcao.Deletar:
                    Console.WriteLine("DELETE! DELETE IMEDIATAMENTE!");
                break;

                case Opcao.Editar:
                    Console.WriteLine("Editar é muito bom");
                break;

                case Opcao.Listar:
                    Console.WriteLine("Você quer listar algo");
                break;

                case Opcao.Atualizar:
                    Console.WriteLine("Você quer atualizar algo");
                break;

                default:
                    Console.WriteLine("OPÇÃO NÃO ENCONTRADA!");
                break;
                }
                
              

            Console.ReadLine();
        }
    }
}
