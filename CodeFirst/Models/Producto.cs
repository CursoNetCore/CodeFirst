﻿namespace CodeFirst.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio_venta { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
