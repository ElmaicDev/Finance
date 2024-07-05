using PrimerAPP_WPF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Class1
{

	[Serializable]
    public class Variables
	{
		public int Ind { get; set; }
		public DateTime Fecha { get; set; }
		public string Categoria { get; set; }
		public string Descripcion { get; set; }
		public float Ingresos { get; set; }
		public float Egresos { get; set; }
        public string MetodoPago { get; set; }



        public Variables()
		{
		}

	}
	
}
