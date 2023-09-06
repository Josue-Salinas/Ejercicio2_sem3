using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico2_sem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string categoria_hotel;
            int dias, adicional, precio;
            Console.WriteLine("¿Qué categoría desean del hotel?: ");
            categoria_hotel = (Console.ReadLine());
            Console.WriteLine("Ingrese la estadía en el hotel: ");
            dias = int.Parse(Console.ReadLine());
            adicional = 7;
            switch (categoria_hotel)
            {
                case "Tres estrellas":
                    if (dias >= 11)
                    {
                        precio = 70;
                        precio = precio * dias;
                        precio = precio + (adicional * dias);
                    }
                    if (dias > 5 && dias < 11)
                    {
                        precio = 85;
                        precio = precio * dias;
                        precio = precio + (adicional * dias);
                    }
                    else
                    {
                        precio = 100;
                        precio = precio * dias;
                        precio = precio + (adicional * dias);
                    }
                    Console.WriteLine("Estadía:" + dias+" días");
                    Console.WriteLine("Precio:S/." + precio);
                    break;
                case "Cinco estrellas":
                    if (dias >= 11)
                    {
                        precio = 250;
                        precio = precio * dias;
                        precio = precio + (adicional * dias);
                    }
                    if (dias > 5 && dias < 11)
                    {
                        precio = 270;
                        precio = precio * dias;
                        precio = precio + (adicional * dias);
                    }
                    else
                    {
                        precio = 300;
                        precio = precio * dias;
                        precio = precio + (adicional * dias);
                    }
                    Console.WriteLine("Estadía:" + dias+" diás");
                    Console.WriteLine("Precio:S/." + precio);
                    break;
                default:
                    Console.WriteLine("Categoría de hotel no disponible");
                    return;
            }
            Console.ReadKey();
        }
    }
}
