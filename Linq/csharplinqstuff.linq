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
	orderby x.ReleaseYear
	select new
	{
		Title = x.Title,
		Label = x.ReleaseLabel == null ? "Unknown" : 
				x.ReleaseLabel
	};
results2.Dump();

// a list of albums show the title and decade of release. Albums from 1970 to 79 are 70s;
var results3 = from x in Albums
orderby x.ReleaseYear
select new
{
	Title = x.Title,
	Decade = x.ReleaseYear >= 1970 && x.ReleaseYear <= 1979 ? "70s" :
			(x.ReleaseYear >= 1980 && x.ReleaseYear <= 1989 ? "80s" : 
				(x.ReleaseYear >= 1990 && x.ReleaseYear <= 1999 ? "90s" : "Modern")
			) 
};

results3.Dump(); 

var resultaverage = (from x in Tracks
	select x.Milliseconds).Average();
	
resultaverage.Dump();

var results4 = from x in Tracks
	select new
	{
		Song = x.Name,
		Length = x.Milliseconds > resultaverage ? "Long" :
			(x.Milliseconds < resultaverage ? "Short" : "Average")
	};
results4.Dump();

//Aggregates
//.Sum(), .Count(), Min(), .Max(), .Average()
//aggregates must be done against a collection of 0,1 or more rows
var results5 = from x in Albums
	select new
	{
		Title = x.Title,
		Artist = x.Artist.Name,
		TrackCount = x.Tracks.Count()
	};
results5.Dump();

//create a list of artist with their album counts
//ordered descending album count
var results6 = from x in Artists
	orderby x.Albums.Count() descending
	select new {
		Name = x.Name,
		Count = x.Albums.Count()
	};
	
results6.Dump();


//find max number of albums for all artists? idk what that even means though? like who has the most?
var results7 = (from x in Artists
	select x.Albums.Count()).Max();
results7.Dump();

var results7b = from x in Artists
	where x.Albums.Count() == results7
	select x;
results7b.Dump();
results7.Dump();

var results7c = from x in Artists
	where x.Albums.Count() == (from y in Artists select y.Albums.Count()).Max()
	select x;
results7c.Dump();


//prodcuce a list of albums which have tracks showing their title artists number of tracks on album,  total price of
//all tracks, longest track, shortest track, and average track.

var tracksinfo = from x in Albums
				where x.Tracks.Count() > 0
				select new
				{
					Title = x.Title,
					Artsit = x.Artist.Name,
					NumberOfTracks = (from y in x.Tracks select y).Count(),
					methodNumberOfTracks = x.Tracks.Count(),//seems easier
					Cost = x.Tracks.Sum(y => y.UnitPrice),//
					LongestTrack = x.Tracks.Max(y => y.Milliseconds),
					ShortestTrack = x.Tracks.Min(y => y.Milliseconds),
					AverageTrack = x.Tracks.Average(y => y.Milliseconds)				
				};
tracksinfo.Dump();


//list all the Playlists which have a least one track
//show the playlist name, number of tracks, cost and total storage size

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
				





