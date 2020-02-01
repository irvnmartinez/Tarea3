using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ListFrutas = new string[10];
            string[] ListVegetales = new string[10];
            string[] ListLacteos = new string[10];


            while (true)
            {
                bool close = false;
                Console.WriteLine("~Lista de compra~\n" +
                "\n[1] Añadir producto a una lista\n" + "[2] Mostrar listas\n" + "[3] Editar producto de una lista\n" + "[4] Eliminar producto de una lista\n" + "[5] Cerrar programa");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Elija a que lista desea añadir el producto\n" +
                        "\n[1] Frutas\n" + "[2] Vegetales\n" + "[3] Lacteos");
                        int opcion2 = int.Parse(Console.ReadLine());
                        switch (opcion2)
                        {
                            case 1:

                                if (string.IsNullOrEmpty(ListFrutas[9]))
                                {
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el producto");
                                    string Fruta = Console.ReadLine();

                                    for (int i = 0; i < ListFrutas.Length; i++)
                                    {
                                        string elemento = ListFrutas[i];

                                        if (string.IsNullOrEmpty(elemento))
                                        {
                                            ListFrutas[i] = Fruta;
                                            Console.Clear();
                                            break;
                                            
                                        }

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No hay mas espacio disponible");
                                    Console.ReadKey();
                                    break;
                                }
                                break;
                            case 2:
                                if (string.IsNullOrEmpty(ListVegetales[9]))
                                {
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el producto");
                                    string Vegetal = Console.ReadLine();

                                    for (int i = 0; i < ListVegetales.Length; i++)
                                    {
                                        string elemento = ListVegetales[i];

                                        if (string.IsNullOrEmpty(elemento))
                                        {
                                            ListVegetales[i] = Vegetal;
                                            Console.Clear();
                                            break;
                                        }

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No hay mas espacio disponible");
                                    Console.ReadKey();
                                    break;
                                }
                                break;
                            case 3:

                                if (string.IsNullOrEmpty(ListLacteos[9]))
                                {
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el producto");
                                    string Lacteo = Console.ReadLine();

                                    for (int i = 0; i < ListLacteos.Length; i++)
                                    {
                                        string elemento = ListLacteos[i];

                                        if (string.IsNullOrEmpty(elemento))
                                        {
                                            ListLacteos[i] = Lacteo;
                                            Console.Clear();
                                            break;
                                            
                                        }

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No hay mas espacio disponible");
                                    Console.ReadKey();
                                    break;
                                }
                                break;
                                
                        }
                        break;
                       
                    case 2:
                        Console.Clear();
                        Console.WriteLine("LISTA DE FRUTAS\n");
                        for (int i = 0; i < ListFrutas.Length; i++)
                        {
                            string elemento = ListFrutas[i];

                            Console.WriteLine((i + 1) + "-" + elemento);
                        }
                        Console.WriteLine("\nLISTA DE VEGETALES\n");
                        for (int i = 0; i < ListVegetales.Length; i++)
                        {
                            string elemento = ListVegetales[i];

                            Console.WriteLine((i + 1) + "-" + elemento);
                        }
                        Console.WriteLine("\nLISTA DE LACTEOS\n");
                        for (int i = 0; i < ListLacteos.Length; i++)
                        {
                            string elemento = ListLacteos[i];

                            Console.WriteLine((i + 1) + "-" + elemento);
                        }                        
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Elija en cual lista se encuentra el producto que desea editar\n" +
                        "\n[1] Frutas\n" + "[2] Vegetales\n" + "[3] Lacteos");
                        int opcion3 = int.Parse(Console.ReadLine());

                        switch(opcion3)
                        {
                            case 1:
                                Console.Clear();
                                for (int i = 0; i < ListFrutas.Length; i++)
                                {
                                    string elemento = ListFrutas[i];

                                    Console.WriteLine((i + 1) + "-" + elemento);
                                }                             
                                Console.WriteLine("Ingrese el numero del producto que desea editar");
                                int Producto1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Como prefiere nombrar este producto");
                                string NewProducto1 = Console.ReadLine();
                                ListFrutas[Producto1 - 1] = NewProducto1;
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                for (int i = 0; i < ListVegetales.Length; i++)
                                {
                                    string elemento = ListVegetales[i];

                                    Console.WriteLine((i + 1) + "-" + elemento);
                                }
                                Console.WriteLine("Ingrese el numero del producto que desea editar");
                                int Producto2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Como prefiere nombrar este producto");
                                string NewProducto2 = Console.ReadLine();
                                ListVegetales[Producto2 - 1] = NewProducto2;
                                Console.Clear();
                                break;
                            case 3:
                                Console.Clear();
                                for (int i = 0; i < ListLacteos.Length; i++)
                                {
                                    string elemento = ListLacteos[i];

                                    Console.WriteLine((i + 1) + "-" + elemento);
                                }
                                Console.WriteLine("Ingrese el numero del producto que desea editar");
                                int Producto3 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Como prefiere nombrar este producto");
                                string NewProducto3 = Console.ReadLine();
                                ListLacteos[Producto3 - 1] = NewProducto3;
                                Console.Clear();
                                break;
                        }

                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Elija en cual lista se encuentra el producto que desea eliminar\n" +
                        "\n[1] Frutas\n" + "[2] Vegetales\n" + "[3] Lacteos");
                        int opcion4 = int.Parse(Console.ReadLine());
                        
                        switch(opcion4)
                        {
                            case 1:
                                Console.Clear();
                                for (int i = 0; i < ListFrutas.Length; i++)
                                {
                                    string elemento = ListFrutas[i];

                                    Console.WriteLine((i + 1) + "-" + elemento);
                                }
                                Console.WriteLine("Ingrese el numero del prpoducto que desea eliminar");
                                int Producto1 = int.Parse(Console.ReadLine());
                                ListFrutas[Producto1 - 1] = "";
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                for (int i = 0; i < ListVegetales.Length; i++)
                                {
                                    string elemento = ListVegetales[i];

                                    Console.WriteLine((i + 1) + "-" + elemento);
                                }
                                Console.WriteLine("Ingrese el numero del prpoducto que desea eliminar");
                                int Producto2 = int.Parse(Console.ReadLine());
                                ListVegetales[Producto2 - 1] = "";
                                Console.Clear();
                                break;
                            case 3:
                                Console.Clear();
                                for (int i = 0; i < ListLacteos.Length; i++)
                                {
                                    string elemento = ListLacteos[i];

                                    Console.WriteLine((i + 1) + "-" + elemento);
                                }
                                Console.WriteLine("Ingrese el numero del producto que desea eliminar");
                                int Producto3 = int.Parse(Console.ReadLine());
                                ListLacteos[Producto3 - 1] = "";
                                Console.Clear();
                                break;
                        }
                        break;

                    case 5:
                       close = true;
                        
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Esa opcion no se encuentra disponible");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        
                }


                

                if (close)
                {
                    break;
                } 
            }

             
        }
    }
}
