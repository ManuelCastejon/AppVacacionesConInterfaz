using System;

namespace AppVacacionesConIviajes
{
    class Program
    {
        static void Main(string[] args)
        {
            // creo un objeto Vacaciones
            Vacaciones mis_vacas = new Vacaciones(30, 1500);

            // invoco los métodos implementados en la clase, definidos en la Interfaz IViajes
            mis_vacas.CalculoCoste();
            mis_vacas.CalculoDias();

        }
    }
}
