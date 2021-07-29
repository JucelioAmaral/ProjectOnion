Create Database DatabaseProjectOnion

use DatabaseProjectOnion
go

Create Table Category(
    Id int IDENTITY(1,1) PRIMARY KEY,     
    Description varchar(255) NOT NULL    
)

Create Table Course(
    Id int IDENTITY(1,1) PRIMARY KEY,
    SubjectDescription varchar(255) NOT NULL,   
    StartDate datetime NOT NULL,   
	EndDate datetime NOT NULL,   
	NumberStudents int,   
	IdCategory int,
    CONSTRAINT fk_Category FOREIGN KEY (IdCategory) REFERENCES Category (Id)    
)
