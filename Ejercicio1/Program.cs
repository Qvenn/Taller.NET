/*
 * Created by SharpDevelop.
 * User: eeeee
 * Date: 30/10/2019
 * Time: 10:19 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		
        
        public static double CalcularMasaCorporal(double peso, double estatura){
            double IMC;
            IMC = peso / (estatura*estatura);
            return IMC;
        }
		
		public static void Main(string[] args) {
			double peso, estatura;
            
            Console.Write("Ingrese el peso: "); peso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la estatura (m): "); estatura = double.Parse(Console.ReadLine());
            
            Console.WriteLine("El IMC es: "+CalcularMasaCorporal(peso, estatura).ToString("#.##"));
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }		
			
		}
	}
