using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			float numero = Convert.ToSingle(Console.ReadLine());
			
			Console.Write("Insira outro numero: ");
			float numero2 = Convert.ToSingle(Console.ReadLine());

			float divisao = numero / numero2;
			
			Console.WriteLine("\r\nA divisao do primeiro numero pelo segundo é: " + divisao);
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
