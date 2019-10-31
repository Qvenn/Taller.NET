/*
 * Created by SharpDevelop.
 * User: eeeee
 * Date: 30/10/2019
 * Time: 10:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio7
{
	class Program
	{
		
        public static void mostrarTabla(int num){
            
            
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(num+" x "+i+ " = "+num*i);
            }
        }
		public static void Main(string[] args) {
			 int num;
            Console.WriteLine("ingrese un numero para hacer la tabla de multiplicar ");
            num=int.Parse(Console.ReadLine());
            
            mostrarTabla(num);
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
	}
}