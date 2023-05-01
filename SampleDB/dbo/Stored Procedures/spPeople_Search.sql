CREATE PROCEDURE [dbo].[spPeople_Search]
	@SearchTerm nvarchar(50)
AS
BEGIN
SELECT * FROM People WHERE FirstName LIKE '%' + @SearchTerm + '%' OR LastName LIKE '%' + @SearchTerm + '%'

END
