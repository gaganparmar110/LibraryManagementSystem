USE [LibraryDb]
GO
/****** Object:  StoredProcedure [dbo].[spFineCalculate]    Script Date: 15-03-2020 23:16:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spFineCalculate]
@ReturnDate datetimeoffset, @IssueDate datetimeoffset, @BookIssueId int
as
begin
declare @current datetime
set @current=GETDATE()

SELECT DATEDIFF(day, @ReturnDate, @current) * 10 as fine  from BookIssues
WHERE DATEDIFF(day, @IssueDate, @current) > 4 and BookIssueId=@BookIssueId

end

exec spFineCalculate '2020-03-13 12:05:38.4830000 +00:00','2020-03-10 12:05:38.4830000 +00:00',1
