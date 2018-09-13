using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Chinook.Data.Entities;
using ChinookSystem.DAL;
#endregion


namespace ChinookSystem.BLL
{
    public class ArtistController
    {
        //needs to be public because it is accessed by things outside of this library

        public List<Artist> Artist_List()
        {
            //lists the artists?
            using(var context = new ChinookContext())
            {
                return context.Artists.ToList();
            }
        }

        public Artist Artist_Find(int artistid)
        {
            using (var context = new ChinookContext())
            {
                return context.Artists.Find(artistid);
            }
        }



    }
}
