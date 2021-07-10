CREATE TABLE Breeds(
	Id integer primary key
	Name nchar(50),
	AvgProduction float,
	AvgWeight float,
	DietId int
);

CREATE TABLE Workers(
	Id integer primary key,
	FullName nchar(100),
	Salary float
)

CREATE TABLE Cells(
	Id integer primary key,
	DepartmentNum int,
	RowNum int,
	CellNum int,
	WorkerId int
);
ALTER TABLE Cells ADD  CONSTRAINT FK_Workers_Cells FOREIGN KEY(WorkerId) REFERENCES Workers (Id);


CREATE TABLE Chickens(
	Id integer primary key,
	Weight float,
	Age int,
	BreedId int,
	EggCount int NOT NULL,
	CellId int 
) ;
ALTER TABLE Chickens  ADD CONSTRAINT FK_Chickens_Breeds FOREIGN KEY(BreedId) REFERENCES Breeds (Id);
ALTER TABLE Chickens  ADD CONSTRAINT FK_Chickens_Cells FOREIGN KEY(CellId) REFERENCES Cells (Id);




