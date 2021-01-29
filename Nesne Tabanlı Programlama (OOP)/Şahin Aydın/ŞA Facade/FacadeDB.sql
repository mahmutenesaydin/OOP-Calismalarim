Create database FacadeDB
go
use FacadeDB
go

create table Customer
(
	ID int primary key Identity,
	FirstName varchar(20),
	LastName varchar(20),
)

go

create table Banks
(
	BankID int primary key Identity,
	CustomerID int,
	CustomerAmount money
)

go

create table Credits
(
	CreditID int primary key Identity,
	CustomerID int,
	CreditAmount money
)

go

Create table Loans
(
	LoanID int primary key Identity,
	CustomerID int,
	LoanAmount money
)








