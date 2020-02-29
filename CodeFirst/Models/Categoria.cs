using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdCategoria { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3, ErrorMessage ="longitud invalida")]
        public string Nombre { get; set; }
        [StringLength(255, ErrorMessage = "longitud invalida")]
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
