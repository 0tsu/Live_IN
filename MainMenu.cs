public class MainMenu
{
    public void Opcoes()
    {
        ListControl List = new ListControl();    
        bool loop = true;
        while(loop == true)
        {
            Console.WriteLine("Sistema de Cronograma");
            Console.WriteLine("=========== Menu ===========");
            Console.WriteLine("======== 1 = Add    ========");
            Console.WriteLine("======== 2 = Remove ========");
            Console.WriteLine("======== 3 = Update ========");
            Console.WriteLine("======== 4 = View   ========");
            Console.WriteLine("======== 5 = Exit   ========");
            Console.Write("Sua opção sera: ");

            if(!int.TryParse(Console.ReadLine(), out int opc))
            {
                Console.WriteLine("valor invalido");
                continue;
            }
            int day,hour,minute,index;
            string info;
            bool inputTest;

            switch(opc)
            {
                //Adicionar @@
                case 1:
                    do{
                        Console.Write("valor digite um valor entre 1 = segunda e 7 = domingo: ");
                        if(!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 8)
                        {
                            Console.WriteLine("valor invalido");
                            
                        }
                    }while(day < 1 || day > 8);

                    do{
                        Console.Write("Digite as horas: ");
                        if(!int.TryParse(Console.ReadLine(), out hour) || hour < 1 || hour > 23)
                        {
                            Console.WriteLine("valor invalido");
                        }
                    }while(hour < 0 || hour > 23);

                    do{
                        Console.Write("Digite os minutos: ");
                        if(!int.TryParse(Console.ReadLine(), out minute) || minute < 0 || minute > 59)
                        {
                            Console.WriteLine("valor invalido");
                        }
                    }while(minute < 0 || minute > 59);
                    
                    Console.Write("caso tenha uma informação digite aqui se não so aperte enter: ");
                    info = Console.ReadLine()??"";

                    List.AddList(day,hour,minute,info);
                break;

                //Remover@@
                case 2:
                    List.ListIsNull();
                    Console.WriteLine("Selecioner o indice do horario que deseja remover");
                    do{
                        inputTest = int.TryParse(Console.ReadLine(),out index);
                        if(!inputTest|| List.IndexError(index))
                            Console.WriteLine("valor invalido");
                    }while(!inputTest || List.IndexError(index));
                    List.RemoveList(index);
                break;

                //Atualizar@@
                case 3:
                    List.ListIsNull();
                    Console.WriteLine("Selecioner o indice do horario que deseja remover");
                    do{
                        inputTest = int.TryParse(Console.ReadLine(),out index);
                        if(!inputTest|| List.IndexError(index))
                            Console.WriteLine("valor invalido");
                    }while(!inputTest || List.IndexError(index));

                    do{
                        Console.Write("valor digite um valor entre 1 = segunda e 7 = domingo: ");
                        if(!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 8)
                        {
                            Console.WriteLine("valor invalido");
                            
                        }
                    }while(day < 1 || day > 8);

                    do{
                        Console.Write("Digite as horas: ");
                        if(!int.TryParse(Console.ReadLine(), out hour) || hour < 1 || hour > 23)
                        {
                            Console.WriteLine("valor invalido");
                        }
                    }while(hour < 0 || hour > 23);

                    do{
                        Console.Write("Digite os minutos: ");
                        if(!int.TryParse(Console.ReadLine(), out minute) || minute < 0 || minute > 59)
                        {
                            Console.WriteLine("valor invalido");
                        }
                    }while(minute < 0 || minute > 59);
                    
                    Console.Write("caso tenha uma informação digite aqui se não so aperte enter: ");
                    info = Console.ReadLine()??"";

                    List.UpdateList(index,day,hour,minute,info);

                break;

                //Vizualizar@@
                case 4:
                    if(List.ListIsNull())
                    {
                        Console.WriteLine("Sua lista não possui conteudo");
                        continue;
                    }
                    List.ViewList();
                break;

                //Sair @@
                case 5:
                    Console.WriteLine("ate mais então");
                    loop = false;
                break;
            }
        }
    }
}