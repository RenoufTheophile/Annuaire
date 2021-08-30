Create procedure [dbo].[Personne](
	@last varchar(max),
	@first varchar(max),
	@date datetime2(7),
	@phone varchar(max),
	@service varchar(max))
	as
	begin
		Insert into Personne values (@last,@first,@date,@phone,@service)
	End