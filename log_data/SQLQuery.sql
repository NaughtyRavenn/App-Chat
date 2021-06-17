USE AppChat

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

