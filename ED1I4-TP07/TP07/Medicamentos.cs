using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07
{
	class Medicamentos
	{
		private List<Medicamento> listaMedicamentos;

		public Medicamentos()
		{
			listaMedicamentos = new List<Medicamento>();
		}

		public List<Medicamento> ListaMedicamentos { get => listaMedicamentos; }

		public void adicionar(Medicamento medicamento)
		{
			listaMedicamentos.Add(medicamento);
		}

		public bool deletar(Medicamento medicamento)
		{
			if (medicamento.qtdeDisponivel() == 0)
			{
				listaMedicamentos.Remove(medicamento);
				return true;
			}
			return false;
		}

		public Medicamento pesquisar(Medicamento medicamento)
		{
			foreach (Medicamento m in listaMedicamentos)
			{
				if (m.Id == medicamento.Id)
				{
					return m;
				}
			}
			return new Medicamento(-1, "", "");
		}

		public Lote pesquisarLote(Medicamento medicamento, Lote lote)
		{
			foreach (Medicamento m in listaMedicamentos)
			{
				if (m.Id == medicamento.Id)
				{
					foreach (Lote l in m.Lotes)
					{
						if (l.Id == lote.Id)
						{
							return l;
						}
					}
				}
			}
			return new Lote(-1, -1, DateTime.Now);
		}
	}
}
