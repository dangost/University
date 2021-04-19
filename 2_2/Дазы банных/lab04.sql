use localdb;

# Вариант 5
#    1. Список водителей, выезжавших в рейс на прошлой неделе.
#    2. Список автомобилей марки «МАЗ».
#    3. Список автомобилей, выезжавших в рейс на автомобилях МАЗ, ВАЗ или  ГАЗ.
#    4. Фамилию водителей, выезжавшего в рейс максимальной протяженности.
#    5. Список водителей, не выезжавших в рейс за последние 3 дня.

select driverId from Report where dateOfExport between date_sub(now(),interval 1 year) and now();  # result if interval is 1 year

select driverId from Report where carId in (select carId from Cars where carNum = (select modelId from Models where Models.modelName = "Tesla Model A"));

select driverId from Report where carId in (select carId from Cars where carNum in (select modelId from Models where Models.modelName = "Tesla Model A" or Models.modelName = "Tesla Model B" or Models.modelName = "Tesla Model C"));

select driverSurname from Drivers where Drivers.driverId = (
	select driverId from Report where datediff(Report.returnDate, Report.dateOfExport) = 
		(select max(D.diff) as a from (select datediff(Report.returnDate, Report.dateOfExport) as diff from Report) as D));
        
select driverId from Drivers where Drivers.driverId in ( select driverId from Report where dateOfExport not between date_sub(now(),interval 3 day) and now());
                        
                            
                            
                            
                            
                            
                            
                            
                            
                            
                            