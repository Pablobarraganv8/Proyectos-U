using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {#include <iostream>

        static void Main(string[] args)
        {
            int main()
            {
                // Declaración de variables
                double capitalInicial, capitalActual, interesMensual, interes;
                int numeroMeses;

                // Pedir al usuario que ingrese el capital inicial y el número de meses
                cout << "Ingrese el capital inicial: ";
                cin >> capitalInicial;
                cout << "Ingrese el número de meses: ";
                cin >> numeroMeses;

                // Calcular el interés mensual
                interesMensual = 0.7 / 100;

                // Inicializar el capital actual con el capital inicial
                capitalActual = capitalInicial;

                // Mostrar el encabezado
                cout << "Mes | Capital" << endl;

                // Iterar sobre cada mes
                for (int mes = 1; mes <= numeroMeses; mes++)
                {
                    // Calcular el interés del mes actual
                    interes = capitalActual * interesMensual;

                    // Añadir el interés al capital actual
                    capitalActual = capitalActual + interes;

                    // Mostrar el capital actual para este mes
                    cout << mes << " | " << capitalActual << endl;
                }

                return 0;
            }
        }
    }
}
