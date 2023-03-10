USE [Product_SP_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_Product_Insert]    Script Date: 29.01.2023 18:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_Product_Insert]
@ProductID int,
@ItemName nvarchar(50),
@Color nvarchar(50),
@Status nvarchar(50),
@ExpiryDate datetime
as
begin
insert into ProductInfo_Tab(ProductID,ItemName,Color,Status,ExpiryDate) values
(@ProductID,@ItemName,@Color,@Status,@ExpiryDate)
end


create proc SP_Product_Update
@ProductID int,
@ItemName nvarchar(50),
@Color nvarchar(50),
@Status nvarchar(50),
@ExpiryDate datetime
as
begin
Update ProductInfo_Tab set ItemName=@ItemName,Color=@Color,Status=@Status,ExpiryDate=@ExpiryDate where ProductID=@ProductID
end