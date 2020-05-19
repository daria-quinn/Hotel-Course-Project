CREATE PROCEDURE  verificationLogin  -- проверка по логину
    @Login nchar(50),
	@Count int output
AS   
	SET @Count = (select COUNT(*)
					FROM Users
					WHERE @Login = Login)
GO
CREATE PROCEDURE  verificationLoginAndPassword -- проверка существования пользователя по логину и паролю
    @Login nchar(50),
	@Password nchar(50),
	@Count int output
AS   
	SET @Count = (select COUNT(*)
					FROM Users
					WHERE @Login = Login AND @Password = Password)
GO  

CREATE PROCEDURE  addUser -- добавление нового пользователя
    @Login nchar(50),
	@Password nchar(50)
AS   
DECLARE @Count int
	SET @Count = (select top 1 UserID
					FROM Users
					ORDER BY UserID DESC) + 1
	INSERT INTO Users(UserID, Login,Password) 
	VALUES (@Count, @Login, @Password);

GO  


CREATE PROCEDURE  checkingUser --проверка существования пользователя
    @Login nchar(50),
	@Count int output
AS   
	SET @Count = (select count(*)
					FROM Users
					WHERE @Login = Login)


EXEC addUser @Login = 'user2',@Password  = 111
GO
DROP PROCEDURE  addDocument
CREATE PROCEDURE  addDocument--добавление документа для отдыхающего
    @Login nchar(50),
	@Passport nchar(10),
	@FirstName nchar(30),
	@LastName nchar(30),
	@SecondName nchar(30)
AS   
DECLARE @Count int
	SET @Count = (select top 1 GuestsID
					FROM Guests
					ORDER BY GuestsID DESC) + 1
	INSERT INTO Guests(GuestsID, Users,Passport,FirstName,LastName,SecondName) 
	VALUES (@Count, (Select UserID
					From Users
					Where @Login = Login), @Passport,@FirstName,@LastName,@SecondName);
GO


CREATE PROCEDURE enterDocument --вставка документа
     @login nchar(50)
AS
SELECT Guests.Passport
FROM Guests
WHERE Guests.Users = (SELECT Users.UserID
										FROM Users
										WHERE Users.Login = @login)

GO

CREATE procedure seachDocument --поиск по документу
	@passport nchar(10)
AS 
SELECT FirstName,LastName,SecondName
			 FROM Guests
			 WHERE @passport= Passport

GO

CREATE PROCEDURE  checkingDocument --
    @Login nchar(50),
	@Count int output
AS   
	SET @Count = (select count(*)
					FROM Guests
					WHERE Users = (Select UserID
									From Users
									Where Login = @Login))

GO  

CREATE PROCEDURE  checkingDocumentForPassport
    @LastName nchar(50),
	@Passwport nchar(20),
	@Count int output
AS   
	SET @Count = (select count(*)
					FROM Guests
					WHERE Guests.LastName = @LastName AND @Passwport = Passport)

GO 

CREATE PROCEDURE  addRecordInHotel --добавление новой записи в таблицу Записи 
    @number int,
	@login nchar(50),
	@numberDocument nchar(10),
	@discont int,
	@clubCard int,
	@BeginDate Date,
	@EndDate Date,
	@Cost money,
	@EndCost money
AS   
DECLARE @Count int
	SET @Count = (select top 1 RecordID
					FROM Records
					ORDER BY RecordID DESC) + 1
	INSERT INTO Records(RecordID,HotelRoom, Discount, ClubCard, Guests,  StartDate, EndDate, Cost, EndCost) 
	VALUES (@Count,(select HotelRoomID
					from HotelRoom
					WHERE HotelRoom.Number = @number),

					(SELECT DiscountID
					FROM Discount
					Where Discount.Discount = @discont),

					(Select ClubCard.CardID
					From ClubCard
					Where ClubCard.CardID = @clubCard),

					(Select Guests.GuestsID
					From Guests
					WHERE @numberDocument = Guests.Passport AND 
					Guests.Users = (SELECT Users.UserID
									FROM Users
									WHERE Login = @login)),
					
					@BeginDate, @EndDate, @Cost, @EndCost);

GO  


CREATE PROCEDURE  checkingFreeSpace--проверка свободных мест на выбранную дату
    @FirstDate date,
	@SecondDate date
AS  
SELECT Number, Type, DATEDIFF(day,@FirstDate,@SecondDate) * RoomType.Cost
FROM HotelRoom Join RoomType
On HotelRoom.RoomType = RoomType.TypeID LEFT JOIN Records
On HotelRoom.HotelRoomID = Records.HotelRoom
	Where @FirstDate < Records.StartDate AND @SecondDate <Records.StartDate OR  @FirstDate > Records.EndDate AND @SecondDate > Records.EndDate
	OR Records.StartDate is NULL and Records.EndDate is NULL
GO
EXEC checkingFreeSpace @FirstDate = '2019-12-10', @SecondDate = '2020-01-30'

DROP PROCEDURE calculationDiscount

CREATE PROCEDURE  calculationDiscount --подсчёт скидки
    @FirstDate datetime,
	@card int,
	@FDiscount int OUTPUT
AS   
DECLARE @count int, @cardDiscount int, @Discont int
SET @Discont = 0;
SET @count = (SELECT count(*)
				FROM Discount
				Where DATEDIFF(day,GETDATE(),@FirstDate) < Discount.DiscountStart AND DATEDIFF(day,GETDATE(),@FirstDate) >= Discount.DiscountEnd);
if (@count > 0 ) 
begin
SET @Discont = (SELECT Discount.Discount  
				FROM Discount
				Where DATEDIFF(day,GETDATE(),@FirstDate) < Discount.DiscountStart AND DATEDIFF(day,GETDATE(),@FirstDate) >= Discount.DiscountEnd);
SET @cardDiscount = (SELECT ClubCard.CardDiscount
				FROM ClubCard
				WHERE ClubCard.CardID = @card);
SET @FDiscount = @Discont+@cardDiscount;
end
else
begin
SET @cardDiscount = (SELECT ClubCard.CardDiscount
				FROM ClubCard
				WHERE ClubCard.CardID = @card);
SET @FDiscount = @cardDiscount;
end

GO


CREATE PROCEDURE  replaceDiscont --подсчёт цены со скидкой
    @DISCONT int,
	@REPLACE money,
	@ReplaceResult money OUTPUT
AS
SET @ReplaceResult = (100 - @DISCONT) * @REPLACE / 100

GO

SELECT *
FROM ClubCard


CREATE PROCEDURE addCard
	@CardId int,
	@DateOfIssue date,
	@cardDiscount int
AS
	INSERT INTO  ClubCard(CardID, DateOfIssue, CardDiscount)
	VALUES (@CardId, @DateOfIssue, @cardDiscount)
	
CREATE PROCEDURE checkCard --проверка существования такой же карты
	@CardID int,
	@Count int output
AS   
	SET @Count = (select count(*)
					FROM ClubCard
					WHERE @CardID = CardID)

CREATE PROCEDURE enterCard --вставка карты
     @CardID int,
	 @ID int output
AS
	SET @ID = (SELECT CardID
				FROM ClubCard
				WHERE @CardID = CardID)

 CREATE PROCEDURE addServices
 AS
 SELECT *
 FROM Services

 EXEC addServices

 CREATE PROCEDURE  discountForServices --подсчёт цены для услуги со скидкой
  @card int,
  @FDiscount int OUTPUT
AS
 SET @FDiscount = (SELECT ClubCard.CardDiscount
				FROM ClubCard
				WHERE ClubCard.CardID = @card);

CREATE PROCEDURE searchRecord
 @passport nchar(10)

 AS
 SELECT top 1 RecordID
 FROM Records INNER JOIN Guests ON Records.Guests = Guests.GuestsID
 WHERE Passport = @passport AND EndDate > GETDATE()

 EXEC searchRecord '6119765420'

 ALTER TABLE HaveTheUseOf ADD CostOfService MONEY NULL;
  ALTER TABLE HaveTheUseOf
  DROP COLUMN CostOfService

 DROP PROCEDURE addRecordOfService
 CREATE PROCEDURE addRecordOfService
 @nService int,
 @nRecord int
-- @cost money
 AS
 INSERT INTO HaveTheUseOf(Records,Services)
 VALUES (@nRecord, @nService)

 EXEC addRecordOfService 4, 5

 CREATE PROCEDURE ProofOfPurchaseInfAboutRecords
 @nRecord int
 AS
 SELECT FirstName, SecondName, LastName, Passport,Records.Cost, Discount, EndCost, HotelRoom, RoomType.Type, StartDate, EndDate, ClubCard
 FROM Records INNER JOIN Guests ON Records.Guests = Guests.GuestsID
 INNER JOIN HotelRoom ON Records.HotelRoom = HotelRoom.Number
 INNER JOIN RoomType ON HotelRoom.RoomType=RoomType.TypeID
 WHERE RecordID = @nRecord

 CREATE PROCEDURE ProofOfPurchaseInfAboutUsers
 @nRecord int
 AS
 SELECT Users
 FROM Records INNER JOIN Guests ON Guests = GuestsID
 WHERE RecordID = @nRecord

 DROP PROCEDURE getRecordID
 CREATE PROCEDURE getRecordID
@nRecord int OUTPUT
 AS
 SET @nRecord = (SELECT top 1 RecordID
					FROM Records
					ORDER BY RecordID DESC)

DECLARE @n int
EXEC getRecordID  @n OUTPUT
PRINT(@n)