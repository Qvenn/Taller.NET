/*
 * Created by SharpDevelop.
 * User: eeeee
 * Date: 30/10/2019
 * Time: 10:27 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio6
{
	class Program
	{
		
        
        public static double CalcularDiametro (double radio){
            double Diametro;
            Diametro = 2*radio;
            
            return Diametro;
        }
        
        public static double CalcularArea (double radio){
            double area;
            
            area = Math.PI*radio;
            return area;
        }
        
        public static double CalcularCircunferencia(double radio){
            double Circunferencia;
            
            Circunferencia = Math.PI*CalcularDiametro(radio);
            return Circunferencia;
        }
		
		public static void Main(string[] args) {
			int op;
            double radio;
            
            Console.WriteLine("Ingrese la operación a realizar: ");
            Console.WriteLine("1. Calcular Diametro \n2. Calcular Area \n3. Calcular Circunferencia");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el radio: ");
            radio = double.Parse(Console.ReadLine());
            switch (op) {
                case 1:
                    Console.WriteLine("El Diametro es: "+CalcularDiametro(radio).ToString("#.##"));
                    break;
                    
                case 2:
                    Console.WriteLine("El Area es: "+CalcularArea(radio).ToString("#.##"));
                    break;
                    
                case 3:
                    Console.WriteLine("La Circunferencia es: "+CalcularCircunferencia(radio).ToString("#.##"));
                    break;
                
                default: 
                    break;
            }
                
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
	}
}