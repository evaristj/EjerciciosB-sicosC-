// Evarist Jaume - 05/10/18
// Condiciones con if, comprobar numero par

using System;

public class Ejercicio_2_1_1_1{

	public static void Main(){
		
		int number;
		
		Console.Write("Introduce un número para saber si es par o impar: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		if (number % 2 == 0) 
			Console.WriteLine("El numero introducido {0} es par.", number);
		
	}

}
