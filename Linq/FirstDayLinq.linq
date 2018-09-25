<Query Kind="Expression">
  <Connection>
    <ID>52188365-4973-4deb-aeed-448e694d44d8</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

//query syntax
from rowPlaceholder in Albums
where rowPlaceholder.ArtistId.Equals("22")
orderby rowPlaceholder.ReleaseYear, rowPlaceholder.Title descending
select rowPlaceholder
