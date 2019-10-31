/*
 * Created by SharpDevelop.
 * User: eeeee
 * Date: 30/10/2019
 * Time: 10:20 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		
        
        public static String Ultima(String cadena){
            String ultimo;
            if (cadena.Equals("")){
                ultimo="Cadena vacía";
            } else {
                ultimo = cadena.Substring(cadena.Length-1);
            }
            
            return ultimo;
        }
		
		public static void Main(string[] args) {
			String cadena;
            Console.WriteLine("Ingrese cadena: ");
            cadena = Console.ReadLine();
            
            Console.WriteLine(Ultima(cadena));
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
	}
}