from DateController import *
from AbstractClass import InputValidations

class DateModel():
    dateController = DateController()
    loop = True
    def Options(self,opc):
        match opc:
                case 1:
                    InputValidations.DateInput(self.dateController.AddTimeLine)
                
                case 2:
                    if InputValidations.ContainsItemList():
                        return
                    
                    index = int(input("Digite o indice do que vc deseja alterar"))
                    
                    if self.dateController.IndexError(index):
                        return
                    
                    InputValidations.DateInput(self.dateController.UpdateTimeLine,index)
                
                case 3:
                    if self.dateController.ContainsItemList():
                        return

                    index = int(input("Digite o indice do que vc deseja alterar"))
                    
                    if InputValidations.IndexError(index):
                        return
        
                    self.dateController.RemoveTimeLine(index)

                case 4:
                    if InputValidations.ContainsItemList():
                        return

                    self.dateController.ShowTimeLine()

                case 5:
                    self.loop = False
                    return 
