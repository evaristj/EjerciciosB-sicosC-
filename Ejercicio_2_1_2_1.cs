// Evarist Jaume - 05/10/2018
// Condicion if compuesta, comprobar multiplos de 10

using System;

public class Ejercicio_2_1_2_1{

	public static void Main(){
		
		int numberA;
	
		Console.Write("Introduce un numero para comprobar si es multiplo de 10: ");
		numberA = Convert.ToInt32(Console.ReadLine());
		
		if(numberA % 10 == 0){
			Console.WriteLine("El numero {0} es multiplo de 10.", numberA);
			Console.Write("Introduce otro numero: ");
			int numberB = Convert.ToInt32(Console.ReadLine());
			
			if(numberB % 10 == 0){
				Console.WriteLine("El numero introducido {0} tambien es multiplo de 10.", numberB);
			}
		}
	}
}
