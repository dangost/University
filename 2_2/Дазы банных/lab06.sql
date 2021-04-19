-- Вариант 5
--     1. Создать таблицу «Дальние поездки»  и с помощью запроса внести в нее данные о выездах автомобилей на срок более 3-х дней. 
-- 			Вывести созданную таблицу.  
--     2. В таблицу «Автомобили»  добавить поле «Год поступления»  и с помощью запроса внести в это поле данные, считая,
-- 			что автомобиль поступил на предприятие через 2 года после выпуска. Вывести таблицу «Автомобили».
--     3. Проиндексировать таблицу «Автомобили» по полям «Год выпуска» и «Номер».
--     4. Удалить из таблицы «Автомобили» данные об автомобилях со сроком эксплуатации более 20 лет.
--     5. Удалить из таблицы «Водители» данные о водителях старше 65 лет.

use localdb;

create table LongJourneys as select * from Report where datediff(Report.returnDate, Report.dateOfExport) < 3;
select * from LongJourneys;
drop table LongJourneys;

alter table Cars add column admissionYear int;
update Cars set Cars.admissionYear = Cars.releaseYear + 2;
select * from Cars;
alter table Cars drop column admissionYear;

create index CarsIndex on Cars(releaseYear, carNum);
alter table Cars drop index CarsIndex;

delete from Cars where year(now()) - Cars.releaseYear  > 20;
select * from Cars;

delete from Drivers where year(now()) - year(Drivers.driverDOB) > 65;
select * from Drivers;