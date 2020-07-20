using ConsoleApp5.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			using(var con = new ApplicationContext())
			{
				try
				{
					
					var car = con.Autmovils.Where(x=> x.Id > 0 && x.Id <= 10);
					
					
					
					
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
				
			}
			Console.ReadKey();

		}
	}
}
