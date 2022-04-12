using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeUnadm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arte = @"   
    _____  _______                   __         ______              ______    __                                                 
   /     |/       \                 /  |       /      \            /      \  /  |                                                
   $$$$$ |$$$$$$$  |  ______    ____$$ |      /$$$$$$  |  ______  /$$$$$$  |_$$ |_    __   __   __   ______    ______    ______  
      $$ |$$ |__$$ | /      \  /    $$ |      $$ \__$$/  /      \ $$ |_ $$// $$   |  /  | /  | /  | /      \  /      \  /      \ 
 __   $$ |$$    $$< /$$$$$$  |/$$$$$$$ |      $$      \ /$$$$$$  |$$   |   $$$$$$/   $$ | $$ | $$ | $$$$$$  |/$$$$$$  |/$$$$$$  |
/  |  $$ |$$$$$$$  |$$ |  $$ |$$ |  $$ |       $$$$$$  |$$ |  $$ |$$$$/      $$ | __ $$ | $$ | $$ | /    $$ |$$ |  $$/ $$    $$ |
$$ \__$$ |$$ |  $$ |$$ \__$$ |$$ \__$$ |      /  \__$$ |$$ \__$$ |$$ |       $$ |/  |$$ \_$$ \_$$ |/$$$$$$$ |$$ |      $$$$$$$$/ 
$$    $$/ $$ |  $$ |$$    $$/ $$    $$ |      $$    $$/ $$    $$/ $$ |       $$  $$/ $$   $$   $$/ $$    $$ |$$ |      $$       |
 $$$$$$/  $$/   $$/  $$$$$$/   $$$$$$$/        $$$$$$/   $$$$$$/  $$/         $$$$/   $$$$$/$$$$/   $$$$$$$/ $$/        $$$$$$$/ ";
                                                     
            //código para pantalla de presentación
            Console.WriteLine(arte);
            System.Threading.Thread.Sleep(5000);//
            Console.Clear();
            menu();
        }
        static void menu() {
            int aux = 1;
            while (aux != 0) {
                Console.WriteLine("=======================================");
                Console.WriteLine("1.- Crear Pokemon ");
                Console.WriteLine("");
                Console.WriteLine("2.- Alimentar Pokemon");
                Console.WriteLine("");
                Console.WriteLine("3.- Estadisticas");
                Console.WriteLine("");
                Console.WriteLine("4.- Ataque Básico");
                Console.WriteLine("");
                Console.WriteLine("5.- Ataque Especial");
                Console.WriteLine("");
                Console.WriteLine("6.- Salir");
                Console.WriteLine("");
                Console.WriteLine("=======================================");
                Console.WriteLine("Seleccione una opcion ...");
                Console.WriteLine("");
                int seleccion = (int)Convert.ToInt32(Console.ReadLine());

                //Switch para controlar opciones
                switch (seleccion)
                {
                    case 1:
                        crearPokemon();
                        break;
                    case 2:
                        alimentarPokemon();
                        break;
                    case 3:
                        estadisticas();
                        break;
                    case 4:
                        ataqueBasico();
                        break;
                    case 5:
                        ataqueEspecial();
                        break;
                    case 6:
                        aux = 0;
                        break;
                    default:
                        Console.WriteLine("Eliga una opción valida");
                        break;      
                }
            }
        }
        static void crearPokemon() { }
        static void alimentarPokemon() { }
        static void estadisticas() { }
        static void ataqueBasico() { }
        static void ataqueEspecial() { }
    }
}
