use localdb;

select * from Report;

select * from Drivers where driverName = 'Hill';

select * from Cars where markCode = 1 and releaseYear > 2010;

select * from Cars where releaseYear = 2005 or releaseYear = 2007 or releaseYear = 2012;

select * from Models where payloadCapacity is null;

select * from Drivers where driverSurname like 'X%' and driverSurname like '%l';
