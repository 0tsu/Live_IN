from Controller.DateController import DateController
from AbstractClass import ActionsFunctions as IV

class DateModel():
    def __init__(self) -> None:
        self.dateController = DateController("mysql+mysqlconnector://root:password@localhost/schedule")
        self.loop = True

    def Options(self,opc):
        match opc:
            case 1:
                return IV.DateInput(self.dateController.AddTimeLine)
            
            case 2:
                if self.dateController.NoContainsItemList():
                    return
                index = int(input("Digite o indice do que vc deseja alterar"))
                return "Index erro" if self.dateController.IndexError(index) else IV.DateInput(self.dateController.UpdateTimeLine,index)
                
            case 3:
                if self.dateController.NoContainsItemList():
                    return
                index = int(input("Digite o indice do que vc deseja Remover"))
                return "Index erro" if self.dateController.IndexError(index) else self.dateController.RemoveTimeLine(index)
                
            case 4:
                if self.dateController.NoContainsItemList():
                    return "No Contents"
                content = ""
                for i in IV.ParseJson(self.dateController.ShowTimeLine()):
                    content += f"""
-----------------------------------------
 Id : {i['id']}
 Date : {i['date']}
 Information : {i['information']}
----------------------------------------- \n"""
                return content
        
            case 5:
                self.loop = False
                return "Muito obrigado, volte sempre"

            case _:
                return "Valor invalido"



