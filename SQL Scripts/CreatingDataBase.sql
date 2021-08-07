--=======================
--AUTHOR: SOKOLOVSKII ALEXANDER
--CREATE DATE:21.07.2021
--DESCRIPTION: —Œ«ƒ¿≈“ ¡¿«” ƒ¿ÕÕ€’ » “¿¡À»÷€
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
	WHERE TABLE_NAME = 'TypesOfRequests')
BEGIN
	CREATE TABLE TypesOfRequests
	(
		[Id] INT NOT NULL,
		[Name] NVARCHAR(150) NOT NULL,
		[IsActive] BIT
	
		CONSTRAINT PK_TypesOfRequests PRIMARY KEY(Id)
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
		[Id_Depends] INT,
		[IsActive] BIT
	
		CONSTRAINT PK_Rights PRIMARY KEY(Id),
		CONSTRAINT FK_Rights_to_Rights FOREIGN KEY(Id_Depends) REFERENCES Rights(Id)
	)
END

GO
IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'Roles')
BEGIN
	CREATE TABLE Roles
	(
		[Id] INT NOT NULL,
		[Name] NVARCHAR(150) UNIQUE NOT NULL,

		CONSTRAINT PK_Roles PRIMARY KEY(Id)
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
		[SubordinateId] INT

		CONSTRAINT PK_Departments PRIMARY KEY(Id),
		CONSTRAINT FK_Departments_to_Departments FOREIGN KEY(SubordinateId) REFERENCES Departments(Id)
	)
END

GO
IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'Politics')
BEGIN
	CREATE TABLE Politics
	(
		[RoleId] INT NOT NULL,
		[RightId] INT NOT NULL,
		[RightIsActive] BIT NOT NULL

		CONSTRAINT FK_Clearance_To_ClearanceLevel FOREIGN KEY(RoleId) REFERENCES Roles(Id),
		CONSTRAINT FK_Clearance_To_Rights FOREIGN KEY(RightId) REFERENCES Rights(Id)
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
		[DepartmentId] INT NOT NULL

		CONSTRAINT PK_Position PRIMARY KEY(Id)
		CONSTRAINT FK_Position_To_Department FOREIGN KEY(DepartmentId) REFERENCES Departments(Id)
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
		[Login] NVARCHAR(100) UNIQUE NOT NULL,
		[Pass_Hash] NVARCHAR(MAX) NOT NULL,
		[EMail] NVARCHAR(100),
		[Position_Id] INT,
		[RoleId] INT
		
		CONSTRAINT PK_Users PRIMARY KEY(Id),
		CONSTRAINT FK_Users_To_Position FOREIGN KEY(Position_Id) REFERENCES Position(Id),
		CONSTRAINT FK_Users_To_Role FOREIGN KEY(RoleId) REFERENCES Roles(Id)
	)
END

GO
IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'Avatars')
BEGIN
	CREATE TABLE Avatars
	(
		[UserId] INT NOT NULL,
		[Photo] IMAGE NOT NULL

		CONSTRAINT FK_Avatars_To_Users FOREIGN KEY(UserId) REFERENCES Users(Id)
	)
END

IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'Schedules')
BEGIN
	CREATE TABLE Schedules
	(
		[UserId] INT NOT NULL,
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

		CONSTRAINT FK_Schedules_To_Users FOREIGN KEY(UserId) REFERENCES Users(Id),
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
		[Date_Of_Complete] DATETIME2,
		[Status] BIT

		CONSTRAINT PK_Requests PRIMARY KEY(Id),
		CONSTRAINT FK_RequestsSender_To_Users FOREIGN KEY(Sender_Id) REFERENCES Users(Id),
		CONSTRAINT FK_RequestsReciever_To_Users FOREIGN KEY(Reciever_Id) REFERENCES Users(Id),
		CONSTRAINT FK_Requests_To_Types FOREIGN KEY(Type_Id) REFERENCES TypesOfRequests(Id)
	)
END

IF not exists(SELECT * FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = 'Sessions')
BEGIN
	CREATE TABLE Sessions
	(
		[Id] INT NOT NULL,
		[Client_Id] INT NOT NULL,
		[Doctor_Id] INT NOT NULL,
		[DateTimeOfBegin] DATETIME2 NOT NULL,
		[DateTimeOfEnding] DATETIME2 NOT NULL

		CONSTRAINT PK_Sessions PRIMARY KEY(Id),
		CONSTRAINT FK_Client_To_Users FOREIGN KEY(Client_Id) REFERENCES Users(Id),
		CONSTRAINT FK_Doctor_To_Users FOREIGN KEY(Doctor_Id) REFERENCES Users(Id),
	)
END
