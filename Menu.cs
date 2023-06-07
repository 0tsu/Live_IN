using System;
using System.Collections.Generic;
public class Menu
{
    int day, hours, minutes;


    ListControl list = new ListControl();
    public void Opcoes()
    {
        bool loop = true;
        while(loop)
        {   
            Console.WriteLine("--------------------Menu--------------------");
            Console.WriteLine("1 - Adicionar a lista");
            Console.WriteLine("2 - Remover da lista");
            Console.WriteLine("3 - Ver a lista");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Escolha uma Opção");
            int opcao = int.Parse(Console.ReadLine() ?? "");

            switch(opcao)
            {
                case 1:
                {
                    Console.Clear();
                    list.InfoList();
                    break;
                }
                case 2:
                {
                    Console.Clear();
                    list.RemoveList();
                    break;
                }
                case 3:
                {
                    Console.Clear();
                    list.ViewList();
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Ate depois então");
                    loop = false;
                    break;
                }
                default:
                {

                    Console.WriteLine("Opção invalida");
                    Console.ReadKey();
                    break;
                }
            }

        }
    }
}