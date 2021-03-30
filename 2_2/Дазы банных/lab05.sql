use localdb;

-- Вариант 5
-- Используя операции соединения таблиц построить следующие запросы:

--     1. Составить полную информацию о поездках водителя с заданной фамилией.
--     2. Получить полную информацию о транспорте и водителях, задействованных в поездках на прошлой неделе.
--     3. Составить список марок автомобилей, эксплуатирующихся более 10 лет.
--     4. Составить список водителей, выезжавших на автомобиле заданной марки в прошлом месяце.

-- Используя операции UNION, EXCEPT, INTERSECT построить следующие запросы:
--  
-- 1. Найти однофамильцев среди водителей.
-- 2. Составить список автомобилей, выезжавших в рейс с интервалом менее двух дней.
-- 3. Составить список автомобилей одновременно выезжавших на прошлой неделе. 

select * from Report inner join Drivers on Report.driverId = Drivers.driverId where Drivers.driverSurname = "Syl"; # current surname 

select * from Report inner join Drivers on Report.driverId = Drivers.driverId inner join Cars on Cars.carId = Report.carId inner join Models on Models.modelId = Cars.carNum where Report.dateOfExport between date_sub(now(),interval 1 year) and now();

select Models.modelName from Cars inner join Models on Models.modelId = Cars.carNum where Cars.releaseYear < YEAR(CURDATE()) - 10;

select * from Report inner join Cars on Cars.carId = Report.carId inner join Models on Models.modelId = Cars.carNum where Report.dateOfExport between date_sub(now(),interval 1 year) and now() and Models.modelName = "Tesla Model X";


select Drivers.driverSurname from Drivers GROUP BY Drivers.driverSurname HAVING ( COUNT(Drivers.driverSurname) > 1 );

select Cars.carId from Cars inner join Report on Cars.carId = Report.carId where Report.dateOfExport between date_sub(now(),interval 1 year) and now();

select Cars.carId from Cars inner join Report on Cars.carId = Report.carId where (Report.dateOfExport between date_sub(now(),interval 1 year) and now()) group by Cars.carId having (count(Report.timeOfExport) > 1);

