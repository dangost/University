use localdb;

drop function if exists CarYear;
drop procedure if exists CarTable;
drop procedure if exists TimeTable;

# Вариант 5
#    1. Создать скалярную функцию для вычисления возраста автомобиля по вводимому номеру автомобиля.
#    2. Создать табличную  функцию для вывода списка автомобилей, запланированных в рейс на вводимую дату.
#    3. Создать многострочную табличную функцию для формирования 
#		графика выездов на следующую неделю с указанием фамилий водителей, марок и номеров автомобилей.

DELIMITER //
create function CarYear (_carId int) 
returns int
DETERMINISTIC
begin 
  declare dist int;
  set dist = (select releaseYear from Cars where carNum = _carId);
  return year(now()) - dist;
end //

select CarYear(1);


DELIMITER //
create procedure CarTable(_date date)
begin
	select carId from Report where dateOfExport = _date;
end //

call CarTable("2020-02-02");

DELIMITER //
create procedure TimeTable()
begin
	select Report.dateOfExport, Report.timeOfExport, Drivers.driverSurname, Models.modelName, Report.distanse from Report inner join Drivers on Report.driverId = Drivers.driverId 
		inner join Cars on Cars.carId = Report.carId 
		inner join Models on Models.modelId = Cars.carNum 
			where Report.dateOfExport between date_sub(now(),interval 1 month) and now();
end//

call TimeTable();


