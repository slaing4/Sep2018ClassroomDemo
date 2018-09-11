using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additonal Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion


namespace Chinook.Data.Entities
{
    [Table("Artists")]
    public class Artist
    {
        [Key, Column(Order = 1)]
        public int ArtistId { get; set; }
        [Required(ErrorMessage ="Name is a required feild")]
        [StringLength(120, ErrorMessage = "Maximum Length 120 charatcers")]
        public string Name { get; set; }
    }
}
