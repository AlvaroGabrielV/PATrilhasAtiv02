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


			float multiplicacao = numero * numero2;
			
			Console.WriteLine("\r\nO resultado da multiplicaçao destes valores é: " + multiplicacao);
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
