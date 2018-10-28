// Evarist Jaume - 05/10/2018
// primeros pasos switch
// introducir numeros del 1 al 10 y mostrarlos por pantalla

using System;

public class Ejercicio_2_1_9_1{
	
	public static void Main(){
	
		int numero;
		
		Console.Write("Introduce un numero del 1 al 10: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		switch (numero) {
			case 1: Console.WriteLine("El numero introducido es el uno.");
				break;
			case 2: Console.WriteLine("El numero introducido es el dos.");
				break;
			case 3: Console.WriteLine("El numero introducido es el tres.");
				break;
			case 4: Console.WriteLine("El numero introducido es el cuatro.");
				break;
			case 5: Console.WriteLine("El numero introducido es el cinco.");
				break;
			case 6: Console.WriteLine("El numero introducido es el seis.");
				break;
			case 7: Console.WriteLine("El numero introducido es el siete.");
				break;
			case 8: Console.WriteLine("El numero introducido es el ocho.");
				break;
			case 9: Console.WriteLine("El numero introducido es el nueve.");
				break;
			case 10: Console.WriteLine("El numero introducido es el diez.");
				break;
		}
		
	}
	
}
