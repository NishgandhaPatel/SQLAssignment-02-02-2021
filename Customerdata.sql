use DotNetAssignment
CREATE TABLE tblBankCustomer (
		CId int not null PRIMARY KEY identity(1,1),
		CName varchar(30),
		DOB Date,
		City varchar(20)
)

select * from tblBankCustomer
truncate table tblBankCustomer
INSERT into tblBankCustomer VALUES ('Shane Watson', '04-Apr-1949', 'Sydney')
INSERT into tblBankCustomer VALUES ('David Warner', '31-May-1980', 'Dubai')
INSERT into tblBankCustomer VALUES ('Sachin Tendulkar', '12-Jun-1991', 'Mumbai')
INSERT into tblBankCustomer VALUES ('Virat Kohli', '18-Dec-1988', 'Delhi')
