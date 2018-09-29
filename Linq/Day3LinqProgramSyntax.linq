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
		select new PlaylistSummary
		{
			name = x.Name,
			trackcount = x.PlaylistTracks.Count(),
			cost = x.PlaylistTracks.Sum(y => y.Track.UnitPrice),
			storage = x.PlaylistTracks.Sum(y => y.Track.Bytes/1000)
			};
	playlists.Dump();
}

// Define other methods and classes here
public class PlaylistSummary
{
	public string name {get;set;}
	public int trackcount {get;set;}
	public decimal cost {get;set;}
	public double? storage {get;set;} // nullable
}