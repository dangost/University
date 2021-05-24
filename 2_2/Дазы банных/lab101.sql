use localdb;

insert into Report (carId, driverId, dateOfExport, timeOfExport, cargoWeight, returnDate, distanse)
values (1, 1, "2020-02-02", "15:00", 50, null, 200);

select * from Log;