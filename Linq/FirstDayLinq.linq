<Query Kind="Expression">
  <Connection>
    <ID>52188365-4973-4deb-aeed-448e694d44d8</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

from x in Customers
where x.Country.Equals("USA") &&
	x.Email.Contains("yahoo")
	select new
	{
		FullName = x.LastName + ", " + x.FirstName
	}
	
	

from x in Albums
orderby x.Title
select new
{
	Title = x.Title,
	Year = x.ReleaseYear
}
	