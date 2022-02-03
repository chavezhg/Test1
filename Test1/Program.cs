using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            ShoppingCart carrito = new ShoppingCart();
            while (continuar)
            {
                Console.WriteLine("Ingresa el nombre del producto");
                String nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la cantidad del producto");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa el precio del producto");
                Double precio = Convert.ToDouble(Console.ReadLine());
                carrito.AgregarItem(nombre, cantidad, precio);
                Console.WriteLine("¿Agregar otro producto? (Si/No)");
                String res = Console.ReadLine();
                if (!(res == "Si" || res == "si" || res == "SI"))
                    continuar = false;
            }
            Console.WriteLine("Usted compró " + carrito.ObtenerCantidadDeItems() + " items por " + carrito.ObtenerTotalCompra());
        }
    }
}
