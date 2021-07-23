USE [ClinicService]
GO

--===================
--Author: Sokolovskiy Alexander
--Date: 23.07.21
--Description: Добавляет расписание для пользователя
--===================

CREATE PROCEDURE AddNewScheduleForUser
	@MondayBegining TIME,
	@MondayEnding TIME,
	@TuesdayBegining TIME,
	@TuesdayEnding TIME,
	@WednesdayBegining TIME,
	@WednesdayEnding TIME,
	@ThursdayBegining TIME,
	@ThursdayEnding TIME,
	@FrydayBegining TIME,
	@FrydayEnding TIME,
	@SaturdayBegining TIME,
	@SaturdayEnding TIME,
	@SundayBegining TIME,
	@SundayEnding TIME,
	@ActualisationDate DATE,
	@UserId INT
AS

INSERT INTO dbo.Schedules(
		UserId,
		Monday_Begining, 
		Monday_Ending, 
		Tuesday_Begining,
		Tuesday_Ending,
		Wednesday_Begining,
		Wednesday_Ending,
		Thursday_Begining,
		Thursday_Ending,
		Friday_Begining,
		Friday_Ending,
		Saturday_Begining,
		Saturday_Ending,
		Sunday_Begining,
		Sunday_Ending,
		Actualisation_Date)
	VALUES(
		@UserId,
		@MondayBegining,
		@MondayEnding,
		@TuesdayBegining,
		@TuesdayEnding,
		@WednesdayBegining,
		@WednesdayEnding,
		@ThursdayBegining,
		@ThursdayEnding,
		@FrydayBegining,
		@FrydayEnding,
		@SaturdayBegining,
		@SaturdayEnding,
		@SundayBegining,
		@SundayEnding,
		@ActualisationDate)

