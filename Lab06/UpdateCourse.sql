USE [School]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCourse]    Script Date: 26/09/2021 11:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[UpdateCourse]
		@CourseID int,
		@Title nvarchar(50),
		@Credits int,
		@DepartmentID int
		AS
		UPDATE Course SET Title=@Title,
				Credits=@Credits,
				DepartmentID=@DepartmentID
		WHERE CourseID=@CourseID;