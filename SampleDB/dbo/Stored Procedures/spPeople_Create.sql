CREATE PROCEDURE [dbo].[spPeople_Create]
	@Firstname nvarchar(50),
	@Lastname nvarchar(50),
	@DateOfBirth datetime2(7)
	
AS
begin
	set nocount on;

	insert into dbo.People
	(FirstName,LastName,DateOfBirth) values (@Firstname,@Lastname,@DateOfBirth);
	end