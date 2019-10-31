/*
 * Created by SharpDevelop.
 * User: eeeee
 * Date: 30/10/2019
 * Time: 10:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio8
{
	class Program
	{
		
        
        public static void calcularSalario(String nombre, int horas, int tarifas){
            int horasExtras=0;
            double tarifasHE=0, salario;
            if (horas>44) {
                horasExtras = horas - 44;
                tarifasHE = tarifas*0.25;
            }
            salario = (horas * tarifas)+(horasExtras*tarifasHE);
            
            Console.WriteLine("El salario del trabajador es: $"+salario);
        }
		
		public static void Main(string[] args) {
			String nombre;
            int horas, tarifa;
            Console.Write("Ingrese el nombre del trabajador: "); nombre=Console.ReadLine();
            Console.Write("Ingrese las horas trabajadas: "); horas=int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor por hora trabajada: "); tarifa=int.Parse(Console.ReadLine());
            
            calcularSalario(nombre, horas, tarifa);
            
            // TODO: Implement Functionality Here
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
	}
}