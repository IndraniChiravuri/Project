use Bank;

create procedure addCustomer
@custName varchar(30),
@gender varchar(3),
@dob varchar(20),
@address varchar(60),
@state varchar(20),
@city varchar(20),
@pincode varchar(10),
@phoneNo varchar(10),
@email varchar(30),
@createdDate varchar(20),
@editedDate varchar(20),
@userId varchar(20)
as
insert into Customer values(@custName, @gender, @dob, @address, @state, @city, @pincode, @phoneNo, @email, @createdDate, @editedDate, @userId)

create procedure addLogin
@userId varchar(20),
@password varchar(20),
@role varchar(10)
as
insert into Login values(@userId, @password, @role)

create procedure deleteCustomer
@custId int
as
delete from Customer where customerId = @custId

create procedure getAllCustomers
as
select * from Customer

create procedure getSpecificCustomer
@custId int
as
select * from Customer where customerId = @custId

create procedure updateCustomer
@custId int,
@custName varchar(30),
@gender varchar(3),
@dob varchar(20),
@address varchar(60),
@state varchar(20),
@city varchar(20),
@pincode varchar(10),
@phoneNo varchar(10),
@email varchar(30),
@editedDate varchar(20),
@userId varchar(20)
as
update Customer set customerName = @custName, gender = @gender, dob = @dob, address = @address, state = @state,
city = @city, pincode = @pincode, phoneNo = @phoneNo, email = @email, editedDate = @editedDate, userId = @userId
where customerId = @custId

create procedure updateUserID
@newuserId varchar(20),
@olduserId varchar(20)
as
update Login set userId = @newuserId where userId = @olduserId



