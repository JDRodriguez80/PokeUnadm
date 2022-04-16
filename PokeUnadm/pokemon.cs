using System;

namespace PokeUnadm
{
    class Pokemon
    {
        private String nombre;
        private String tipo;
        private double peso;//peso inicial
        private double pesoActual;//aumenta .02 gramos por alimentacion, con limite de el doble de peso
        private double altura;
        private String sexo;
        private bool esSalvaje=false;
        private double nivelMotivacion = 0.0;//aumenta en 0.1 por cada vez que se alimente, con limite de 10 acciones por ejecucución 
        private double ptsEXP;//establecerse en 0 si el pokemon es salvaje y en 10 si no lo es ademas que obtinene 0.1 despues de hacer un ataque 
        private double podAtaqueBasico;
        private double podAtaqueEspecial;



        //getters y setters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double Peso { get => peso; set => peso = value; }

        public double Altura { get => altura; set => altura = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public double NivelMotivacion { get => nivelMotivacion; set => nivelMotivacion = value; }
        public double PodAtaqueBasico { get => podAtaqueBasico; set => podAtaqueBasico = value; }
        
        public bool EsSalvaje
        {
            get => esSalvaje;

            set
            {
                if (esSalvaje == true)
                {
                    PtsEXP = 0.0;
                }
                else
                {
                    PtsEXP = 10.0;
                };
            }
        }

        public double PesoActual { get => pesoActual; set => pesoActual = value; }
        public double PtsEXP { get => ptsEXP; set => ptsEXP = value; }
        public double PodAtaqueEspecial { get => podAtaqueEspecial; set => podAtaqueEspecial = value; }

        //metodos

        public void crearPokemon() {

            Console.WriteLine("Creemos a tu pokemon");
            Console.Clear();
            Console.WriteLine("Nombre de tu pokemon?");
            Nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Tipo de tu pokemon?");
            Tipo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Peso de tu pokemon?");
            Peso = double.Parse(Console.ReadLine());
            PesoActual = Peso;
            Console.Clear();
            Console.WriteLine("Altura de tu pokemon?");
            Altura  = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Sexo de su pokemon Macho o Hembra");
            Sexo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Su pokemon es salvaje: 1.- si 2.- no");
            int j = int.Parse(Console.ReadLine());
            if (j == 1) { EsSalvaje = true; } else { EsSalvaje = false; }
            Console.Clear();
            Console.WriteLine("Poder de ataque basico?");
            PodAtaqueBasico = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Poder de ataque especial?");
            PodAtaqueEspecial = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Se creeo un pokemon con las siguientes caracteristicas");
            Console.WriteLine("=======================================");
            estadisticas();
            System.Threading.Thread.Sleep(3000);


        }
        //metodos de servicio
        public void alimenta() {
            int i = 0;

            if (i <= 10 && PesoActual < (Peso * 2))
            {
                NivelMotivacion = NivelMotivacion + .1;
                PesoActual = PesoActual + .2;
                Peso = PesoActual;
                Console.WriteLine("Se alimento a tu pokemon");
                System.Threading.Thread.Sleep(3000);

                i++;
            }
            else { Console.WriteLine("Ha sobrepasado el limite de alimentacion del pokemon"); 
            System.Threading.Thread.Sleep(3000);

            }
        }
        public void estadisticas() {
            Console.WriteLine("PokeStats");
            Console.WriteLine("=======================================");
            Console.WriteLine("\nNombre:"+Nombre);
            Console.WriteLine("\nTipo:"+Tipo);
            Console.WriteLine("\nPeso:"+PesoActual);
            Console.WriteLine("\nAltura:"+Altura);
            Console.WriteLine("\nSexo:"+Sexo);
            Console.WriteLine("\nAtaque Basico:" + PodAtaqueBasico);
            Console.WriteLine("\nAtaque Especial:"+podAtaqueEspecial);
            Console.WriteLine("\nExperiencia:"+PtsEXP);
            Console.WriteLine("\nMotivacion:"+NivelMotivacion);
            System.Threading.Thread.Sleep(3000);
        }
        //metodos para atques
        public void atacaBasico()
        {
            double danoReal = (PodAtaqueBasico * (PtsEXP * .50)) + NivelMotivacion;
            Console.WriteLine("Tu pokemon realiza un ataque basico.....");
            Console.WriteLine("Daño Basico: " + PodAtaqueBasico + "\nDaño real: " + danoReal);
            System.Threading.Thread.Sleep(3000);
            PtsEXP = PtsEXP + 0.1;

        }
        public void atacaEspecial()
        {
            double danoReal = (PodAtaqueEspecial * (PtsEXP * .50)) + NivelMotivacion;
            Console.WriteLine("Tu pokemon realiza un ataque Especial.....");
            Console.WriteLine("Ataque Especial: " + PodAtaqueEspecial + "\nDaño real: " + danoReal);
            System.Threading.Thread.Sleep(3000);
            PtsEXP = PtsEXP + 0.1;

        }

    }


       



    

}
