using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			float numero = Convert.ToSingle(Console.ReadLine());


			float absoluto = Convert.ToSingle(Math.Abs(numero));
			
			Console.WriteLine("\r\nO seu absolute é: " + absoluto);
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
