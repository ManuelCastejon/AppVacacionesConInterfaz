using System;
using System.Collections.Generic;
using System.Text;

namespace AppVacacionesConIviajes
{
    interface IViajes
    {
        // propiedades
        int _duracion { get; set; }
        int _dinero { get; set; }
        // métodos
        void CalculoCoste();
        void CalculoDias();

    }
}
