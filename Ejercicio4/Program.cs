/*
 * Created by SharpDevelop.
 * User: eeeee
 * Date: 30/10/2019
 * Time: 10:25 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio4
{
	class Program
	{
		
        public static int pedir(){
            Console.WriteLine("ingrese un numero ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("el numero entero es: "+n);
            return n;
        }
        
        public static int triple(int n){
            int resultado=n*3;
            return resultado;
        }
		
		public static void Main(string[] args) {
		Console.WriteLine("");
            
            
            
            Console.WriteLine("el triple es: "+triple(pedir()));
            
            
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
	}
}