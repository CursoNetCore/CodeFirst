using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        [Required(ErrorMessage = "seleccione una categoria")]
        public int IdCategoria { get; set; }
        [StringLength(64, ErrorMessage = "codigo => longitud invalida")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "Infrese un nombre")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "codigo => longitud invalida")]
        public string Nombre { get; set; }
        [Required]
        public decimal Precio_venta { get; set; }
        [Required]
        public int Stock { get; set; }
        [StringLength(255, ErrorMessage = "longitud invalida")]
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
