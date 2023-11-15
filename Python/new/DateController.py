from datetime import datetime as dt

if __name__ == "__main__":    
    print("não é aqui que se executa")
    
class DateController():
    
    TimeLine = []
    
    def AddTimeLine(self, day:int, hour:int, minutes:int, informations:str):
        date = dt(1, 1, day, hour, minutes)
        self.TimeLine.append({"Date":date, "Informations": informations})
        self.TimeLine.sort(key=lambda x:x["Date"])
        print("Dado inserido")
        
    def RemoveTimeLine(self, index:int):        
        self.TimeLine.pop(index)
        print("Dado removido")


    def UpdateTimeLine(self, day:int, hour:int, minutes:int, informations:str, index:int):
        date = dt(dt.now().year, dt.now().month, day, hour, minutes)
        self.TimeLine[index] = {"Date":date, "Informations": informations}
        self.TimeLine.sort(key=lambda x:x["Date"])
        print("Dado atualizado")
    
    def ShowTimeLine(self):
        for i in self.TimeLine:
            print(f"{i['Date'].strftime('%A - %H:%M')} - {i['Informations']}")
    
            
        
    