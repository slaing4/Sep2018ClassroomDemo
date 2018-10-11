<Query Kind="Program">
  <Connection>
    <ID>52188365-4973-4deb-aeed-448e694d44d8</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

void Main()
{
	//Create a list of albums showing its title and artist.
	//Show albums with 25 or more tracks only.
	//For each album show the songs on the album and their length.
	
	var results = from x in Albums
				  where x.Tracks.Count() > 24
				  select new AnAlbum
				{
					artist = x.Artist.Name,
					title = x.Title,
					songs = (from y in x.Tracks
					        select new Song
							{
								songname = y.Name,
								length = y.Milliseconds/60000 + ":" +
								           (y.Milliseconds%60000)/1000
							}).ToList()
				};
	results.Dump();
}

// Define other methods and classes here
//Song is the POCO
public class Song
{
 	public string songname{get;set;}
 	public string length{get;set;}
}
//AnAlbum is the DTO. It has structure (a set of data on each instance
//   of the class.
public class AnAlbum
{
	public string artist{get;set;}
	public string title{get;set;}
	public List<Song> songs{get;set;}
}



//list of employees and the clients they support

var employeelist = from x in Employees
					where x.Title.Contains("Support")
					orderby x.LastName, x.FirstName
					select new 
					{
						Name = x.LastName + ", " + x.FirstName,
						ClientCount = x.SupportRepIdCustomers.Count(),
						ClientList = from y in x.SupportRepIdCustomers
										orderby y.LastName, y.FirstName
										select new {
											lastname = y.LastName,
											firstname = y.FirstName,
											Phone = y.Phone
										}
						
					};
		
employeelist.Dump();


















