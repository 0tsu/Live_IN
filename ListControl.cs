public class ListControl
{
    List<KeyValuePair<DateTime, string>> timeLineList = new List<KeyValuePair<DateTime, string>>();

    public void AddList(int day, int hour, int minutes, string informations)
    {
        var date = new DateTime();
        DateTime timeLine = new DateTime(date.Year, date.Month, day, hour, minutes, date.Second);
        timeLineList.Add(new KeyValuePair<DateTime, string>(timeLine, informations));
        timeLineList = timeLineList.OrderBy(item => item.Key).ToList();
        Console.Clear();
        Console.WriteLine("Adicionado A lista");
        
    }
    public void ViewList()
    {
        int IndexList = 0;

        if(NoElementsInList())
        {
            Console.WriteLine("Sua lista não possui horarios");
            return;
        }

        Console.WriteLine("=============================");
        Console.WriteLine("I - Horarios  ||  Informações");
        Console.WriteLine("=============================");
        foreach(var item in timeLineList)
        {
            Console.WriteLine($"{IndexList++} - {item.Key.ToString("ddd HH:mm")} || {item.Value}");
        }
        Console.ReadKey();
    }
    public void RemoveList(int removeByIndex)
    {
        if(removeByIndex < 0 || removeByIndex >= timeLineList.Count)
        {
            Console.WriteLine("Indice não encontrato");
            return;
        }
        timeLineList.RemoveAt(removeByIndex);
        Console.Clear();
        Console.WriteLine("Horario removido da lista");
    }
    public void UpdateList(int updateByIndex)
    {
        int newDay, newHour,  newMinutes;
        string newInformations;

        if(updateByIndex < 0 || updateByIndex >= timeLineList.Count)
        {
            Console.WriteLine("Indice não encontrato");
            return;
        }
        
        do{
            Console.WriteLine("Digite o novo dia 1 = segunda, 7 = domingo");
            newDay = int.Parse(Console.ReadLine()??"");
        }while(newDay < 0 || newDay >= 7 );

        do{
            Console.WriteLine("Digite as horas");
            newHour = int.Parse(Console.ReadLine()??"");
        }while(newHour < 0 || newHour >= 24);

        do{
            Console.WriteLine("Digite os minutos");
            newMinutes = int.Parse(Console.ReadLine()??"");
        }while(newMinutes < 0 || newMinutes >= 60);

        Console.WriteLine("Digite uma nova informação");
        Console.WriteLine("Caso contrario pode so apertar enter");
        newInformations = Console.ReadLine()??"";

        var newDate = new DateTime();
        DateTime newTimeLine = new DateTime(newDate.Year, newDate.Month, newDay, newHour, newMinutes, newDate.Second);
        timeLineList[updateByIndex] = new KeyValuePair<DateTime, string>(newTimeLine, newInformations);
        Console.Clear();
        Console.WriteLine("Lista atualizada");
    }
    public bool NoElementsInList()
    {
        return timeLineList.Count == 0;
    }
}