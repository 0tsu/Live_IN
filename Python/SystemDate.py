from datetime import datetime
import locale

locale.setlocale(locale.LC_TIME, "pt_BR.utf-8")

timeLine = []
def Add(day:int, hours:int, minutes:int, info:str):
    date = datetime(1, 1, day, hours, minutes, 0)
    dateText = date.strftime("%a - %H:%M")
    timeLine.append({"date":dateText, "info" : info})
    timeLine.sort(key=lambda x: x["date"])
    
def Delete(index:int):
    timeLine.pop(index)
    print("horario removido")

def Update(index:int, day:int, hours:int, minutes:int, info:str):
    date = datetime(1, 1, day, hours, minutes, 0)
    dateText = date.strftime("%a - %H:%M")
    timeLine[index] = {"date":dateText, "info": info}
    timeLine.sort(key=lambda x: x["date"])


def View():
    i = 0
    print("I - Dia - Horas - Info")
    for time in timeLine:
        print(f"{i} - {time['date']} - {time['info']}")
        i+=1


def ListNull():
    return len(timeLine) == 0

def IndexError(index:int):
    return index < 0 or index > len(timeLine)