using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public Utente utente { get; set; } = new Utente();
        public TipoContatto tipoContatto { get; set; } = new TipoContatto();
    }
}