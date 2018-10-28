// Evarist Jaume - 05/10/2018
// Condicion if con operadores, multiplica dos numeros

using System;

public class Ejercicio_2_1_3_1{

	public static void Main(){
	
		int numberA, numberB, resultado;
		
		Console.Write("Introduce un numero: ");
		numberA = Convert.ToInt32(Console.ReadLine());
				
		if (numberA == 0)
			Console.WriteLine("El producto de 0 por cualquier número es 0.");
			
		if (numberA != 0){
			Console.Write("Introduce el segundo numero: ");
			numberB = Convert.ToInt32(Console.ReadLine());
			resultado = numberA * numberB;
			Console.WriteLine("El resultado es: {0}*{1} = {2}", numberA, numberB, resultado);
		}
	}
	
}
