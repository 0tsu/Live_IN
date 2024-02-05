from Model.DateModel import DateModel

class DateView():
    
    def __init__(self):
        self.dateModel = DateModel()
        
        while self.dateModel.loop:
            print("1 - Adicionar")
            print("2 - Atualizar")
            print("3 - Remover")
            print("4 - Ver")
            print("5 - Sair") 
            print(self.dateModel.Options(int(input("Digite sua opção: "))))

    