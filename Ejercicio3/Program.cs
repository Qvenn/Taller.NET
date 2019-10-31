/*
 * Created by SharpDevelop.
 * User: eeeee
 * Date: 30/10/2019
 * Time: 10:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio3
{
	class Program
	{
		
        
        public static int strlen2(String cadena){
            int cantidad;
            cantidad = cadena.Length;
            return cantidad;
        }
		
		public static void Main(string[] args) {
			String cadena;
            Console.WriteLine("Ingrese la cadena: ");
            cadena = Console.ReadLine();
            
            Console.WriteLine("La cantidad de caracteres es: "+strlen2(cadena));
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
	}
}