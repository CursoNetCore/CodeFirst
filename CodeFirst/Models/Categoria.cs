using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdCategoria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
