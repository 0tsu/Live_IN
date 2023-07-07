public class ListControl
{
    List<KeyValuePair<DateTime, string>> timeLineList = new List<KeyValuePair<DateTime, string>>();

    public void AddList(int day, int hour, int minutes, string informations)
    {
        var date = DateTime.Now;
        DateTime timeLine = new DateTime(date.Year, date.Month, day, hour, minutes, date.Second);
        timeLineList.Add(new KeyValuePair<DateTime, string>(timeLine, informations));
        timeLineList = timeLineList.OrderBy(item => item.Key).ToList();
        Console.Clear();
        Console.WriteLine("Adicionado à lista");
        
    }
    public void ViewList()
    {
        if(NoElementsInList())
        {
            Console.WriteLine("Sua lista não possui horários");
            return;
        }

        Console.WriteLine("=============================");
        Console.WriteLine("I - Horários  ||  Informações");
        Console.WriteLine("=============================");

        int index = 0;
        foreach(var item in timeLineList)
        {
            Console.WriteLine($"{index++} - {item.Key.ToString("ddd HH:mm")} || {item.Value}");
        }
        Console.ReadKey();
    }
    public void RemoveList(int removeByIndex)
    {
        timeLineList.RemoveAt(removeByIndex);
        Console.Clear();
        Console.WriteLine("Horário removido da lista");
    }
    public void UpdateList(int updateByIndex, int newDay, int newHour, int newMinutes, string newInfo)
    {
        var newDate = DateTime.Now;
        DateTime newTimeLine = new DateTime(newDate.Year, newDate.Month, newDay, newHour, newMinutes, newDate.Second);
        timeLineList[updateByIndex] = new KeyValuePair<DateTime, string>(newTimeLine, newInfo);
        Console.Clear();
        Console.WriteLine("Lista atualizada");
    }
    public bool NoElementsInList()
    {
        return timeLineList.Count == 0;
    }
    public bool IndexError(int index)
    {
        return index < 0 || index >= timeLineList.Count;
    }
}