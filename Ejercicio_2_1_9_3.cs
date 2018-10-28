// Evarist Jaume - 05/10/2018
// primeros pasos switch
// comprobar caracter introducido

using System;

public class Ejercicio_2_1_9_3{
	
	public static void Main(){
	
		char numero;
		
		Console.Write("Introduce un numero, una vocal o una consonante: ");
		numero = Convert.ToChar(Console.ReadLine());
		
		switch (numero) {
			case '1': case '2':	case '3': case '4':	
			case '5': case '6': case '7': case '8': 
			case '9': case '0': Console.WriteLine("Has introducido un numero.");
				break;
			case 'a': case 'e': case 'i': case 'o':
			case 'u': Console.WriteLine("Has introducido una vocal.");
				break;
			case 'b': case 'c': case 'd': case 'f': case 'g': case 'h':
			case 'j': case 'k': case 'l': case 'm': case 'n': case 'p':
			case 'q': case 'r': case 's': case 't': case 'v': case 'w': 
			case 'x': case 'y': case 'z':
				Console.WriteLine("Has introducido una consonante.");
				break;
		}
		
	}
	
}
