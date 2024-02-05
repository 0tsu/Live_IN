from DAO.ConnectSql import *
from sqlalchemy.orm import sessionmaker
from sqlalchemy import create_engine

if __name__ == "__main__":    
    print("não é aqui que se executa")

TimeLineList = []

class DateController():
    def __init__(self, db_url):
        self.engine = create_engine(db_url)
        Base.metadata.create_all(self.engine)
        Session = sessionmaker(bind=self.engine)
        self.session = Session()

    def AddTimeLine(self, date, informations:str):
        newTimeLine = TimeLine(date_hour=date, information=informations)
        self.session.add(newTimeLine)
        self.session.commit()
        return "Atividade adicionada na tabela"
    
    def ShowTimeLine(self):
        response = self.session.query(TimeLine).all()
        return response

    def UpdateTimeLine(self, date, informations:str, index:int):
        row = self.session.query(TimeLine).get(index)
        if row:
            row.date_hour = date
            row.information = informations
            self.session.commit()
            return "Atividade atualizado na tabela"

    def RemoveTimeLine(self,index:int):
        row = self.session.query(TimeLine).get(index)
        self.session.delete(row)
        self.session.commit()
        return f"Atividade do id:{row.id}, removido da tabela"
            
    def IndexError(self,index):
        return not(self.session.query(TimeLine).get(index))

    def NoContainsItemList(self):
        return len(self.session.query(TimeLine).all()) == 0
    