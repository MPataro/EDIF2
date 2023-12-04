using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP06
{
	internal class Senhas
	{
		private int proximoAtendimento;
		private Queue<Senha> filaSenhas;

		public Queue<Senha> FilaSenhas
		{
			get { return filaSenhas; }
			set { filaSenhas = value; }
		}

		public Senhas()
		{
			this.filaSenhas = new Queue<Senha>();
			this.proximoAtendimento = 1;
		}

		public void gerar()
		{
			Senha senha = new Senha(proximoAtendimento);
			filaSenhas.Enqueue(senha);
			proximoAtendimento++;
		}
	}
}
