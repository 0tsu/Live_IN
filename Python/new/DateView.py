from DateModel import *

class DateView():
    
    dateModel = DateModel()
    
    def Main (self):
        while self.dateModel.loop == True:
            print("1 - Adicionar")
            print("2 - Atualizar")
            print("3 - Remover")
            print("4 - Ver")
            print("5 - Sair") 
            opc = int(input("Digite sua opção: "))
            self.dateModel.Options(opc)

    