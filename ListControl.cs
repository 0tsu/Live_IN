using System;
using System.Collections.Generic;
using System.Globalization;

public class ListControl
{      
    int day,hours,minutes;
    string format = "dddd HH:mm";
    
    List<KeyValuePair<DateTime,string>> timeLine = new List<KeyValuePair<DateTime,string>>();

    public void InfoList()
    {
        Console.WriteLine("Me informe o dia da semana que você deseja marcar");
        Console.WriteLine("Sendo 1 = Segunda e 7 = Domingo");
        while(true)
                    {
                        day = int.Parse(Console.ReadLine() ?? "1");
                        if(day > 0 && day <= 7 ) break;
                        else Console.WriteLine("valor invalido digite um valor entre 1 e 7");
                    }

        Console.WriteLine("Me informe a hora que você quer marcar");

        while(true)
        {
            hours = int.Parse(Console.ReadLine() ?? "0");
            if(hours >= 0 && hours < 24)   break;
            else    Console.WriteLine("valor invalido, digite um valor entre 0 a 23");
        }
        
        Console.WriteLine("Agora me informe os minutos");

        while(true)
        {
            minutes = int.Parse(Console.ReadLine() ?? "0");
            if(minutes>=0 && minutes<60)    break;
            else    Console.WriteLine("Valor invalido, digite um valor entre 0 a 59");
        }

        Console.WriteLine("Caso tenha alguma informação sobre o horario favor digitar aqui");
        string informations = Console.ReadLine() ?? "#";

        CreateList(day, hours, minutes, informations);
    }

    public void CreateList(int day, int hours, int minutes, string? informations)
    {
        Console.Clear();

        var date = new DateTime();
        DateTime times = new DateTime(date.Year, date.Month, day, hours, minutes, date.Second);
    
        timeLine.Add(new KeyValuePair<DateTime, string>(times, informations));
        timeLine = timeLine.OrderBy(item => item.Key).ToList();
        Console.WriteLine("HORARIO SALVO!!!");
    }

    public void ViewList()
    {
        Console.Clear();
        int timeLineIndex = 0;
        Console.WriteLine("Cronograma - informação do cronograma");
        foreach(var item in timeLine)
        {
            Console.WriteLine($"{timeLineIndex++} - {item.Key.ToString(format)} - {item.Value}");
        }
        Console.ReadKey();
    }

    public void RemoveList()
    {
        ViewList();
        Console.WriteLine("Qual você deseja remover?");
        int removeComponetByList = int.Parse(Console.ReadLine()?? "");

        if (removeComponetByList >= 0 && removeComponetByList < timeLine.Count){
            timeLine.RemoveAt(removeComponetByList);
            Console.WriteLine("HORARIO REMOVIDO");
        }
        else{
            Console.WriteLine("Valor invalido no cronograma");
        }
    }
}