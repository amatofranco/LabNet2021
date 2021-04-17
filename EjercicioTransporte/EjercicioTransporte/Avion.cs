using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTransporte
{
    public class Avion: Transporte
    {
        public Avion (int pasajeros): base(pasajeros)
        {

        }

        public override string Avanzar()
        {
            return "Vuelo entre 800 y 900 km por hora ";
        }

        public override string Detener()
        {
            return "Disminuyo hasta 240 km por hora antes de tocar el suelo";
        }

        public override string Descripcion()
        {
            return $"Avion: {Pasajeros} pasajeros";
        }
    }
}
