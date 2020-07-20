using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp5.Tablas
{
	public class Autmovil
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int Id { get; set; }

		[Required]
		[MaxLength(10)]
	
		public string Placa { get; set; }

		public double Precio { get; set; }

		public bool? EstaRentado { get; set; }

	}
}
