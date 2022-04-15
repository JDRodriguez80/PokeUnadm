using System;

namespace PokeUnadm
{

    public class Program
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
        static void menu()
        {
            
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
                       crearPokemon();
                        break;
                    case 2:
                        alimentarPokemon();
                        menu();
                        break;
                    case 3:
                        
                    case 4:
                        ataqueBasico();
                        menu();
                        break;
                    case 5:
                        ataqueEspecial();
                        menu();
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
         static void crearPokemon()
        {
            Pokemon objPokemon = new Pokemon();
            Console.WriteLine("Creemos a tu pokemon");
            Console.WriteLine("Nombre de tu pokemon?");
            string nombre = Console.ReadLine();
            Console.WriteLine("Tipo de tu pokemon?");
            string tipo = Console.ReadLine();
            Console.WriteLine("Peso de tu pokemon?");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura de tu pokemon?");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("defina el sexo de su pokemon Macho o Hembra");
            string sexo = Console.ReadLine();
            Console.WriteLine("Su pokemon es salvaje: 1.- si 2.- no");
            int j = int.Parse(Console.ReadLine());
            bool _salvaje;
            if (j == 1) { _salvaje = true; } else { _salvaje = false; }
            Console.WriteLine("Poder de ataque basico?");
            double ataqueBasico = double.Parse(Console.ReadLine());
            Console.WriteLine("Poder de ataque especial?");
            double ataqueEspecial = double.Parse(Console.ReadLine());
            objPokemon.crearPokemon(nombre, tipo, peso, altura, sexo, _salvaje, ataqueBasico, ataqueEspecial);
            Console.WriteLine("Pokemon creado con las siguientes caracteristicas:");//mostrando las caracteristicas indicadas por el usuario.

        }
         static void alimentarPokemon() {
            Pokemon objPokemon = new Pokemon();
            int i = 0;
            
            if (i <= 10 && objPokemon.NivelMotivacion<(objPokemon.Peso*2))
            {
                objPokemon.NivelMotivacion = objPokemon.NivelMotivacion + .01;
                objPokemon.PesoActual = objPokemon.PesoActual + .02;
                objPokemon.Peso = objPokemon.PesoActual;
                i++;
            }
            else { Console.WriteLine("Ha sobrepasado el limite de alimentacion del pokemon"); }
         
        }
        static void estadisticas()
        {

            

        }
        static void ataqueBasico() {
            Pokemon objPokemon = new Pokemon();
            double danoReal = (objPokemon.PodAtaqueBasico * (objPokemon.PtsEXP * .50)) + objPokemon.NivelMotivacion;
            Console.WriteLine("Daño de ataque basico:" + objPokemon.PodAtaqueBasico + "\nDaño real:" + danoReal);
            objPokemon.PtsEXP = objPokemon.PtsEXP + 0.1;

        }
        static void ataqueEspecial() {
            Pokemon objPokemon = new Pokemon();
            double danoReal = (objPokemon.PodAtaqueEspecial * (objPokemon.PtsEXP * .50)) + objPokemon.NivelMotivacion;
            Console.WriteLine("Daño de ataque basico:" + objPokemon.PodAtaqueEspecial + "\nDaño real:" + danoReal);
            objPokemon.PtsEXP = objPokemon.PtsEXP + 0.1;
        }
    }
}
