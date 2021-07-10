-- количество яиц получаемое от курицы данного веса, породы, возраста;
Select EggCount from Chickens where age = 0 and BreedId = 1 and Weight between 1 and 2;

-- цех, с наибольшим количеством кур определенной породы;
Select ce.DepartmentNum, COUNT(*) as chickensCnt from Cells ce
join Chickens ch on ch.CellId = ce.Id
where ch.BreedId = 1
group by ce.DepartmentNum
order by chickensCnt

-- в каких клетках сидят двухлетние куры с диетой номер 2;
select ce.DepartmentNum, ce.RowNum, ce.CellNum from Cells ce
join Chickens ch on ch.CellId = ce.Id
where ch.Age = 1 and ch.BreedId = 2

-- сколько яиц в день приносят куры указанной работницы;
select ch.EggCount from Cells ce
join Chickens ch on ch.CellId = ce.Id
where ce.WorkerId = 1

-- в каком цехе находится клетка, из которой получают больше всего яиц.
select ce.DepartmentNum from Cells ce
join Chickens ch on ch.CellId = ce.Id
where ch.EggCount = (select MAX(eggcount) from Chickens)

-- добавление информации о новой курице;
insert into Chickens
values ((select COUNT(*) from Chickens), 1, 2, 3, 4, 5)

-- изменение БД в связи с увольнением работника;
Delete from workers where FullName = ''

-- изменение веса курицы.
update Chickens set Weight = 1 where id = 2

-- выдачи справки о номере диеты для курицы указанной породы 
select DietId from Breeds where id = 1

-- отчета о работе птицефабрики (общее количество кур и их средняя производительность для каждой породы, общее количество яиц, получаемое птицефабрикой, число работниц на фабрике и распределение их по цехам).
select COUNT(*) from Chickens;
select AVG(eggCount) from Chickens group by BreedId;
select SUM(eggCount) from Chickens;
select COUNT(*) from Workers;
select COUNT(*), ce.DepartmentNum  from Workers w join Cells ce on ce.WorkerId = w.Id group by ce.DepartmentNum;