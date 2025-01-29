using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			float numero = Convert.ToSingle(Console.ReadLine());

			float metade = numero / 2;
			
			Console.WriteLine("\r\nA metade desse numero é: " + metade);
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
