Create procedure [dbo].[Personne2](
	@last varchar(max),
	@first varchar(max),
	@date datetime2(7),
	@phone varchar(max)
	)
	as
	begin
		Insert into Personne values (@last,@first,@date,@phone)
	End