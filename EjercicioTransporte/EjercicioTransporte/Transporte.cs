using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTransporte
{
    public abstract class Transporte
    {
        public int Pasajeros { get; }

        public Transporte (int pasajeros)
        {
            this.Pasajeros = pasajeros;
        }

        public abstract string Avanzar();

        public abstract string Detener();

        public abstract string Descripcion();

    }
}
