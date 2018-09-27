<Query Kind="Statements">
  <Connection>
    <ID>52188365-4973-4deb-aeed-448e694d44d8</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

//using the stament language environment, we code complete C# statments which include the linq query and a recieveing variable.
//The stamtents will end with the semi-colon(;)
//To see the contents of the recieving variable, you will use the .Dump

var results = from x in Albums
where x.Artist.Name.Contains("U2")
orderby x.ReleaseYear
select new 
{
	Artist = x.Artist.Name,
	Year = x.ReleaseYear
};
results.Dump();


//ternary operator
//conditions(s) ? true value : false value
var results2 = from x in Albums
	orderby x.ReleaseLabel
	select new
	{
		Title = x.Title,
		Label = x.ReleaseLabel == null ? "Unknown" : 
				x.ReleaseLabel
	};
results2.Dump();