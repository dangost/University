use localdb;

select releaseYear from Cars group by releaseYear having count(*) < 6;

select min(releaseYear) as minRelease from Cars;

select sum(releaseYear) sumOfReleases from Cars;

select avg(releaseYear) avg_release from Cars where releaseYear > 2000;

# avg car old
select avg(2100 - releaseYear) avg_exp from Cars;

# count cars each mark
select modelCode, count(distinct carId) carCount from Cars group by modelCode;

# sum of km each driver
select driverId, sum(distinct distanse) dist from Report group by driverId;

# driver driver who with max km
select driverId, distanse from Report where  distanse = (select max(distanse) from Report);

# count of session each driver last month
# select driverId, count(travelId) dist from Report group by driverId;
