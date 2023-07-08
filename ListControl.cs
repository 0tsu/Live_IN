public class ListControl
{
    List<KeyValuePair<DateTime,string>> timeLineList = new List<KeyValuePair<DateTime,string>>();
    public void AddList(int day, int hour, int minute, string info)
    {
        var date = new DateTime();
        DateTime timeLine = new DateTime(date.Year, date.Month, day, hour, minute, date.Second);
        timeLineList.Add(new KeyValuePair<DateTime,string>(timeLine,info));
        timeLineList = timeLineList.OrderBy(x => x.Key).ToList();
        Console.WriteLine("ADICIONADO !!!");
    }

    public void RemoveList(int indexRemove)
    {
        timeLineList.RemoveAt(indexRemove);
        Console.WriteLine("REMOVIDO !!!");
    }

    public void UpdateList(int indexUpdate, int newDay, int newHour, int newMinute, string newInfo)
    {
        var newDate = new DateTime();
        DateTime newTimeLine = new DateTime(newDate.Year, newDate.Month, newDay, newHour, newMinute, newDate.Second);
        timeLineList.Add(new KeyValuePair<DateTime,string>(newTimeLine,newInfo));
        timeLineList = timeLineList.OrderBy(item => item.Key).ToList();
    }
    
    public void ViewList()
    {
        int index = 0;
        Console.WriteLine("I - Horarios  - Informações");
        foreach(var item in timeLineList)
        {
            Console.WriteLine($"{index++} - {item.Key.ToString("ddd HH:mm")} - {item.Value}");
        }
    }

    public bool ListIsNull()
    {
        return timeLineList.Count == 0;
    }
    public bool IndexError(int index)
    {
        return index <= 0 || index >=timeLineList.Count;
    }
}