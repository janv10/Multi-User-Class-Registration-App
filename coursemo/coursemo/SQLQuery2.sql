select NID from students where netid = 'jpate201'; 


insert into Registered(CRN, NID, swp, drp)
values (10631, 36, 0, 0);

select * from Registered; 


update courses set registered = 0
truncate table Registered;


update Registered set drp = 1
where crn = 10631 and nid = 36; 

select CRN, drp, swp from Registered where nid = 36; 

update Courses set Registered = Registered - 1
where crn = 10631;

select * from courses where crn = 10631