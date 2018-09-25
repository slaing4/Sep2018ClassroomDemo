<Query Kind="Expression">
  <Connection>
    <ID>52188365-4973-4deb-aeed-448e694d44d8</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

from x in Albums
where x.ReleaseYear >= 2007 &&
      x.ReleaseYear <= 2010
select x