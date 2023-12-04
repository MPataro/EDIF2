using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP06
{
	class Senha
	{
		private int id;
		private DateTime dataGerac;
		private DateTime horaGerac;
		private DateTime dataAtend;
		private DateTime horaAtend;

		public Senha(int id)
		{
			this.id = id;
			this.dataGerac = DateTime.Now;
			this.horaGerac = DateTime.Now;
		}

		public DateTime DataAtend
		{
			get { return dataAtend; }
			set { dataAtend = value; }
		}

		public DateTime HoraAtend
		{
			get { return horaAtend; }
			set { horaAtend = value; }
		}

		public string dadosParciais()
		{
			return id + " - " + dataGerac.ToString("dd/MM/yyyy") + " - " + horaGerac.ToString("HH:mm:ss");
		}

		public string dadosCompletos()
		{
			return id + " - " + dataGerac.ToString("dd/MM/yyyy") + " - " + horaGerac.ToString("HH:mm:ss") + " - " + dataAtend.ToString("dd/MM/yyyy") + " - " + horaAtend.ToString("HH:mm:ss");
		}
	}
}
