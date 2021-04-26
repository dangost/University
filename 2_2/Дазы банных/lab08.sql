use localdb;
drop procedure if exists getCarNums;
drop procedure if exists Birthdays;
drop procedure if exists CarReports;

# Вариант 5
#    1. Сформировать список  номеров автомобилей заданного года выпуска.
#    2. Сформировать  список  водителей, у которых завтра день рождения.
#    3. Сформировать список поездок автомобиля с заданным номером за прошлый месяц. 
#		Суммарное расстояние, которое проехал этот автомобиль  в прошлом месяце задать выходным параметром.

DELIMITER //
create procedure getCarNums (_releaseYear int)
begin
	select carNum from Cars where releaseYear = _releaseYear;
end //
call getCarNums(2077);

DELIMITER //
create procedure Birthdays ()
begin
	select driverId from Drivers where  driverDOB = curname() + 1;
end //
call Birthdays();

DELIMITER //
create procedure CarReports(_carNum int,  inout sumCapacity int)
begin
	set sumCapacity = (select sum(distanse) as sumCapacity from Report where dateOfExport between date_sub(now(), interval 1 year) and now() and carId = _carNum);
	select * from Report where dateOfExport between date_sub(now(), interval 1 year) and now() and carId = _carNum;
end //

set @counter = 0;
call CarReports(1, @counter);
select @counter;