from abc import ABC
from datetime import datetime as dt

class ActionsFunctions(ABC):
    
    def ParseJson(Value) -> dict:
        jsonResponse = [
            {
                "id": i.id,
                "date": i.date_hour.strftime('%A - %H:%M'),
                "information": i.information
            }
            for i in Value
        ]
        return jsonResponse


    def DateInput(CallBack,index=-1):
        day = -1
        hour = -1
        minutes = -1
        informations = -1
        
        while day < 1 or day > 7:
            day = int(input("Digite o dia da semana. 1=segunda, 7 = domingo: "))
        
        while hour < 0 or hour > 23:
            hour = int(input("Digite as horas: "))
        
        while minutes < 0 or minutes > 59: 
            minutes = int(input("Digite os minutos: "))
        
        informations = input("Digite uma informação: ")
        
        date = dt(1, 1, day, hour, minutes)

        if index == -1:
            CallBack(date,informations)
            return
        
        CallBack(date,informations,index)