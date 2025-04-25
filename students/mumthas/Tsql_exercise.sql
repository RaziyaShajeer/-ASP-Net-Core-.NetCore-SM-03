create database University_system
create table university(uid int primary key,name varchar(20),chancellor varchar(100))
create table dean(deanid int primary key,name varchar(20),dateofbirth datetime)
create table college(cid int primary key,
university int,
dean int,
foreign key(university)references university (uid),
foreign key(dean)references dean(deanid),name varchar(20))

create table department(did int primary key,
college int,
foreign key(college)references college(cid))
select * from department
alter table department
add name varchar(20)h

create table professor(pid int primary key,
department int,
foreign key(department)references department(did),name varchar(20))

create table course(courseid int primary key,
department int,
foreign key(department)references department(did),name varchar(20))
select * from department
create table subject(subjectid int primary key,
course int,
professor int,
foreign key(course)references course(courseid),
foreign key(professor)references professor(pid),
)
alter table subject
add name varchar(50)
select * from subject

create table student(studentid int primary key,
department int,
foreign key(department)references department(did),
name varchar(20),
dateofenrollment smalldatetime,
Telephonenumber varchar(20))

create table student_registration(
student int,
subject int,
foreign key(student)references student(studentid),
foreign key(subject)references subject(subjectid)
)
select* from student_registration

create proc university_insert
(
@v_name as varchar(50),
@v_chancellor as varchar(100))
as
declare @v_uid as int
begin
select @v_uid=(select ISNULL(max(uid),0)+1 from university)
insert into university(uid,name,chancellor)
values(@v_uid,@v_name,@v_chancellor)
end
go
exec university_insert 'XYZ','AKSHAY'
exec university_insert 'ABC','AKSHAY KUMAR'
exec university_insert 'BCD','SMITH'
exec university_insert 'UVW','AKASH'
exec university_insert 'cambridge university','AKASH'

ALTER proc update_university(
@v_uid as int,
@v_name as varchar(50),
@v_chancellor varchar(100))
as
begin
update university SET name='FGH',chancellor='PETER' WHERE UID=1
end
go
exec update_university 5,'XYZ','AKSHAY'
SELECT * FROM university

Create proc delete_university(
@v_uid as int

)
as 
begin
delete from university where uid=2
end 
go

exec delete_university 3



create proc dean_insert(
@v_name as varchar(50),
@v_dateofbirth as datetime)
as
declare @v_deanid as int
begin
select @v_deanid=(select ISNULL(max(deanid),0)+1 from dean)
insert into dean(deanid,name,dateofbirth)
values (@v_deanid,@v_name,@v_dateofbirth)
end 
go


exec dean_insert 'Renuka','1970-01-01'
exec dean_insert 'George','1960-06-01'
select * from dean
alter proc college_insert
(
@v_university as int,
@v_dean as int,
@v_name as varchar(50)
)
as
declare @v_cid as int
begin
select @v_cid=(select ISNULL(max(cid),0)+1 from college)
insert into college(cid,university,dean,name)
values(@v_cid,@v_university,@v_dean,@v_name)
end
go
exec college_insert 1,1,'college of Arts'
exec college_insert 4,2,'college of science'
select * from college
select * from university
select * from dean
alter proc department_insert(

@v_college as int,
@v_name as varchar(50))
as
declare @v_did as int
begin
select @v_did=(select ISNULL(max(did),0)+1 from department)
insert into department(did,college,name)
values(@v_did,@v_college,@v_name)
end 
go
exec department_insert 1,'dept of computerscience'
exec department_insert 2,'dept of physics'
exec department_insert 3,'dept of social'
select * from department
select * from college
alter proc professor_insert
(

@v_department as int,
@v_name as varchar(50))
as
declare @v_pid as int
begin
select @v_pid=(select ISNULL(max(pid),0)+1 from professor)
insert into professor(pid,department,name)
values(@v_pid,@v_department,@v_name)
end
go
exec professor_insert 1,'bob'
exec professor_insert 2,'Alice'
select * from professor
create proc insert_course
(
@v_department as int,
@v_name as varchar(50)
)
as 
declare @v_courseid as int
begin
select @v_courseid=(select ISNULL(max(courseid),0)+1 from course)
insert into course(courseid,department,name)
values (@v_courseid,@v_department,@v_name)
end
go
exec insert_course 1,' computer science'
exec insert_course 2,'english'
select * from course
select * from subject

create proc subjectinsert(

@v_course as int,
@v_professor as int,
@v_name as varchar(50))
as
declare @v_subjectid as int
begin
select @v_subjectid=(select ISNULL(max(subjectid),0)+1 from subject)
insert into subject(subjectid,course,professor,name)
values(@v_subjectid,@v_course,@v_professor,@v_name)
end
go
exec subjectinsert '1','1','english'
exec subjectinsert'1','1','english'

exec subjectinsert '2','2','malayalam'
select * from subject
select * from professor
create proc student_insert
(
@v_department as int,
@v_name as varchar(20),
@v_dateofenrollment as smalldatetime,
@v_telephonenumber as varchar(20))
as
declare @v_studentid as int
begin
select @v_studentid=(select ISNULL(max(@v_studentid),0)+1 from student)
insert into student(studentid,department,name,dateofenrollment,Telephonenumber)
values(@v_studentid,@v_department,@v_name,@v_dateofenrollment,@v_telephonenumber)
end
go
exec student_insert 1,'kumar','2000-06-06','123445566'

create proc studentregistration_insert
(
@v_student as int,
@v_subject as int)
as
begin
insert into student_registration(student,subject)
values(@v_student,@v_subject)
end
go

exec studentregistration_insert 1,1
select * from student
select * from subject
alter PROC GET_STUDENTS
AS
BEGIN
SELECT S.*
from student s
join department d on s.department=d.did
where D.name='dept of computer science'


alter function dbo.get_universityid()

returns bigint
as
begin
declare @v_uid as int
select @v_uid=(select isnull (max(uid),0)+1 from university)
return (@v_uid)
end
select dbo.get_university()

select * from dean
select * from university

select * from college
alter function dbo.get_table()
returns table
as
return
select c.name as collegename,d.name as deanname,u.name as universityname
from college c join dean d
on c.dean=d.deanid
join university u on c.university=u.uid

select dbo.get_table()

alter FUNCTION dbo.get_collegecode() 
	 RETURNS varchar(50) 
	AS  
	BEGIN 

	DECLARE @v_code as varchar(50)
	
SELECT @v_code =(SELECT 'col' + LEFT('00000',5-LEN(LTRIM(STR(RIGHT(MAX(cid),0)+1))))+ LTRIM(STR(RIGHT(MAX(cid),0)+1))   FROM  college) 
		
	RETURN ISNULL(@v_code,'COL'+'00001')
	END
	select dbo.get_collegecode ()
	
	

	create function dbo.get_cambridgeuniversity()
	returns table
	as
	return
	select c.* from college c join university u
	on c.university=u.uid
	where u.name='cambridge university'
	select dbo.get_cambridgeuniversity()

	
	

	CREATE TABLE temp_student (
    StudentID INT,
    Department INT,
    Name VARCHAR(20),
    DateofEnrollment SMALLDATETIME,
    TelephoneNumber VARCHAR(20),
    
)
CREATE TRIGGER trigger_insertstudent
on student
as
begin
INSERT INTO temp_student (StudentID, Department, Name, DateofEnrollment, TelephoneNumber)
    values( StudentID, Department, Name, DateofEnrollment, TelephoneNumber)
	
	from inserted
	end go



	select * from student
	select * from department