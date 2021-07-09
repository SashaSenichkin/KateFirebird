CREATE TABLE Breeds(
	Id integer generated by default as identity primary key,
	PRIMARY KEY (Id)
	Name nchar(50) NULL,
	AvgProduction float NULL,
	AvgWeight float NULL,
	DietId int NULL
)

CREATE TABLE Cells(
	Id integer generated by default as identity primary key,
	PRIMARY KEY (Id)
	DepartmentNum int NULL,
	RowNum int NULL,
	CellNum int NULL,
	WorkerId int NULL
)
ALTER TABLE Cells ADD  CONSTRAINT FK_Workers_Cells FOREIGN KEY(WorkerId) REFERENCES Workers (Id)


SET QUOTED_IDENTIFIER ON
CREATE TABLE Chickens(
	Id integer generated by default as identity primary key,
	PRIMARY KEY (Id)
	Weight float NULL,
	Age int NULL,
	BreedId int NULL,
	EddCount int NOT NULL,
	CellId int NULL 
) 
ALTER TABLE Chickens  ADD CONSTRAINT FK_Chickens_Breeds FOREIGN KEY(BreedId) REFERENCES Breeds (Id)
ALTER TABLE Chickens  ADD CONSTRAINT FK_Chickens_Cells FOREIGN KEY(CellId) REFERENCES Cells (Id)



SET QUOTED_IDENTIFIER ON
CREATE TABLE Workers(
	Id integer generated by default as identity primary key,
	PRIMARY KEY (Id)
	FullName nchar(100) NULL,
	Salary float NULL
)
ALTER TABLE Workers ADD  CONSTRAINT FK_Workers_Workers FOREIGN KEY(Id) REFERENCES Workers (Id)

