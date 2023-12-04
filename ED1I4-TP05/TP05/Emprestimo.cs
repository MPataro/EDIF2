using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
	class Emprestimo
	{
		private DateTime dtEmprestimo;
		private DateTime? dtDevolucao;

		public Emprestimo(DateTime dtEmprestimo, DateTime dtDevolucao)
		{
			this.dtEmprestimo = dtEmprestimo;
			this.dtDevolucao = dtDevolucao;
		}

		public Emprestimo(DateTime dtEmprestimo)
		{
			this.dtEmprestimo = dtEmprestimo;
			this.dtDevolucao = null;
		}

		public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }

		public DateTime? DtDevolucao { get => dtDevolucao; set => dtDevolucao = value; }
	}
}
