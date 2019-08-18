USE [WinFormsApplication]
GO
/****** Object:  StoredProcedure [dbo].[SpInsert]    Script Date: 18-08-2019 14:17:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Sagar R Rajput>
-- Create date: <Create Date,,>
-- Description:	<The stored Procedure to insert the data to CrackersList Table>
-- =============================================
ALTER PROCEDURE [dbo].[SpInsert]
(
@CrackerListTable CrackersTableType READONLY
)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO CrackersList
	SELECT *FROM @CrackerListTable
END
