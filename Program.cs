using System;

namespace itla3password
{
	class MainClass
	{
		public static void Main(string[] args)
		{
		
			const string user = "admin";
			const string ps = "contra";
			
			Console.WriteLine("Bienvenido");

			while (true)
			{
				Console.WriteLine("usuario:");
				string yourUser = Console.ReadLine();
				Console.WriteLine("Digite cotraseña");
				string yourPsd = Console.ReadLine();
				if ( user.Equals(yourUser) && ps.Equals(yourPsd))
				{
					Console.WriteLine("Acceso consedido");
					break;
				}
				
				Console.WriteLine("Contraseña o usuario incorrectos");
				Console.WriteLine("--------------------------------");

			}
		}
		
	}
}
