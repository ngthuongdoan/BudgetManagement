CREATE DATABASE BudgetManagement;
USE BudgetManagement;

CREATE TABLE users (
	username VARCHAR(50) PRIMARY KEY,
	email VARCHAR(50) NOT NULL,
	fullname VARCHAR(50) NOT NULL,
	password VARCHAR(MAX) NOT NULL,
	avatar IMAGE NOT NULL,
);

CREATE TABLE wallets (
	username VARCHAR(50) NOT NULL REFERENCES users(username),
	walletName VARCHAR(50) NOT NULL,
	amount FLOAT NOT NULL,
	icon IMAGE NOT NULL,
	CONSTRAINT PK_WALLETS PRIMARY KEY(username, walletName),
);

CREATE TABLE transactions (
	id INT IDENTITY(1,1) PRIMARY KEY,
	username VARCHAR(50) NOT NULL,
	walletName VARCHAR(50) NOT NULL,
	categogyName VARCHAR(50) NOT NULL REFERENCES categogies(categogyName),
	transactionType VARCHAR(50) NOT NULL,
	transactionValue FLOAT NOT NULL,
	transactionNote VARCHAR(MAX),
	transactionTIME DATETIME NOT NULL,
	FOREIGN KEY (username,walletName) REFERENCES wallets (username,walletName),
	--FOREIGN KEY categogyName) REFERENCES categogies(categogyName),
);
alter table transactions nocheck constraint FK__transacti__categ__60A75C0F
CREATE TABLE categogies (
	categogyName VARCHAR(50) PRIMARY KEY,
	categogyImage IMAGE NOT NULL,
);