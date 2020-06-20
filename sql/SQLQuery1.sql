/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [username]
      ,[password]
      ,[email]
  FROM [BudgetManagement].[dbo].[users]

  drop table users

  create table users (
	username varchar(50) primary key,
	email varchar(50) not null,
	fullname nvarchar(MAX) not null,
	password varchar(MAX) not null,
	avatar image,
 )

  SELECT * FROM users WHERE username = 'ngthuongdoan'