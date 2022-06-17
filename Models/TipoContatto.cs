using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TipoContatto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string telefono { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public ICollection<Contact> contacts { get; set; } = new List<Contact>();
    }
}
