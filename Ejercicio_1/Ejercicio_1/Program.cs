using System;

namespace testCS
{
	class Program
	{
		static void Main(string[] args)
		{
			double capitalInicial, capitalActual, interes, interesMensual, numeroMeses;

			// Pedir al usuario que ingrese el capital inicial y el número de meses
			Console.WriteLine("Ingrese el capital inicial: ");
			capitalInicial = double.Parse(Console.ReadLine());
			// Console.WriteLine(capitalInicial);

			Console.WriteLine("Ingrese el número de meses: ");
			numeroMeses = double.Parse(Console.ReadLine());
			// Console.WriteLine(numeroMeses);

			// Calcular el interés mensual
			interesMensual = 0.7 / 100;
			// Inicializar el capital actual con el capital inicial
			capitalActual = capitalInicial;

			// Mostrar el encabezado
			Console.WriteLine("Mes | Capital");
			for (int mes = 1; mes <= numeroMeses; mes++)
			{
				// Calcular el interés del mes actual
				interes = capitalActual * interesMensual;

				// Añadir el interés al capital actual
				capitalActual = capitalActual + interes;

				// Mostrar el capital actual para este mes
				Console.WriteLine(mes + " | "  + capitalActual);
			}
		}
	}
}
