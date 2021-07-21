--=======================
--AUTHOR: SOKOLOVSKII ALEXANDER
--CREATE DATE:21.07.2021
--DESCRIPTION: ������� ���� ������ � �������
--=======================

IF NOT EXISTS(SELECT * FROM SYS.DATABASES
	WHERE NAME = 'ClinicService')

BEGIN
	CREATE DATABASE ClinicService
END
GO

USE [ClinicService]

GO
IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'Avatars')
BEGIN
	CREATE TABLE Avatars
	(
		[Id] INT NOT NULL,
		[Photo] IMAGE NOT NULL

		CONSTRAINT PK_Avatars PRIMARY KEY(Id)
	)
END

GO
IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'TypesOfRequests')
BEGIN
	CREATE TABLE TypesOfRequests
	(
		[Id] INT NOT NULL,
		[Name] NVARCHAR(150) NOT NULL
	
		CONSTRAINT PK_TypesOfRequests PRIMARY KEY(Id)
	)
END

IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'Schedules')
BEGIN
	CREATE TABLE Schedules
	(
		[Id] INT NOT NULL,
		[Monday_Begining] TIME,
		[Monday_Ending] TIME,
		[Tuesday_Begining] TIME,
		[Tuesday_Ending] TIME,
		[Wednesday_Begining] TIME,
		[Wednesday_Ending] TIME,
		[Thursday_Begining] TIME,
		[Thursday_Ending] TIME,
		[Friday_Begining] TIME,
		[Friday_Ending] TIME,
		[Saturday_Begining] TIME,
		[Saturday_Ending] TIME,
		[Sunday_Begining] TIME,
		[Sunday_Ending] TIME,
		[Actualisation_Date] DATE NOT NULL

		CONSTRAINT PK_Schedules PRIMARY KEY(Id)
	)
END


GO
IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'Rights')
BEGIN
	CREATE TABLE Rights
	(
		[Id] INT NOT NULL,
		[Name] NVARCHAR(150) NOT NULL,
		[Id_Depends] INT
	
		CONSTRAINT PK_Rights PRIMARY KEY(Id),
		CONSTRAINT FK_Rights_to_Rights FOREIGN KEY(Id_Depends) REFERENCES Rights(Id)
	)
END

GO
IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'Departments')
BEGIN
	CREATE TABLE Departments
	(
		[Id] INT NOT NULL,
		[Name] NVARCHAR(150) NOT NULL,
		[Description] NVARCHAR(MAX) NOT NULL,
		[Id_Depends] INT

		CONSTRAINT PK_Departments PRIMARY KEY(Id),
		CONSTRAINT FK_Departments_to_Departments FOREIGN KEY(Id_Depends) REFERENCES Departments(Id)
	)
END

GO
IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'ClearanceLevel')
BEGIN
	CREATE TABLE ClearanceLevel
	(
		[Id] INT NOT NULL,
		[Name] NVARCHAR(150) UNIQUE NOT NULL,

		CONSTRAINT PK_ClearanceLevel PRIMARY KEY(Id)
	)
END

GO
IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'Clearance')
BEGIN
	CREATE TABLE Clearance
	(
		[Id_Level] INT NOT NULL,
		[Id_Right] INT NOT NULL,
		[RightIsActive] BIT NOT NULL

		CONSTRAINT FK_Clearance_To_ClearanceLevel FOREIGN KEY(Id_Level) REFERENCES ClearanceLevel(Id),
		CONSTRAINT FK_Clearance_To_Rights FOREIGN KEY(Id_Right) REFERENCES Rights(Id)
	)
END

GO
IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'Position')
BEGIN
	CREATE TABLE Position
	(
		[Id] INT NOT NULL,
		[Name] NVARCHAR(100) NOT NULL,
		[Department_Id] INT NOT NULL,
		[Clearance_Level_Id] INT NOT NULL,

		CONSTRAINT PK_Position PRIMARY KEY(Id)
	)
END

GO
IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'Users')
BEGIN
	CREATE TABLE Users
	(
		[Id] INT NOT NULL,
		[Name] NVARCHAR(100) NOT NULL,
		[Login] NVARCHAR(100) NOT NULL,
		[Pass_Hash] NVARCHAR(MAX) NOT NULL,
		[EMail] NVARCHAR(100),
		[Avatar_Id] INT,
		[Schedule_Id] INT,
		[Position_Id] INT
		
		CONSTRAINT PK_Users PRIMARY KEY(Id),
		CONSTRAINT KF_Users_To_Schedule FOREIGN KEY(Schedule_Id) REFERENCES Schedules(Id),
		CONSTRAINT FK_Users_To_Position FOREIGN KEY(Position_Id) REFERENCES Position(Id),
		CONSTRAINT FK_USERS_To_Avatar FOREIGN KEY(Avatar_Id) REFERENCES Avatars(Id)
	)
END

GO
IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'Requests')
BEGIN
	CREATE TABLE Requests
	(
		[Id] INT NOT NULL,
		[Sender_Id] INT NOT NULL,
		[Reciever_Id] INT NOT NULL,
		[Type_Id] INT NOT NULL,
		[Content] NVARCHAR(MAX),
		[Date_Of_Create] DATETIME2 NOT NULL,
		[Date_Of_Complete] DATETIME2

		CONSTRAINT PK_Requests PRIMARY KEY(Id),
		CONSTRAINT FK_RequestsSender_To_Users FOREIGN KEY(Sender_Id) REFERENCES Users(Id),
		CONSTRAINT FK_RequestsReciever_To_Users FOREIGN KEY(Reciever_Id) REFERENCES Users(Id),
		CONSTRAINT FK_Requests_To_Types FOREIGN KEY(Type_Id) REFERENCES TypesOfRequests(Id)
	)
END

