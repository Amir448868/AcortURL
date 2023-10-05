using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcortURL.Entities
{
    public class URL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Url { get; set; }

        public string? UrlCorta { get; set; }

    }
}
