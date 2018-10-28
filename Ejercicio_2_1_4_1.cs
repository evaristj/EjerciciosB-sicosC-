// Evarist Jaume - 05/10/2018
// Condicion if - else, mejorar el Ejercicio_2_1_3_1

using System;

public class Ejercicio_2_1_4_1{

	public static void Main(){
		
		int numberB, numberA, resultado;
		
		Console.Write("Introduce un numero: ");
		numberA = Convert.ToInt32(Console.ReadLine());
				
		if (numberA == 0)
			Console.WriteLine("El producto de 0 por cualquier número es 0.");
		else 
			if (numberA != 0) {
				Console.Write("Introduce el segundo numero: ");
				numberB = Convert.ToInt32(Console.ReadLine());
				resultado = numberA * numberB;
				Console.WriteLine("El resultado es: {0}*{1} = {2}", numberA, numberB, resultado);
			}
		
	}

}
