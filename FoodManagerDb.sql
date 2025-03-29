CREATE DATABASE FoodManagerDb
GO

USE FoodManagerDb
GO 

--Food
--Table
--FoodCategory
--UserAccount
--Bill
--BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bản chưa đặt tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	--TRỐNG || CÓ NGƯỜI 
)
GO

CREATE TABLE UserAccount
(
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'HitKer',
	UserName NVARCHAR(100) PRIMARY KEY,
	Password NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) DEFAULT N'Chưa đặt tên',
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL	-- 1: ĐÃ THANH TOÁN || 0: CHƯA THANH TOÁN 

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)

--USERACCONUNT
INSERT INTO UserAccount (Username, DisplayName, Password, Type) VALUES  (N'TuanKiet', N'TuanKiet', '12', 1)
GO
INSERT INTO UserAccount (Username, DisplayName, Password, Type) VALUES  (N'ThaiEm', N'ThaiEm', '1682005', 1)
GO

--TABLEFOOD
SET IDENTITY_INSERT TableFood ON
INSERT INTO TableFood (id, name, status) VALUES (1, 'Bàn 1', 'Trống')
INSERT INTO TableFood (id, name, status) VALUES (2, 'Bàn 2', 'Trống')
INSERT INTO TableFood (id, name, status) VALUES (3, 'Bàn 3', 'Trống')
INSERT INTO TableFood (id, name, status) VALUES (4, 'Bàn 4', 'Trống')
INSERT INTO TableFood (id, name, status) VALUES (5, 'Bàn 5', 'Trống')
INSERT INTO TableFood (id, name, status) VALUES (6, 'Bàn 6', 'Trống')
INSERT INTO TableFood (id, name, status) VALUES (7, 'Bàn 7', 'Trống')
INSERT INTO TableFood (id, name, status) VALUES (8, 'Bàn 8', 'Trống')
INSERT INTO TableFood (id, name, status) VALUES (9, 'Bàn 9', 'Trống')
INSERT INTO TableFood (id, name, status) VALUES (10, 'Bàn 10', 'Trống')
INSERT INTO TableFood (id, name, status) VALUES (11, 'Bàn 11', 'Đang dọn')
INSERT INTO TableFood (id, name, status) VALUES (12, 'Bàn 12', 'Đang dọn')
INSERT INTO TableFood (id, name, status) VALUES (13, 'Bàn 13', 'Trống')
INSERT INTO TableFood (id, name, status) VALUES (14, 'Bàn 14', 'Trống')
INSERT INTO TableFood (id, name, status) VALUES (15, 'Bàn 15', 'Đang dọn')
INSERT INTO TableFood (id, name, status) VALUES (16, 'Bàn 16', 'Trống')
SET IDENTITY_INSERT TableFood OFF
--UPDATE dbo.TableFood SET status = N'Có người' WHERE id = 9
--GO
ALTER TABLE TableFood
ALTER COLUMN status NVARCHAR(200) COLLATE Vietnamese_CI_AS;
UPDATE TableFood
SET status = N'Trống' WHERE status LIKE 'Tr%';
UPDATE TableFood
SET status = N'Có người' WHERE status LIKE 'Có ngu?i';
UPDATE TableFood
SET status = N'Đang dọn' WHERE status LIKE 'Đang d?n';

--thêm food category 
INSERT dbo.FoodCategory (name) VALUES (N'Hải sản') 
GO
INSERT dbo.FoodCategory (name) VALUES (N'Nông sản')
GO
INSERT dbo.FoodCategory (name) VALUES (N'Lâm sản')
GO
INSERT dbo.FoodCategory (name) VALUES (N'Sản sản')
GO
INSERT dbo.FoodCategory (name) VALUES (N'Nước')
GO


--THÊM MÓN ĂN 
INSERT dbo.Food (name, idCategory, price) VALUES (N'Mực một nắng', 1, 120000) 
GO
INSERT dbo.Food (name, idCategory, price) VALUES (N'Nghêu hấp xả', 1, 50000)
GO
INSERT dbo.Food (name, idCategory, price) VALUES (N'Dú dê nước sữa', 2, 150000)
GO
INSERT dbo.Food (name, idCategory, price) VALUES (N'Heo rừng nướng muối ớt', 3, 170000) 
GO
INSERT dbo.Food (name, idCategory, price) VALUES (N'Cơm chiên mushi', 4, 120000) 
GO
INSERT dbo.Food (name, idCategory, price) VALUES (N'7up', 5, 15000) 
GO
INSERT dbo.Food (name, idCategory, price) VALUES (N'Cafe', 5, 20000) 
GO

--THÊM BILL
--INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) VALUES (GETDATE(), NULL, 1, 0)
--GO
--INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) VALUES (GETDATE(), NULL, 2, 0) 
--GO
--INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) VALUES (GETDATE(), GETDATE(), 2, 1) 
--GO
--INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) VALUES (GETDATE(), GETDATE(), 3, 1) 
--GO
--INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) VALUES (GETDATE(), NULL, 4, 1) 
--GO
--INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) VALUES (GETDATE(), GETDATE(), 5, 1) 
--GO
--INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) VALUES (GETDATE(), GETDATE(), 6, 1) 
--GO
--INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) VALUES (GETDATE(), GETDATE(), 7, 0) 
--GO 
--INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) VALUES (GETDATE(), GETDATE(), 8, 1) 
--GO


--THÊM BILL INFO 
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (3, 5, 2) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (3, 4, 4) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (4, 1, 2) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (4, 2, 2) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (4, 6, 1) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (4, 7, 1) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (6, 1, 2) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (6, 2, 2) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (7, 3, 4) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (7, 1, 4) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (7, 6, 4) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (9, 1, 5) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (9, 3, 5) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (9, 4, 3) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (9, 5, 2) 
--GO
--INSERT dbo.BillInfo (idBill, idFood, count) VALUES (9, 6, 5) 
--GO
-- Tạo stored procedure USP_InsertBillInfo
CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
    DECLARE @isExitsBillInfo INT
    DECLARE @foodCount INT = 1

    -- Kiểm tra xem món ăn đã tồn tại trong hóa đơn chưa
    SELECT @isExitsBillInfo = id, @foodCount = b.count
    FROM dbo.BillInfo AS b
    WHERE idBill = @idBill AND idFood = @idFood

    IF (@isExitsBillInfo > 0)
    BEGIN
        DECLARE @newCount INT = @foodCount + @count
        IF (@newCount > 0)
            UPDATE dbo.BillInfo 
            SET count = @newCount 
            WHERE idBill = @idBill AND idFood = @idFood
        ELSE 
            DELETE FROM dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
    END
    ELSE 
    BEGIN
        INSERT INTO dbo.BillInfo (idBill, idFood, count) 
        VALUES (@idBill, @idFood, @count)
    END
END
GO

-- Xóa dữ liệu trong bảng BillInfo và Bill (nếu cần)
DELETE FROM dbo.BillInfo
DELETE FROM dbo.Bill
GO

-- Trigger cập nhật trạng thái bàn khi hóa đơn thay đổi
ALTER TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo 
AFTER INSERT, UPDATE 
AS
BEGIN
    DECLARE @idBill INT 

    SELECT @idBill = idBill FROM Inserted

    DECLARE @idTable INT 

    SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0

    IF (@idTable IS NOT NULL)
    BEGIN
        UPDATE dbo.TableFood 
        SET status = N'Có người' 
        WHERE id = @idTable
    END
END
GO

-- Trigger cập nhật trạng thái bàn khi hóa đơn được cập nhật
ALTER TRIGGER UTG_UpdateBill
ON dbo.Bill 
AFTER UPDATE 
AS
BEGIN
    DECLARE @idBill INT 

    SELECT @idBill = id FROM Inserted

    DECLARE @idTable INT 

    SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

    DECLARE @count INT = 0

    SELECT @count = COUNT(*) FROM dbo.Bill 
    WHERE idTable = @idTable AND status = 0

    IF (@count = 0)
    BEGIN
        UPDATE dbo.TableFood 
        SET status = N'Trống' 
        WHERE id = @idTable
    END
END
GO













--SELECT 
--    f.name AS TenMon, 
--    bi.count AS SoLuong, 
--    f.price AS DonGia, 
--    (bi.count * f.price) AS ThanhTien
--FROM BillInfo bi
--JOIN Bill b ON bi.idBill = b.id
--JOIN Food f ON bi.idFood = f.id
--WHERE b.idTable =  AND b.status = 1;
--GO

--
--DECLARE @i INT = 1
	
--	WHILE @I <= 10
--	BEGIN
--		INSERT dbo.TableFood (name) VALUES (N'Bàn' + CAST (@i AS nvarchar(100)))
--		SET @i = @i + 1
--	END