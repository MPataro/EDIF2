using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP06
{
	class Guiche
	{
		private int id;
		private Queue<Senha> atendimentos;

		public Guiche()
		{
			this.atendimentos = new Queue<Senha>();
			this.id = 0;
		}

		public Guiche(int id)
		{
			this.atendimentos = new Queue<Senha>();
			this.id = id;
		}

		public int Id
		{
			get { return id; }
		}

		public Queue<Senha> Atendimentos
		{
			get { return atendimentos; }
		}

		public bool chamar(Queue<Senha> filaSenhas)
		{
			if (filaSenhas.Count > 0)
			{
				Senha senha = filaSenhas.Dequeue();
				senha.DataAtend = DateTime.Now;
				senha.HoraAtend = DateTime.Now;
				atendimentos.Enqueue(senha);
				return true;
			}
			return false;
		}
	}
}
