public class MainMenu
{
    public void Opcoes()
    {
        bool loop = true;

        ListControl List = new ListControl();

        Console.WriteLine("Listinha de cronogramas deveras fofo");
        while (loop == true)
        {
            Console.WriteLine("================================="); 
            Console.WriteLine("Me informe o que vc deseja fazer");
            Console.WriteLine("=================================");
            Console.WriteLine("====== 1-Adicionar horario ======");
            Console.WriteLine("====== 2-Ver horarios      ======");
            Console.WriteLine("====== 3-Remover horario   ======");
            Console.WriteLine("====== 4-Atualizar horario ======");
            Console.WriteLine("====== 5-Sair do programa  ======");
            int opc = int.Parse(Console.ReadLine()??"");
            switch(opc)
            {
                case 1:
                    int day,hour,minutes;
                    string informations;
                    do{
                        Console.WriteLine("Digite um dia da semana 1 = segunda, 7 = domingo");
                        day = int.Parse(Console.ReadLine()??"");
                    }while(day>=7 || day<0);
                    
                    do{
                        Console.WriteLine("Digite o horario");
                        hour = int.Parse(Console.ReadLine()??"");
                    }while(hour<0 || hour>=24);
                    
                    do{
                        Console.WriteLine("Digite os minutos");
                        minutes = int.Parse(Console.ReadLine()??"");
                    }while(minutes<=0 || minutes >= 60);
                    
                    Console.WriteLine("Caso queire digite alguma descrição sobre o horario");
                    Console.WriteLine("Caso contrario aperte enter");
                    informations = Console.ReadLine()??"";
                    
                    List.AddList(day,hour,minutes,informations);
                    break;

                case 2:
                    Console.Clear();
                    List.ViewList();
                    break;

                case 3:
                    if(List.NoElementsInList())
                    {
                        Console.WriteLine("Sua lista não possui horarios");
                        return;
                    }
                    Console.WriteLine("Informe o horario que deseja remover de acordo com o indice");
                    int index = int.Parse(Console.ReadLine()??"");
                    List.RemoveList(index);
                    break;

                case 4:
                    if(List.NoElementsInList())
                    {
                        Console.WriteLine("Sua lista não possui horarios");
                        return;
                    }
                    Console.WriteLine("Informe o horario que deseja atualizar de acordo com o indice");
                    int updateIndex = int.Parse(Console.ReadLine()??"");
                    List.UpdateList(updateIndex);
                    break;

                case 5:
                    loop = false;
                    break;

                default:
                    Console.WriteLine("Valor invalido");
                    break;
            }
        }
    }
}