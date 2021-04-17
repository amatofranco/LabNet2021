using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTransporte
{
    public class Automovil : Transporte
    {
        public Automovil(int pasajeros) : base(pasajeros)
        {

        }

        public override string Avanzar()
        {
            return "Arranco en primera";
        }

        public override string Detener()
        {
            return "Se activo el freno";
        }

        public override string Descripcion()
        {
            return $"Automovil: {Pasajeros} pasajeros";
        }
    }
}
