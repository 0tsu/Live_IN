from abc import ABC

class InputValidations(ABC):
    def DateInput(self, CallBack,index=-1):
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
        
        if index == -1:
            CallBack(day,hour,minutes,informations)
            return
        
        CallBack(day,hour,minutes,informations,index)

    def IndexError(self,index):
        print("Erro de index, favor digitar o indice certo")
        return index < 0 or index > len(self.TimeLine) 

    def ContainsItemList(self):
        print("A lista não contem valores")
        return len(self.TimeLine) == 0