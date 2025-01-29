using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			float numero = Convert.ToSingle(Console.ReadLine());
			
			Console.Write("Insira um numero: ");
			float numero2 = Convert.ToSingle(Console.ReadLine());

			float subtracao = numero2 - numero;
			
			Console.WriteLine("\r\nA subtraçao do segundo numero pelo primeiro é: " + subtracao);
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
