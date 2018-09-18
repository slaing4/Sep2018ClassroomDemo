﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespace
using Chinook.Data.Entities;
using ChinookSystem.DAL;
using System.ComponentModel;
#endregion

namespace ChinookSystem.BLL
{
    [DataObject]
    public class AlbumController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Album> List_Albums()
        {
            using (var context = new ChinookContext())
            {
                return context.Albums.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Album Album_Find(int albumid)
        {
            using(var context = new ChinookContext())
            {
                return context.Albums.Find(albumid);
            }
        }

        //Get the album(s) by feeding an artist id, uses Linq
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Album> Album_GetByArtistId(int artistid)
        {
            using (var context = new ChinookContext())
            {
                var results = from aRowOn in context.Albums
                              where aRowOn.ArtistId.Equals(artistid)
                              select aRowOn;


                return results.ToList();
            }
        }




        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int Album_Add(Album item)
        {
            using(var context = new ChinookContext())
            {
                item = context.Albums.Add(item);
                context.SaveChanges();
                return item.AlbumId;


            }
        }


    }
}
