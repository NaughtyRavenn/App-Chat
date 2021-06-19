USE AppChat
SET DATEFORMAT dmy 

CREATE TABLE ACCOUNT(
	ID INT IDENTITY(1,1),
	Username varchar(50) NOT NULL,
	Password varchar(50) NOT NULL,
	Name varchar(50) NOT NULL,
	Is_active varchar(10) NOT NULL,
	Is_admin varchar(10) NOT NULL,
)

INSERT INTO ACCOUNT (Username,Password,Name,Is_active,Is_admin) VALUES ('minh1','ngaymai123','Minh1','false','false'), ('tu1','ngaymai123','Tu1','false','false')

CREATE TABLE CONTACT(
	ID INT IDENTITY(1,1),
	ID1 INT NOT NULL,
	ID2 INT NOT NULL,
)

INSERT INTO CONTACT (ID1,ID2) VALUES (1,2)

INSERT INTO ACCOUNT (Username,Password,Name,Is_active,Is_admin) VALUES ('bao1','1','Bao1','false','false'), ('tho1','1','Tho1','false','false')

INSERT INTO ACCOUNT (Username,Password,Name,Is_active,Is_admin) VALUES ('admin','1','ADMIN','false','true')

INSERT INTO CONTACT (ID1,ID2) VALUES (1,3),(1,4)

ALTER TABLE ACCOUNT ADD Birthday DATETIME
ALTER TABLE ACCOUNT ADD PhoneNumber varchar(20)
ALTER TABLE ACCOUNT ADD Email varchar(50)

ALTER TABLE ACCOUNT 
ADD CONSTRAINT PK_ACCOUNT
PRIMARY KEY (ID)

ALTER TABLE CONTACT
ADD CONSTRAINT PK_CONTACT
PRIMARY KEY (ID)

UPDATE ACCOUNT SET Birthday='1/1/1'
UPDATE ACCOUNT SET PhoneNumber='01'
UPDATE ACCOUNT SET Email='Email'

ALTER TABLE ACCOUNT
DROP COLUMN PhoneNumber

ALTER TABLE ACCOUNT ADD Phonenumber varchar(20)

UPDATE ACCOUNT SET Phonenumber='01'

ALTER TABLE ACCOUNT ADD Sex varchar(10)

UPDATE ACCOUNT SET Sex='Male'

ALTER TABLE ACCOUNT
DROP COLUMN Birthday

ALTER TABLE ACCOUNT ADD Birthday DATETIME2
