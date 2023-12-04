using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP06
{
	class Guiches
	{
		private List<Guiche> listaGuiches;

		public Guiches()
		{
			this.listaGuiches = new List<Guiche>();
		}

		public List<Guiche> ListaGuiches
		{
			get { return listaGuiches; }
		}

		public void adicionar(Guiche guiche)
		{
			listaGuiches.Add(guiche);
		}

		public Guiche buscar(int id)
		{
			foreach (Guiche guiche in listaGuiches)
			{
				if (guiche.Id == id)
				{
					return guiche;
				}
			}
			return null;
		}
	}
}
