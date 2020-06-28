DROP PROcEDURE IF EXISTS insertOrderItem;

GO

CREATE PROCEDURE insertOrderItem
@orderId INT,
@productId INT,
@delivaryDate DATETIME = GETDATE,
@price MONEY,
@discount FLOAT,
@isPartial BIT = 0,
@amount INT
AS

BEGIN
	DECLARE @orderNumber INT
	SELECT TOP 1 @orderNumber = oit.ItemNumber + 1 FROM OrderItems oit WHERE oit.ORderID = @orderId ORDER BY oit.ItemNumber  DESC

	INSERT INTO OrderItems
		VALUES(@orderId, ISNULL(@orderNumber, 1), @productId, @delivaryDate, @price, @discount, @isPartial)

	INSERT INTO OrderItemAmounts
		VALUES(@orderId, ISNULL(@orderNumber, 1), @amount, 1)
END;