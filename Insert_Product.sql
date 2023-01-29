create proc SP_Product_Insert
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