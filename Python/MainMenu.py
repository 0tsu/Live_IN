from datetime import datetime
import locale
import SystemDate as SD




print("Sistema de cronogramas de horarios")
while True:
    print("Selecione as suas opções")
    print("1 - Adicionar ")
    print("2 -  Remover  ")
    print("3 - Atualizar ")
    print("4 - Ver Lista ")
    print("5 -   Sair    ")
    opc = int(input("Sua opção sera: "))

    match opc:
        case 1:
            day = -1
            hours = -1
            minutes = -1
            while(day < 1 or day > 7):
                day = int(input("Informe o dia da semana 1 = segunda, 7 = domingo: "))

            while(hours < 0 or hours > 23):
                hours = int(input("Informe as horas: "))
            
            while(minutes < 0 or minutes > 59):
                minutes = int(input("Informe os minutos: "))
            info = str(input("Digite uma informação se não so aperte enter: "))
            
            
            SD.Add(day,hours,minutes,info)
            
        case 2:
            if SD.ListNull() == True:
                print("A lista esta vazia")
                continue
            index = int(input("Digite o o horario de acordo com o indice da lista para removelo "))
            
            if(SD.IndexError(index) == True):
                print("O indice não existe")
                continue
            
            SD.Delete(index)
            
        case 3:
            if SD.ListNull() == True:
                print("A lista esta vazia")
                continue
            
            index = int(input("Digite o o horario de acordo com o indice da lista para atualizalo"))
            
            if SD.IndexError(index) == True:
                print("Indice invalido")
                continue
            
            day = -1
            hours = -1
            minutes = -1
            while(day < 1 or day > 7):
                day = int(input("Informe o dia da semana 1 = segunda, 7 = domingo: "))

            while(hours < 0 or hours > 23):
                hours = int(input("Informe as horas: "))
            
            while(minutes < 0 or minutes > 59):
                minutes = int(input("Informe os minutos: "))
            info = str(input("Digite uma informação se não so aperte enter: "))
            SD.Update(index, day, hours, minutes, info)
            
        case 4:
            if SD.ListNull() == True:
                print("A lista esta vazia")
                continue
            SD.View()
            
        case 5:
            break