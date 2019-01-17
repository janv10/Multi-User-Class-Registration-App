create table Students (
	NID	INT IDENTITY(1,1) Primary key, 
	lname 	nvarchar(250) not null,
	fname	nvarchar(250) not null,
	netid	nvarchar(64) not null 	
); 

create table Courses (
	DID 	nvarchar(64) not null, 
	CID	INT not null, 
	SID 	nvarchar(64) not null, 
	Year_	INT not null, 
	CRN 	INT PRIMARY KEY, 
	TID 	nvarchar(64) not null, 
	Day_	nvarchar(64) not null, 
	Time_	nvarchar(250) not null,
	Cap	INT not null,
	Registered INT 
); 