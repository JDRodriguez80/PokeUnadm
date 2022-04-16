using System;

namespace PokeUnadm
{

    public class Program
    {
        
        static void Main(string[] args)
        {
            
            string logo = @"   
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
            Console.WriteLine(logo);
            System.Threading.Thread.Sleep(5000);//
            Console.Clear();
            
            menu();
        }
        static void menu()
        {   
            //instanciando la clase
            Pokemon objPokemon = new Pokemon();
            int aux = 1;
            while (aux != 0)
            {
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
                        
                        objPokemon.crearPokemon();
                        Console.Clear();
                        break;
                    case 2:
                        objPokemon.alimenta();
                        Console.Clear();

                        break;
                    case 3:
                        objPokemon.estadisticas();
                        Console.Clear();
                        break;
                    case 4:
                        objPokemon.atacaBasico();
                        Console.Clear();
                        break;
                    case 5:
                        objPokemon.atacaEspecial();
                        Console.Clear();
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
    }
}
