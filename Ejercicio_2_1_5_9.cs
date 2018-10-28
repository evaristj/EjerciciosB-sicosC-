// Evarist Jaume - 05/10/2018
// Condicion if con operadores lógicos
// comprobar el mayor de 3 numeros

using System;

public class Ejercicio_2_1_5_9{
	
	public static void Main(){
		
		int numeroA, numeroB, numeroC;
	
		Console.Write("Introduce el primer numero: ");
		numeroA = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Introduce el segundo numero: ");
		numeroB = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Introduce el tercer numero: ");
		numeroC = Convert.ToInt32(Console.ReadLine());
		
		if ((numeroA > numeroB) && (numeroA > numeroC)) 
			Console.WriteLine("El numero mayor es: {0}.", numeroA);
		 else if ((numeroC > numeroB) && (numeroC > numeroA)) 
			Console.WriteLine("El numero mayor es: {0}.", numeroC);
		 else if ((numeroC < numeroB) && (numeroB > numeroA))
			Console.WriteLine("El numero mayor es: {0}.", numeroB);
		// la siguiente condicion la he puesto de forma extra, para añadir otra posible casuistica
		 else if ((numeroC == numeroB) || (numeroC == numeroA) || (numeroB == numeroA)) 
			Console.WriteLine("Hay dos o tres numeros mayores iguales.");
		
	}
	
}
