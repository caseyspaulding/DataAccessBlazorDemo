CREATE PROCEDURE [dbo].[spPeople_Delete]
	@Id int
AS
BEGIN
SET NOCOUNT ON;
	DELETE FROM [dbo].[People]

	WHERE Id = @Id;
END

