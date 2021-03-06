USE [UserWebApp]
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertUser]    Script Date: 9/18/2020 6:26:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   proc [dbo].[usp_InsertUser]
-- EXEC usp_InsertUser '1015','asif','asif@yahoo.com','123', 0303425541,27
@userId int,
@userName nvarchar(MAX),
@userEmail nvarchar(MAX),
@userPwd nvarchar(MAX),
@userPhone int,
@userAge int,
@userImage nvarchar(MAX)

	AS
Begin 
		if exists(select 1 FROM tbl_Users where user_email=@userEmail) 
		BEGIN
			update tbl_Users set user_email=@userEmail,
								 user_pwd=@userPwd,
								 user_name=@userName,
								 user_phone=@userPhone,
								 user_age=@userAge,
								 user_ImagePath=@userImage

							where 
								user_id=@userId
								select @userId AS Id

		END
		else
		BEGIN
			Insert into tbl_Users 
								  (user_email,user_name,user_pwd,user_phone,user_age,user_ImagePath)
						 values		
								  (@userEmail, @userName,@userPwd,@userPhone,@userAge,@userImage)



			

	   select SCOPE_IDENTITY() AS Id
	END
	--select SCOPE_IDENTITY()
End
