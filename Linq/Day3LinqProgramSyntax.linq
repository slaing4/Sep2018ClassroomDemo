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
	var playlists = from x in Playlists
		where x.PlaylistTracks.Count() > 0
		select new
		{
			Name = x.Name,
			NumberOfTracks = x.PlaylistTracks.Count(),
			Cost = x.PlaylistTracks.Sum(y => y.Track.UnitPrice),
			Storage = x.PlaylistTracks.Sum(y => y.Track.Bytes/1000)
			};
	playlists.Dump();
}

// Define other methods and classes here
