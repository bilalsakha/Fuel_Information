-- Query for populating the database with fuel information as required.
DECLARE @i int = 0

WHILE @i < 50
BEGIN
    SET @i = @i + 1
    insert into Fuel (FuelType, FuelPrice, DateModified) values ('Diesel',(FLOOR(RAND()*(200-50+1)+50)), CONCAT((FLOOR(RAND()*(12-1+1)+1)),'/', (FLOOR(RAND()*(30-1+1)+1)), '/', (FLOOR(RAND()*(2019-2000+1)+2000))))
END
