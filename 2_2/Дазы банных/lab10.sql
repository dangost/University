DELIMITER |
create trigger deleteReportTrigger before delete on Report
FOR EACH ROW BEGIN
   INSERT INTO Log set statusCode = 'delete', _datetime=CURRENT_TIMESTAMP;
END;

DELIMITER |
create trigger isNotNull before update on Report
for each row begin
	IF OLD.returnDate = null THEN 
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'returndate cant be null'; 
    END IF;
end;

DELIMITER |
create trigger insertReportTrigger before insert on Report
FOR EACH ROW BEGIN
   INSERT INTO Log set statusCode = 'insert', _datetime=CURRENT_TIMESTAMP;
END;

DELIMITER |
create trigger updateReportTrigger before update on Report
FOR EACH ROW BEGIN
   INSERT INTO Log set statusCode = 'update', _datetime=CURRENT_TIMESTAMP;
END;


use localdb;

insert into Report (carId, driverId, dateOfExport, timeOfExport, cargoWeight, returnDate, distanse)
values (1, 1, "2020-02-02", "15:00", 50, "2021-10-04", 200);

update Report  set distanse = 228331 where travelId = 10;

delete from Report where travelId = 10;

select * from Log;