

CREATE TABLE [dbo].[UserData] (
    [id]                INT            IDENTITY (1, 1) NOT NULL,
    [first_name]        NVARCHAR (50)  NOT NULL,
    [last_name]         NVARCHAR (50)  NOT NULL,
    [computer_name]     NVARCHAR (100) NOT NULL,
    [ip_address]        NVARCHAR (100) NOT NULL,
    [birth_day]         DATE           NOT NULL,
    [cur_date]          DATETIME       NOT NULL,
    [age]               INT            NOT NULL,
    [astrological_sign] NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


CREATE PROCEDURE InsertUserData(
	@first_name NVARCHAR(50),
	@last_name NVARCHAR(50),
	@computer_name NVARCHAR(100),
	@ip_address NVARCHAR(100),
	@birth_day DATE,
	@cur_date DATETIME,
	@age INT,
	@astrological_sign NVARCHAR(50)
	)
AS
BEGIN
	INSERT INTO UserData(
		first_name, 
		last_name, 
		computer_name, 
		ip_address,
		birth_day,
		cur_date,
		age, 
		astrological_sign
	)
	VALUES( 
		@first_name,
		@last_name,
		@computer_name,
		@ip_address,
		@birth_day,
		@cur_date,
		@age,
		@astrological_sign
	)
END
RETURN 0




CREATE PROCEDURE SelectUserData

AS
BEGIN
	SELECT id, first_name, last_name, computer_name, ip_address, birth_day, cur_date, age, astrological_sign
	FROM UserData
RETURN 0
END