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
            Console.WriteLine("Me informe o que você deseja fazer");
            Console.WriteLine("=================================");
            Console.WriteLine("====== 1-Adicionar horário ======");
            Console.WriteLine("====== 2-Ver horários      ======");
            Console.WriteLine("====== 3-Remover horário   ======");
            Console.WriteLine("====== 4-Atualizar horário ======");
            Console.WriteLine("====== 5-Sair do programa  ======");

            // Tratamento de erro na conversão da entrada para inteiro
            int opc;
            bool inputValid = int.TryParse(Console.ReadLine(), out opc);

            if (!inputValid)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue; // Retorna ao início do loop
            }

            switch(opc)
            {
                //Add List
                case 1:
                    int day, hour, minutes;
                    string informations;
                    
                    do{
                        Console.WriteLine("Digite um dia da semana (1 = segunda, 7 = domingo)");
                        inputValid = int.TryParse(Console.ReadLine(), out day);
                        
                        if(!inputValid || day < 1 || day > 7)
                            Console.WriteLine("Valor invalido");

                    } while (!inputValid || day < 1 || day > 7);
                    
                    do{
                        Console.WriteLine("Digite a hora");
                        inputValid = int.TryParse(Console.ReadLine(), out hour);
                        
                        if(!inputValid || hour < 0 || hour >= 24)
                            Console.WriteLine("Valor invalido");

                    } while (!inputValid || hour < 0 || hour >= 24);
                    
                    do{
                        Console.WriteLine("Digite os minutos");
                        inputValid = int.TryParse(Console.ReadLine(), out minutes);

                        if(!inputValid || minutes <= 0 || minutes >= 60)
                            Console.WriteLine("Valor invalido");

                    } while (!inputValid || minutes <= 0 || minutes >= 60);
                    
                    Console.WriteLine("Caso queira, digite alguma descrição sobre o horário");
                    Console.WriteLine("Caso contrário, pressione Enter");
                    informations = Console.ReadLine() ?? "";
                    
                    List.AddList(day, hour, minutes, informations);
                    break;  
                //Veiw List
                case 2:
                    Console.Clear();
                    List.ViewList();
                    break;
                //Remove List
                case 3:
                    if(List.NoElementsInList())
                    {
                        Console.WriteLine("Sua lista não possui horários");
                        continue; // Retorna ao início do loop
                    }
                    Console.WriteLine("Informe o horário que deseja remover de acordo com o índice");
                    inputValid = int.TryParse(Console.ReadLine(), out int index);
                    if (!inputValid || List.IndexError(index))
                    {
                        Console.WriteLine("Índice inválido. Tente novamente.");
                        continue; // Retorna ao início do loop
                    }
                    List.RemoveList(index);
                    break;
                //Update List
                case 4:
                    if(List.NoElementsInList())
                    {
                        Console.WriteLine("Sua lista não possui horários");
                        continue; // Retorna ao início do loop
                    }

                    Console.WriteLine("Informe o horário que deseja atualizar de acordo com o índice");
                    inputValid = int.TryParse(Console.ReadLine(), out int updateIndex);
                    if (!inputValid || List.IndexError(updateIndex))
                    {
                        Console.WriteLine("Índice inválido. Tente novamente.");
                        continue; // Retorna ao início do loop
                    }
                    
                    int newDay, newHour, newMinutes;
                    string newInfo; 

                    do{
                        Console.WriteLine("Digite o novo dia (1 = segunda, 7 = domingo)");
                        inputValid = int.TryParse(Console.ReadLine(), out newDay);
                    } while (!inputValid || newDay <= 1 || newDay > 8);

                    do{
                        Console.WriteLine("Digite a nova hora");
                        inputValid = int.TryParse(Console.ReadLine(), out newHour);
                    } while (!inputValid || newHour < 0 || newHour > 23);

                    do{
                        Console.WriteLine("Digite os novos minutos");
                        inputValid = int.TryParse(Console.ReadLine(), out newMinutes);
                    } while (!inputValid || newMinutes < 0 || newMinutes > 59);

                    Console.WriteLine("Digite uma nova informação");
                    Console.WriteLine("Caso contrário, pressione Enter");
                    newInfo = Console.ReadLine() ?? "";

                    List.UpdateList(updateIndex, newDay, newHour, newMinutes, newInfo);
                    break;
                //Exit
                case 5:
                    loop = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}