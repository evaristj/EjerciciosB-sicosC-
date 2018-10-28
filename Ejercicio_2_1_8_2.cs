// Evarist Jaume - 05/10/2018
// operador condicional ?
// calcular el menor de dos numeros

using System;

public class Ejercicio_2_1_8_2{
	
	public static void Main(){
	
		int numeroA, numeroB, resultado;
		
		Console.Write("Introduce un numero: ");
		numeroA = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Introduce otro numero: ");
		numeroB = Convert.ToInt32(Console.ReadLine());
		
		resultado = numeroA > numeroB ? numeroB : numeroA;
		Console.WriteLine("El numero menor es: {0}", resultado);
	}
	
}
