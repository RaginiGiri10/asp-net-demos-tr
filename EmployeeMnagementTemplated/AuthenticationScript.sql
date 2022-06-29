create procedure spAuthenticateUser
@userName varchar(50),
@password varchar(100)
as 
begin

declare @countOfExistingUser int
declare @returnCode int

select @countOfExistingUser= Count(@userName) from Users  where UserName=@userName and Password =@password

if(@countOfExistingUser = 1)
begin
set @returnCode =1;
end
else
begin 

set @returnCode = -1;
end

select @returnCode as ReturnValue;
end

go

