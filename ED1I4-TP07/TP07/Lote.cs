using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07
{
	class Lote
	{
		private int id;
		private int qtde;
		private DateTime venc;

		public Lote()
		{
		}

		public Lote(int id, int qtde, DateTime venc)
		{
			this.id = id;
			this.qtde = qtde;
			this.venc = venc;
		}

		public int Id { get => id; }
		public int Qtde { get => qtde; set => qtde = value; }
		public DateTime Venc { get => venc; set => venc = value; }
		public String DataVencimento { get => venc.ToString("dd/MM/yyyy"); }

		public override string ToString()
		{
			return id + "-" + qtde + "-" + venc;
		}
	}
}
