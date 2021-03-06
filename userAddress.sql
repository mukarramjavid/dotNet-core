USE [UserWebApp]
GO
/****** Object:  StoredProcedure [dbo].[usp_UserAddress]    Script Date: 9/21/2020 12:48:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[usp_UserAddress] 
	@cityName nvarchar(MAX),
	@userIDFK int
AS
BEGIN
	if exists(select 1 from tbl_Address ad where ad.userID = @userIDFK)
		
		Begin
			
			update tbl_Address set city_name = @cityName
				   where userID=@userIDFK
				   select @userIDFK as UserFK
		End

	else
		
		Begin
			
			insert into tbl_Address (city_name,userID)

				values
							(@cityName,@userIDFK)

			select SCOPE_IDENTITY() as AddressID

		End


END
