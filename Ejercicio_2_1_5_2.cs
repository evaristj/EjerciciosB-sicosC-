// Evarist Jaume - 05/10/2018
// Condicion if con operadores lógicos
// comprobar si un numero es multiplo de 2 y 3 simultaneamente

using System;

public class Ejercicio_2_1_5_2{
	
	public static void Main(){
		
		int numero;
	
		Console.Write("Introduce un numero entero: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		if ((numero % 2 == 0) && (numero % 3 == 0))
			Console.WriteLine("El numero introducido {0} es multiplo de 2 y de 3.", numero);
	}
	
}
