<Query Kind="Expression">
  <Connection>
    <ID>52188365-4973-4deb-aeed-448e694d44d8</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

//create list of customers that each employee supports
from x in Customers
group x by x.SupportRepIdEmployee into g
select new{
	FirstName = g.Key.FirstName,
	LastName = g.Key.LastName,
	Phone = g.Key.Phone,
	CustomerList = from y in g
		select new{
			Name = y.FirstName,
			Phone = y.Phone
		}
}



//if you have a navigational property between the tables it should be your first line of attack
//if you do not have a navigational property you can do a join of your tables
//assume for this example there is no navigational property between artists and albums

//the first table to be referenced should be the main processing data pile
//the other table(s) are the supporting piles
from x in Albums
join y in Artists on x.ArtistId equals y.ArtistId
select new
{
Title = x.Title,
Year = x.ReleaseYear,
Label = x.ReleaseLabel == null ? "unknown" : x.ReleaseLabel,
Artist = y.Name,
TrackCount = x.Track.Count()
}

