using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			float numero = Convert.ToSingle(Console.ReadLine());

			float dobro = numero * 2;
			
			Console.WriteLine("\r\nA soma dos dois numeros é: " + dobro);
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
