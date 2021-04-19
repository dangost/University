use localdb;

# Вариант 5
#    1. Создать представление, содержащее полную информацию о журнале выездов. 
#		С помощью созданного представления определить фамилию водителя,  имеющего наибольший километраж поездок.
#    2. Создать представление, содержащее информацию о количестве выездов по датам.
#		С помощью созданного представления определить  даты, когда число выездов было выше среднего.
#    3. Создать представление, содержащее информацию о  среднем километраже выездов каждого водителя за месяц.
# 		С помощью созданного представления определить  фамилии водителей, имеющих наименьший километраж и наибольший  средний километраж.
#    4. Создать представление, содержащее  информацию об использовании автомобилей за прошедший месяц.
#		С помощью созданного представления определить автомобиль, который имеет максимальное число выездов.


create or replace view ReportView as select Report.travelId, Report.carId, Report.driverId, Report.dateOfExport, Report.timeOfExport, 
											Report.cargoWeight, Report.returnDate, Report.distanse, 
                                            Drivers.driverName, Drivers.driverSurname, Drivers.driverCode, 
                                            Drivers.driverDOB, Cars.modelCode, Cars.markCode, Models.modelName, Models.payloadCapacity 
				from Report inner join Drivers on Report.driverId = Drivers.driverId 
					 inner join Cars on Cars.carId = Report.carId 
                     inner join Models on Models.modelId = Cars.carNum;

select distinct(a.driverSurname) as surname, sum(a.distanse) as dis from (select driverSurname, distanse from ReportView 
		where driverSurname = (select driverSurname from ReportView where distanse = (select max(distanse) from ReportView))) as a group by surname;


create or replace view DateView as select dateOfExport as d, count(*) as cnt from Report group by dateOfExport;
select d from DateView as v where v.cnt > (select avg(cnt) from DateView);

create or replace view DriverView as select Report.driverId, sum(distinct Report.distanse) dist, Drivers.driverSurname 
	from Report inner join Drivers on Report.driverId = Drivers.driverId 
    where Report.dateOfExport between date_sub(now(),interval 1 year) and now() group by driverId;

select * from DriverView where dist = (select min(dist) from DriverView); # min max


create or replace view CarView as select carId, count(*) as cnt from Report where Report.dateOfExport between date_sub(now(),interval 1 year) and now() group by carId;
select * from CarView where cnt = (select max(cnt) from CarView);

