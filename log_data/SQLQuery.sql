-- =======================================================================
-- Create database template for a SQL Azure database
-- This script will run only in the context of the master database.
-- To manage this database in SQL Server Management Studio, either connect  
-- to the created database, or connect to master.
-- =======================================================================

CREATE DATABASE Test
Use Test

CREATE TABLE ACCOUNT(
	ID INT IDENTITY(1,1),
	Username varchar(50) NOT NULL,
	Password varchar(50) NOT NULL,
	Name varchar(50) NOT NULL,
	Is_active varchar(10) NOT NULL,
	Is_admin varchar(10) NOT NULL,
)

INSERT INTO ACCOUNT (Username,Password,Name,Is_active,Is_admin) VALUES ('minh1','ngaymai123','Minh1','false','false'), ('tu1','ngaymai123','Tu1','false','false')