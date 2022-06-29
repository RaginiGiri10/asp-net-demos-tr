
create table Users(
Id int primary key identity(1,1),
UserName varchar(50) ,
[Password] varchar(100)
)

go

create procedure spRegisterUser
@userName varchar(50),
@password varchar(100)
as 
begin

declare @countOfExistingUser int
declare @returnCode int

select @countOfExistingUser= Count(@userName) from Users  where UserName=@userName

if(@countOfExistingUser >0)
begin
set @returnCode =-1;
end
else
begin 

insert into Users values (@userName,@password)
set @returnCode = 1;
end

select @returnCode as ReturnValue;
end

go

exec spRegisterUser 'Johny@test.com','Test1234'

go
select * from Users