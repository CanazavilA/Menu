﻿using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using libreriaClases;
namespace libreria{
    class Principal{
        static void Main(){
            string opcion= mostrarMenu();

        while(opcion != "9")
         {

            if(opcion == "1"){

                crearPersona();
            }
            else
            {
                Console.WriteLine("opcion incorrecta");
                Console.ReadKey();
            }

           opcion= mostrarMenu();
        }

        }

          public static void crearPersona(){

            Console.Clear();
            Persona p1 = new Persona();

            Console.WriteLine("Ingreso de persona");
            Console.WriteLine("-----------");
            Console.WriteLine("");

             Console.Write("Ingrese apellido: ");
             p1.Apellido = Console.ReadLine();
             Console.Write("Ingrese Nombre: ");
             p1.Nombre = Console.ReadLine();
             Console.Write("fechadeNacimienti: ");

             p1.fechaNacimiento = Console.ReadLine();
             Console.Write("DNI: ");
             p1.DNI = Convert.ToInt32(Console.ReadLine());
        
          }

          public static string  mostrarMenu(){

             string opcion;

            Console.WriteLine("menu");
           Console.WriteLine("----");
          
           Console.WriteLine("");
           Console.WriteLine("1.-crear alumno");
           Console.WriteLine("");
           Console.Write("elija una opcion: ");

           opcion= Console.ReadLine();
           return opcion;

          }
    }

}

