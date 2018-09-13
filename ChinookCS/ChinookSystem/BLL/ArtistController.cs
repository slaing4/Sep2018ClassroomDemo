using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Chinook.Data.Entities;
using ChinookSystem.DAL;
using System.ComponentModel;
#endregion


namespace ChinookSystem.BLL
{
    [DataObject]
    public class ArtistController
    {
        //needs to be public because it is accessed by things outside of this library
        [DataObjectMethod(DataObjectMethodType.Select, false)] //IDK WHAT THIS IS THOUGH, 
        public List<Artist> Artist_List()
        {
            //lists the artists?
            using(var context = new ChinookContext())
            {
                return context.Artists.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]//STILL IDK
        public Artist Artist_Find(int artistid)
        {
            using (var context = new ChinookContext())
            {
                return context.Artists.Find(artistid);
            }
        }



    }
}
