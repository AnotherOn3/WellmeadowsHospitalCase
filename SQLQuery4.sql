-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE CreateStaff 
@FName nvarchar(50),
@LName nvarchar(50),
@StaffNumber int,
@TypeOfShift nvarchar(50),
@Address nvarchar(50),
@PhoneNumber nvarchar(50),
@DateOfBirth date,
@Gender nvarchar(50),
@Insurance nvarchar(50),
@ContractId int,
@PositionId int,
@WardId int

AS
BEGIN
INSERT INTO Staff (FName, LName, StaffNumber, TypeOfShift, Address, PhoneNumber, DateOfBirth, Gender, Insurance, ContractId, PositionId, WardId)
values (@FName, @LName, @StaffNumber, @TypeOfShift, @Address, @PhoneNumber, @DateOfBirth, @Gender, @Insurance, @ContractId, @PositionId, @WardId)
END
GO
