from sqlalchemy import Column, Integer, String, DateTime
from sqlalchemy.ext.declarative import declarative_base

from datetime import datetime

Base = declarative_base() 

class TimeLine(Base):
    __tablename__ = "timeline"

    id = Column(Integer, primary_key=True)
    date_hour = Column(DateTime, default=datetime.utcnow)
    information = Column(String(300))

