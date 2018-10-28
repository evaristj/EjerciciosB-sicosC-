// Evarist Jaume - 05/10/2018
// Condicion if con operadores lógicos
// comprobar si dos numeros enteros son positivos

using System;

public class Ejercicio_2_1_5_8{
	
	public static void Main(){
		
		int numeroA, numeroB;
	
		Console.Write("Introduce un numero entero: ");
		numeroA = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Introduce otro numero entero: ");
		numeroB = Convert.ToInt32(Console.ReadLine());
		
		if ((numeroA > 0) && (numeroB > 0)) 
			Console.WriteLine("Los dos numeros son positivos {0}, {1}.", numeroA, numeroB);
		 else if ((numeroA > 0) || (numeroB > 0)) 
			Console.WriteLine("Uno de los numeros es positivo.");
		 else 
			Console.WriteLine("Ninguno de los numeros es positivo.");
		
	}
	
}
