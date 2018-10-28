// Evarist Jaume - 05/10/2018
// Condicion if, comprobar numero mayor

using System;

public class Ejercicio_2_1_1_2{
	
	public static void Main(){
		
		int numberA, numberB;
		
		Console.Write("Vamos a comprobar que numer es mayor. Introduce el primer numero: ");
		numberA = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Introduce el segundo numero: ");
		numberB = Convert.ToInt32(Console.ReadLine());
		
		if (numberA > numberB) 
			Console.WriteLine("El numero {0} es mayor que {1}.", numberA, numberB);
			
		if (numberA < numberB) 
			Console.WriteLine("El numero {0} es menor que {1}.", numberA, numberB);
			
		if (numberA == numberB) 
			Console.WriteLine("El numero {0} es igual que {1}.", numberA, numberB);
		
	}
	
}
