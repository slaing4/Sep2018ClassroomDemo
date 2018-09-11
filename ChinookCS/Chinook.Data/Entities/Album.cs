using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Addtitional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace Chinook.Data.Entities
{
    [Table("Albums")]
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        [Required(ErrorMessage ="Title is required")]
        [StringLength(160, ErrorMessage ="Title is limited to 160 characters")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Artist ID is a required")]
        public int ArtistId { get; set; }
        public int Releaseyear { get; set; }
        [StringLength(160, ErrorMessage = "Release label is limited to 160 characters")]
        public string ReleaseLabel { get; set; }

    }
}
