CREATE DATABASE QuanLyQuanCaPheNTN
GO

USE QuanLyQuanCaPheNTN
GO

--Food
--Table
--FoodCategory
--Account
--Bill
--BillInfo


CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) not null DEFAULT N'Chưa được đặt tên',
	status NVARCHAR(100) not null DEFAULT N'Trống', --None||Full
)
GO 


CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY not null,
	DisplayName NVARCHAR(100) not null DEFAULT N'Nhân viên',
	PassWord NVARCHAR(1000) not null DEFAULT  ,
	Type INT not null DEFAULT 0
)
GO 

alter table Account add constraint DF_Password default N'0' for PassWord

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) not null DEFAULT N'Chưa được đặt tên',
)
GO



CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) not null DEFAULT N'Chưa được đặt tên',
	idCategory INT not null,
	price FLOAT not null DEFAULT 0 

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO
ALTER TABLE Food ADD CONSTRAINT fk_htk_id_Category FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id) ON DELETE CASCADE;

update dbo.TableFood set status = N'Trống'
alter table dbo.Bill add totalPrice float
CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE not null DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT not null,
	discount int  DEFAULT  0,
	status INT not null DEFAULT 0 --1: da thanh toan|| 0: chua thanh toan

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

ALTER TABLE Bill ADD CONSTRAINT fk_htk_id_table FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id) ON DELETE CASCADE;


CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT not null,
	idFood INT not null,
	count INT not null DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

INSERT INTO dbo.Account 
(
	UserName, 
	DisplayName, 
	PassWord, 
	Type
)
VALUES 
(
	N'SEcon',
	N'Nguyễn Chí Cường',
	N'1',
	1
)


INSERT INTO dbo.Account 
(
	UserName, 
	DisplayName, 
	PassWord, 
	Type
)
VALUES 
(
	N'Staff1',
	N'Nhân Viên',
	N'1',
	0
)
GO


CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
as
begin
	select *from dbo.Account where UserName = @userName
end
go

exec dbo.USP_GetAccountByUserName @userName = N'SEcon'
GO


select * from dbo.Account where UserName = N'Secon' AND PassWord = N'1'
GO

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

--thêm bàn
DECLARE @i INT = 0
WHILE @i <= 10
BEGIN
	INSERT dbo.TableFood (name)
	VALUES (N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO

EXEC dbo.USP_GetTableList
GO

create PROC USP_InsertBill
@idTable INT 
AS
BEGIN
	INSERT dbo.Bill (DateCheckIn, DateCheckOut, idTable, status, discount)
	VALUES (GETDATE(), null, @idTable ,0,0)
END
GO



UPDATE dbo.TableFood SET STATUS = N'Có Người' WHERE id = 9
--UPDATE dbo.TableFood SET STATUS = N'Trống' WHERE id = 10
GO



--thêm category
INSERT dbo.FoodCategory(name) values(N'Thức uống')
INSERT dbo.FoodCategory(name) values(N'Kẹo')
INSERT dbo.FoodCategory(name) values(N'Mứt trái cây')
INSERT dbo.FoodCategory(name) values(N'Bánh ngọt')
GO
--thêm food
INSERT dbo.Food(name, idCategory, price) values(N'Bánh chuối hạnh nhân',4,25000)
INSERT dbo.Food(name, idCategory, price) values(N'Bánh oreo hạnh nhân',4,15000)
INSERT dbo.Food(name, idCategory, price) values(N'Bánh kếp mật ong',4,30000)
INSERT dbo.Food(name, idCategory, price) values(N'Kẹo gừng',2,15000)
INSERT dbo.Food(name, idCategory, price) values(N'Kẹo bảy vị',2,15000)
INSERT dbo.Food(name, idCategory, price) values(N'Mứt đào',3,25000)
INSERT dbo.Food(name, idCategory, price) values(N'Mứt dâu',3,25000)
INSERT dbo.Food(name, idCategory, price) values(N'Cà phê Ngọc Trai Núi',1,20000)
INSERT dbo.Food(name, idCategory, price) values(N'Cà phê phin',1,20000)
INSERT dbo.Food(name, idCategory, price) values(N'Cà phê phin sữa',1,25000)
GO
--thêm bill
INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) 
values(getdate(),null,1,1)
INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) 
values(getdate(),null,2,0)
INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) 
values(getdate(),null,3,0)
INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) 
values(getdate(),null,4,7)
INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status) 
values(getdate(),getdate(),5,1)
GO
--thêm billinfo
INSERT dbo.BillInfo(idBill, idFood, count) 
values(1,3,2)
INSERT dbo.BillInfo(idBill, idFood, count) 
values(1,1,5)
INSERT dbo.BillInfo(idBill, idFood, count) 
values(1,2,3)
INSERT dbo.BillInfo(idBill, idFood, count) 
values(2,5,4)
INSERT dbo.BillInfo(idBill, idFood, count) 
values(3,6,1)
INSERT dbo.BillInfo(idBill, idFood, count) 
values(3,4,1)
GO


create proc USP_InsertBillInfo
@idBill int, @idFood int, @count int
as
	begin
		declare @isExitsBillInfo int;
		declare @foodCount int = 1
		select @isExitsBillInfo = id, @foodCount = count
		from dbo.BillInfo
		where idBill = @idBill and idFood = @idFood

		if(@isExitsBillInfo > 0 )
			begin
				declare @newCount int = @foodCount + @count
				if (@newCount > 0) 
				begin
				UPDATE dbo.BillInfo set count = @foodCount + @count where idFood = @idFood
				end
				else
				begin
				delete dbo.BillInfo where idBill = @idBill  and idFood = @idFood
				end
			end
		else 
			begin
				insert dbo.BillInfo (idBill, idFood, count)
				values ( @idBill, @idFood, @count)
			end
	end
GO

create trigger UTG_UpdateBillInfo
on dbo.BillInfo for insert, update as
begin
	declare @idBill int
	select @idBill = idBill from inserted
	declare @idTable int
	select @idTable = idTable from dbo.Bill where id = @idBill and status = 0
	declare @count int
	select @count = count(*) from dbo.BillInfo where idBill = @idBill
	if (@count > 0 )
		update dbo.TableFood set status = N'Có người' where id = @idTable
	else 
		update dbo.TableFood set status = N'Trống' where id = @idTable
	 
end
GO



create trigger UTG_UpdateBill
on dbo.Bill for delete, update as
begin
	declare @idBill int
	select @idBill = id from inserted
	declare @idTable int
	select @idTable = idTable from dbo.Bill where id = @idBill  and status = 1
	
	declare @count int = 0
	select @count = COUNT(*) from dbo.BillInfo where idBill = @idBill 
	if(@count > 0)
		update dbo.TableFood set status = N'Trống' where id = @idTable

	
end
GO




create proc USP_GetListBillByDate
@checkIn date, @checkOut date
as begin 

select t.name as [Tên bàn], b.totalPrice as [Tổng tiền], DateCheckIn as [Thời gian vào quán], DateCheckOut as [Thời gian ra khỏi quán], discount as [Giảm giá]
	from dbo.Bill as b, dbo.TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1
	and t.id = b.idTable 
end
go

exec USP_GetListBillByDate '20230501' , '20230530'



--code chuyển
create procedure USP_SwitchTable
@BanCu int,@BanMoi int
AS
BEGIN
    -- Kiểm tra xem bàn cũ có khách hàng không
    IF (SELECT COUNT(*) FROM Bill WHERE idTable = @BanCu) > 0
    BEGIN
        -- Chuyển khách hàng sang bàn mới
        UPDATE Bill SET idTable = @BanMoi WHERE idTable = @BanCu
        -- Cập nhật trạng thái bàn
        UPDATE TableFood SET status = N'Có người' WHERE ID = @BanMoi
        UPDATE TableFood SET status = N'Trống' WHERE ID = @BanCu
		-- Cap nhat soluong neu trung


        -- Trả về kết quả thành công
        SELECT 'Chuyển khách hàng thành công'
    END
    ELSE
    BEGIN
        -- Trả về lỗi nếu bàn cũ không có khách hàng
        SELECT 'Bàn cũ không có khách hàng'
    END
END
----code gộp
Create PROC USP_CombineTable
@idTable1 int,@idTable2 int
AS
BEGIN
	Declare @idFirstBill int
	Declare @idSecondBill int
	Declare @isFirstTableEmpty int = 1
	Declare @isSecondTableEmpty int = 1
	--Lấy ra BillID của Bill chưa thanh toán trên 2 bàn cần gộp vào nhau
	Select @idSecondBill = Id from Bill Where IdTable = @idTable2 And Status = 0
	Select @idFirstBill = Id from Bill Where IdTable = @idTable1 And Status = 0

	--Nếu 2 bàn đều có người thì mới tiến hành gộp
	IF(@idFirstBill != 0 AND @idSecondBill != 0)
		BEGIN
			--Gộp bàn thứ 1 vào bàn thứ 2 bằng cách thay BillID trong bảng BillInfo
			UPDATE BillInfo SET IdBill = @idSecondBill WHERE IdBill = @idFirstBill

			--Khi gộp bàn sẽ xuất hiện các món trùng lặp với nhau
			--Tạo con trỏ và lấy ra các FoodID với số lần trùng lặp
			DECLARE BillInfoCursor CURSOR FOR SELECT IdFood, count(*) AS 'Count' FROM BillInfo WHERE IdBill = @idSecondBill GROUP BY IdFood
			OPEN BillInfoCursor

			DECLARE @foodID INT
			DECLARE @count INT

			FETCH NEXT FROM BillInfoCursor INTO @foodID, @count

			WHILE @@FETCH_STATUS = 0
				BEGIN
					--Trường hợp @count > 1 tức là món này bị trùng nhau, xuất hiện hơn 1 lần
					IF(@count > 1) 
						BEGIN
							DECLARE @finalFoodCount INT = 0
							--Tính gộp tổng các FoodCount của món này
							SELECT @finalFoodCount = SUM(count) FROM BillInfo WHERE IdBill = @idSecondBill AND IdFood = @foodID
			
							DECLARE @maxID INT = 0
							--Lấy ra max ID của món này để tí nữa giữ lại, các ID khác xoá hết cho khỏi trùng nhau
							SELECT @maxID = MAX(ID) FROM BillInfo WHERE IdBill = @idSecondBill AND IdFood = @foodID

							--update số lượng món ăn cho ID này
							UPDATE BillInfo SET count = @finalFoodCount WHERE IdBill = @idSecondBill AND IdFood = @foodID AND ID = @maxID --Cài nhiều điều kiện cho chắc kèo

							--Xoá các ID còn lại
							DELETE BillInfo WHERE IdBill = @idSecondBill AND IdFood = @foodID AND ID != @maxID
						END

					FETCH NEXT FROM BillInfoCursor INTO @foodID, @count
				END

			CLOSE BillInfoCursor
			DEALLOCATE BillInfoCursor
		END
		Select @isFirstTableEmpty =  COUNT (*) from BillInfo where IdBill = @idFirstBill
		Select @isSecondTableEmpty =  COUNT (*) from BillInfo where IdBill = @idSecondBill
		Print '------'
		Print @isFirstTableEmpty
		Print @isSecondTableEmpty
	If(@isFirstTableEmpty = 0)
		Begin
			Update TableFood set Status = N'Trống' where Id = @idTable1
			Delete Bill where IdTable = @idTable1 And Status = 0
		End
	If(@isSecondTableEmpty = 0)
		Begin
			Update TableFood set Status = N'Trống' where Id = @idTable2
			Delete Bill where IdTable = @idTable2 And Status = 0
		End
END
GO

CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN

		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO

create TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS 
BEGIN
	
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted
	
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count INT = 0
	
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
select * from dbo.Food where dbo.fuConvertToUnsign1(name) like N'%keo%'
select * from dbo.Food

select * from dbo.Account


CREATE PROC USP_GetListBillByDateAndPage
@checkIn date, @checkOut date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows
	
	;WITH BillShow AS( SELECT b.ID, t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN (SELECT TOP (@exceptRows) id FROM BillShow)
END
GO

CREATE PROC USP_GetNumBillByDate
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO


CREATE proc USP_GetListBillByDateForReport
@checkIn date, @checkOut date
as begin 

select t.name , b.totalPrice, DateCheckIn , DateCheckOut , discount 
	from dbo.Bill as b, dbo.TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1
	and t.id = b.idTable 
end
go

exec USP_GetListBillByDateForReport '20230501' , '20230530'


