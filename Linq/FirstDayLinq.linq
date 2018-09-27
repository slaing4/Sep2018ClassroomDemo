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

//list albums for u2 showing album and release orderby release year

from x in Albums
where x.Artist.Name.Contains("U2")
orderby x.ReleaseYear
select new 
{
	Artist = x.Artist.Name,
	Year = x.ReleaseYear,
	Album = x.Title
}