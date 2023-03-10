USE [Product_SP_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_Product_Update]    Script Date: 30.01.2023 09:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_Product_Update]
@ProductID int,
@ItemName nvarchar(50),
@Color nvarchar(50),
@Status nvarchar(50),
@ExpiryDate datetime
as
begin
Update ProductInfo_Tab set ItemName=@ItemName,Color=@Color,Status=@Status,ExpiryDate=@ExpiryDate where ProductID=@ProductID
end



create proc SP_Product_Delete
@ProductID int
as
begin
Delete ProductInfo_Tab where ProductID=@ProductID
end