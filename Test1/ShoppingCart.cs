using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test1
{
    public class ShoppingCart
    {
        public DateTime FCompra { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public Double TotCompra { get; set; }
        public void AgregarItem(String nombre, int cantidad, Double precio)
        {
            Items.Add(new Item() { Nombre = nombre, Cantidad = cantidad, Precio = precio });
        }
        public void Comprar()
        {
            Items.Clear();
        }
        public int ObtenerCantidadDeItems()
        {
            int cantidad = 0;
            Items.ForEach(x => { cantidad += x.Cantidad; });
            return cantidad;
        }
        public Double ObtenerTotalCompra()
        {
            Double total = 0;
            Items.ForEach(x => { total += x.Cantidad * x.Precio; });
            return total;
        }
    }
}
