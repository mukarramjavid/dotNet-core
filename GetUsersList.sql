USE [UserWebApp]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetUsersList]    Script Date: 9/21/2020 2:37:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[usp_GetUsersList]
as

Begin

select * from tbl_Users  inner join tbl_Address on tbl_Users.user_id=tbl_Address.userID

end

--exec usp_GetUsersList