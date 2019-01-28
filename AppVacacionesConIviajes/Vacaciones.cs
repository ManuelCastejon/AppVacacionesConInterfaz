using System;
using System.Collections.Generic;
using System.Text;

namespace AppVacacionesConIviajes
{
    class Vacaciones :IViajes
    {

        // propiedades
        public int _duracion { get; set; }
        public int _dinero { get; set; }
        // propiedad de la clase
        public string _lugar { get; set; }

        // constructor 
        public Vacaciones(int duracion, int dinero)
        {
            this._duracion = duracion;
            this._dinero = dinero;
        }

        // constructor 
        public Vacaciones(int duracion, int dinero, string lugar)
        {
            this._duracion = duracion;
            this._dinero = dinero;
            this._lugar = lugar;
        }
        // métodos
        public void CalculoCoste()
        {
            Console.WriteLine($"El coste total es {_dinero} Euros");
        }
        public void CalculoDias()
        {
            Console.WriteLine($"La duración total es {_duracion} días");
        }

    }
}
