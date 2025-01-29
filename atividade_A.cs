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
			
			float soma = numero + numero2;
			
			Console.WriteLine("\r\nA soma dos dois numeros é: " + soma);
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
