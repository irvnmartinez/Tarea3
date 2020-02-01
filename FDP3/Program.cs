using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDP3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Contactos = new string[10];
            string[] NumDC = new string[10];

            while (true)
            {

                bool close = false;
                Console.Clear();
                Console.Write("~ CONTACTOS ~\n" +
                "\n Seleccione la accion que desea realizar" +
                "\n [1] Agregar contacto" + "\n [2] Listar contactos" + "\n [3] Editar contacto" + "\n [4] Eliminar contacto" + "\n [5] Cerrar programa\n");
                int Opcion = int.Parse(Console.ReadLine());

                switch(Opcion)
                {
                    case 1:

                        if (string.IsNullOrEmpty(Contactos[9]))
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese el nombre del contacto");
                            string Name = Console.ReadLine();

                            for (int i = 0; i < Contactos.Length; i++)
                            {
                                string elemento = Contactos[i];

                                if (string.IsNullOrEmpty(elemento))
                                {
                                    Contactos[i] = Name;
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
                        
                        if(string.IsNullOrEmpty(NumDC[9]))
                        {
                            Console.WriteLine("Ingrese el numero telefonico del contato");
                            string telefono = Convert.ToString(Console.ReadLine());
                            for (int i = 0; i < NumDC.Length; i++)
                            {
                                string elemento = NumDC[i];

                                if (string.IsNullOrEmpty(elemento))
                                {
                                    NumDC[i] = telefono;
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

                        Console.Clear();
                        Console.WriteLine("Contactos gruardados\n");
                        for (int i = 0; i < Contactos.Length; i++)
                        {
                            string elemento = Contactos[i];
                            Console.WriteLine((i + 1) + "-" + elemento);
                                                    
                        }
                        Console.WriteLine("\nNumeros telefonicos de los contactos\n");
                        for (int i = 0; i < NumDC.Length; i++)
                        {
                            string elemento2 = NumDC[i];

                            Console.WriteLine((i + 1) + "-" + elemento2);

                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:

                        Console.Clear();
                        for (int i = 0; i < Contactos.Length; i++)
                        {
                            string elemento = Contactos[i];

                            Console.WriteLine((i + 1) + "-" + elemento);
                        }
                        Console.WriteLine("\n");
                        for (int i = 0; i < NumDC.Length; i++)
                        {
                            string elemento2 = NumDC[i];

                            Console.WriteLine((i + 1) + "-" + elemento2);

                        }
                        Console.WriteLine("Ingrese el numero del contacto que desea editar");
                        int Contacto = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Como prefiere nombrar este contacto");
                        string NewContacto = Console.ReadLine();
                        Contactos[Contacto - 1] = NewContacto;
                        Console.WriteLine("Que nuevo numero telefonico desea añadir a este contacto");
                        string NewTelefono = Console.ReadLine();
                        NumDC[Contacto - 1] = NewTelefono;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:

                        Console.Clear();
                        for (int i = 0; i < Contactos.Length; i++)
                        {
                            string elemento = Contactos[i];

                            Console.WriteLine((i + 1) + "-" + elemento);
                        }
                        Console.WriteLine("\n");
                        for (int i = 0; i < NumDC.Length; i++)
                        {
                            string elemento2 = NumDC[i];

                            Console.WriteLine((i + 1) + "-" + elemento2);

                        }
                        Console.WriteLine("Ingrese el numero del contacto que desea eliminar");
                        int Contacto2 = int.Parse(Console.ReadLine());
                        Contactos[Contacto2 - 1] = "";
                        NumDC[Contacto2 - 1] = "";
                        Console.Clear();

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

