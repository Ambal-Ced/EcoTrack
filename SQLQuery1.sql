insert into info(ids,fname,mname,lname,type_, conto, email,password) values 
(0,'Arthur','L','Pendragon','Household','9012138692','arthur12@gmail.com','arthur12');


insert into electrates(sepa,ids, kwrate, totbillelec,dates1 ) values (0,0,4.5,2200.75,'01/27/2024')
insert into waterrates(sepb,ids, cbrate, totbillwater,dates2 ) values (0,0,2.5,1200.75,'01/29/2024')

SET IDENTITY_INSERT info ON;
SET IDENTITY_INSERT electrates OFF;
SET IDENTITY_INSERT ecotrack ON;
SET IDENTITY_INSERT waterrates OFF;
ALTER TABLE info
ALTER COLUMN conto BIGINT;

select * from info;
select * from electrates;
select * from waterrates;

SET IDENTITY_INSERT electrates ON;

INSERT INTO electrates (sepa, ids, kwrate, totbillelec, dates1)
VALUES (0, 0, 4.5, 2200.75, '01/27/2024');
