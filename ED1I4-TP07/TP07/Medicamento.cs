using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07
{
	class Medicamento
	{
		private int id;
		private string nome;
		private string laboratorio;
		private Queue<Lote> lotes;

		public Medicamento()
		{
		}

		public Medicamento(int id, string nome, string laboratorio)
		{
			this.id = id;
			this.nome = nome;
			this.laboratorio = laboratorio;
			this.lotes = new Queue<Lote>();
		}

		public int Id { get => id; }
		public string Nome { get => nome; }
		public string Laboratorio { get => laboratorio; }
		public Queue<Lote> Lotes { get => lotes; }

		public int qtdeDisponivel()
		{
			int qtde = 0;
			foreach (Lote lote in lotes)
			{
				qtde += lote.Qtde;
			}
			return qtde;
		}

		public void comprar(Lote lote)
		{
			lotes.Enqueue(lote);
		}

		public bool vender(int qtde)
		{
			if (qtdeDisponivel() >= qtde)
			{
				while (qtde > 0)
				{
					Lote lote = lotes.Peek();
					if (lote.Qtde > qtde)
					{
						lote.Qtde -= qtde;
						qtde = 0;
					}
					else
					{
						qtde -= lote.Qtde;
						lotes.Dequeue();
					}
				}
				return true;
			}
			return false;
		}

		public override string ToString()
		{
			return id + "-" + nome + "-" + laboratorio + "-" + qtdeDisponivel();
		}

		public override bool Equals(object obj)
		{
			Medicamento medicamento1 = (Medicamento) obj;
			return this.id == medicamento1.id;
		}
	}
}
