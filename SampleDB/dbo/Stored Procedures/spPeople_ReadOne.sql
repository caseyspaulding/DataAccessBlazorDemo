CREATE PROCEDURE [dbo].[spPeople_ReadOne]
	@Id int
AS
BEGIN

	SELECT * FROM dbo.People
	WHERE Id = @Id

END
