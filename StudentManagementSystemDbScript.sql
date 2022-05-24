Use Master;
Drop Database If Exists SMS;

-- Create the Student Management System Database
Create Database SMS;
Go
Use SMS;
Go

Create Table Student
(
	StudentId       int            Primary Key Identity(1, 1) Not Null
	,FName          varchar(40)    Not Null
	,LName          varchar(40)    Not Null
	,DateOfBirth    date           Not Null
)