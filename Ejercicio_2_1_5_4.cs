// Evarist Jaume - 05/10/2018
// Condicion if con operadores lógicos
// comprobar si un numero no es multiplo de 2 ni de 3

using System;

public class Ejercicio_2_1_5_4{
	
	public static void Main(){
		
		int numero;
	
		Console.Write("Introduce un numero entero: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		if ((numero % 2 != 0) && (numero % 3 != 0))
			Console.WriteLine("El numero introducido {0} no es multiplo de 2 ni de 3.", numero);
	}
	
}

