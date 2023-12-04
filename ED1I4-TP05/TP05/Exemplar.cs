using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
	internal class Exemplar
	{

		private int tombo;
		private List<Emprestimo> emprestimos;

		public Exemplar(int tombo)
		{
			this.tombo = tombo;
			this.emprestimos = new List<Emprestimo>();
		}

		public int Tombo { get => tombo; set => tombo = value; }

		public List<Emprestimo> Emprestimos { get => emprestimos; set => emprestimos = value; }

		public bool Emprestar()
		{
			if (this.Disponivel())
			{
				this.emprestimos.Add(new Emprestimo(DateTime.Now, DateTime.Now.AddDays(7)));
				return true;
			}
			return false;
		}

		public bool Devolver()
		{
			if (!this.Disponivel())
			{
				this.emprestimos.Last().DtDevolucao = DateTime.Now;
				return true;
			}
			return false;
		}

		public bool Disponivel()
		{
			return this.emprestimos.Count == 0 || this.emprestimos.Last().DtDevolucao < DateTime.Now;
		}

		public int QtdeEmprestimos()
		{
			return this.emprestimos.Count;
		}
	}
}
