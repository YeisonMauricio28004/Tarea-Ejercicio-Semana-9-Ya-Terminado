using System;
using EjercicioSemana8.Models;

Producto producto = new Producto();
using (AlmacenContext db= new AlmacenContext())
{
    Console.WriteLine("Por Favor Digite el Nombre");
    producto.Nombre = Console.ReadLine();
    Console.WriteLine("Por Favor Digite La Descripcion");
    producto.Descripcion = Console.ReadLine();
    Console.WriteLine("Por Favor Digite El Precio");
    producto.Precio = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Por Favor Digite el Stock");
    producto.Stock = int.Parse(Console.ReadLine());
    db.Add(producto);
    db.SaveChanges();
    Console.WriteLine("Su Producto Fue Ingresado con Exito !\n");

    var lista = db.Productos.ToList();
    foreach(var mostrar in lista)
    {
        Console.WriteLine("\nNombre:  " + mostrar.Nombre);
        Console.WriteLine("Descripcion: " + mostrar.Descripcion);
        Console.WriteLine("Precio  " + mostrar.Precio);
        Console.WriteLine("Stock " + mostrar.Stock); 
    }

}


