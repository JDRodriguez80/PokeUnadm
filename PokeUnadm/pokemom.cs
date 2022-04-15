using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private bool esSalvaje;
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
        public double PodAtaqueEspecial { get => podAtaqueEspecial; set => podAtaqueEspecial = value; }
        public bool EsSalvaje
        {
            get => esSalvaje;

            set
            {
                if (esSalvaje == true)
                {
                    ptsEXP = 0.0;
                }
                else
                {
                    ptsEXP = 10.0;
                };
            }
        }
        
        //metodos


        //metodo para crear pokemon
        public void crearPokemon(String _nombre, String _tipo, double _peso, double _altura, String _sexo, bool _esSalvaje, double _podAtaqueBasico, double _podAtaqueEspecial)
        {
            this.nombre = _nombre;
            this.tipo = _tipo;
            this.peso = _peso;
            this.altura = _altura;
            this.sexo = _sexo;
            this.esSalvaje = _esSalvaje;
            this.podAtaqueBasico = _podAtaqueBasico;
            this.podAtaqueEspecial = _podAtaqueEspecial;
        }

        
        

    }

}
