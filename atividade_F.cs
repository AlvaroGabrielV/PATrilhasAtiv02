using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			float numero = Convert.ToSingle(Console.ReadLine());

			float raiz_quadrada = Convert.ToSingle(Math.Sqrt(numero));
			
			Console.WriteLine("\r\nA raiz quadrada é: " + raiz_quadrada);
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
