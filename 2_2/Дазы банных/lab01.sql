drop database localdb;
create database localdb;
use localdb;

create table Drivers(
	driverId int not null primary key auto_increment,
    driverName text,
    driverSurname text,
    driverCode int,
    driverDOB text
    );
    
create table Models(
	modelId int not null primary key auto_increment,
    modelName text,
    payloadCapacity int);

create table Cars(
	carId int not null primary key auto_increment,
    modelCode int,
    releaseYear int,
    markCode int not null,
    carNum int,
    foreign key (carNum) references Models(modelId) 
    );
    
create table Report(
	travelId int primary key auto_increment,
    carId int not null,
    driverId int not null,
    dateOfExport date not null,
    timeOfExport time,
    cargoWeight int,
    returnDate date not null,
    distanse int,
    foreign key (carId) references Cars(carId),
    foreign key (driverId) references Drivers(driverId)    
);

insert into Models (modelName, payloadCapacity)
value ("Tesla Model X", 100);
insert into Models (modelName, payloadCapacity)
value ("Tesla Model A", 1000);
insert into Models (modelName, payloadCapacity)
value ("Tesla Model B", 1233);
insert into Models (modelName, payloadCapacity)
value ("Tesla Model C", 1245);
insert into Models (modelName, payloadCapacity)
value ("Tesla Model Y", 4666);
insert into Models (modelName, payloadCapacity)
value ("Tesla Model Z", 41414);

insert into Drivers (driverName, driverSurname, driverCode, driverDOB)
values ("John", "Wake", 228, '05-06-2002');
insert into Drivers (driverName, driverSurname, driverCode, driverDOB)
values ("Kill", "Real", 228, "08-07-2003");
insert into Drivers (driverName, driverSurname, driverCode, driverDOB)
values ("Dan", "Equal", 228, "09-01-2005");
insert into Drivers (driverName, driverSurname, driverCode, driverDOB)
values ("Hill", "Hil", 228, "25-08-2007");
insert into Drivers (driverName, driverSurname, driverCode, driverDOB)
values ("Title", "Leak", 228, "14-12-2008");
insert into Drivers (driverName, driverSurname, driverCode, driverDOB)
values ("Json", "Xml", 228, "17-11-2010");
insert into Drivers (driverName, driverSurname, driverCode, driverDOB)
values ("Billy", "Hil", 228, "12-10-2021");

insert into Cars (modelCode, releaseYear, markCode, carNum)
values (228, 2002, 4, 1);
insert into Cars (modelCode, releaseYear, markCode, carNum)
values (213, 2003, 1, 2);
insert into Cars (modelCode, releaseYear, markCode, carNum)
values (5454, 2010, 2, 3);
insert into Cars (modelCode, releaseYear, markCode, carNum)
values (246, 2077, 1, 4);
insert into Cars (modelCode, releaseYear, markCode, carNum)
values (246, 2077, 3, 5);
insert into Cars (modelCode, releaseYear, markCode, carNum)
values (246, 2077, 3, 6);
insert into Cars (modelCode, releaseYear, markCode, carNum)
values (246, 2077, 3, 1);

insert into Report (carId, driverId, dateOfExport, timeOfExport, cargoWeight, returnDate, distanse)
values (1, 1, "2020-02-02", "15:00", 50, "2021-05-02", 200);
insert into Report (carId, driverId, dateOfExport, timeOfExport, cargoWeight, returnDate, distanse)
values (1, 4, "2020-04-02", "15:00", 150, "2021-10-02", 500);
insert into Report (carId, driverId, dateOfExport, timeOfExport, cargoWeight, returnDate, distanse)
values (2, 1, "2021-02-02", "15:00", 200, "2021-05-03", 850);
insert into Report (carId, driverId, dateOfExport, timeOfExport, cargoWeight, returnDate, distanse)
values (3, 1, "2021-10-03", "15:00", 170, "2021-10-04", 1500);
insert into Report (carId, driverId, dateOfExport, timeOfExport, cargoWeight, returnDate, distanse)
values (1, 4, "2021-01-05", "15:00", 200, "2021-05-08", 750);
insert into Report (carId, driverId, dateOfExport, timeOfExport, cargoWeight, returnDate, distanse)
values (3, 2, "2021-04-07", "15:00", 1000, "2021-11-08", 600);
insert into Report (carId, driverId, dateOfExport, timeOfExport, cargoWeight, returnDate, distanse)
values (1, 1, "2021-08-07", "15:00", 300, "2021-10-09", 800);
insert into Report (carId, driverId, dateOfExport, timeOfExport, cargoWeight, returnDate, distanse)
values (2, 2, "2021-01-09", "15:00", 200, "2021-03-10",400 );
