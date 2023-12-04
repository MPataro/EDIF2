using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
	internal class Curso
	{
		private int id;
		private string descricao;
		private Disciplina[] disciplinas = new Disciplina[12];
		private int disciplinaCount = 0;

		public Curso(int id, string descricao)
		{
			this.id = id;
			this.descricao = descricao;
		}

		public Disciplina[] Disciplinas {
			get => this.disciplinas;
			set => this.disciplinas = value;
		}

		public int Id
		{
			get => this.id;
		}

		public int DisciplinaCount
		{
			get => this.disciplinaCount;
		}

		public string Descricao
		{
			get => this.descricao;
		}

		public bool adicionarDisciplina(Disciplina disciplina)
		{
			if (disciplinaCount < 12)
			{
				bool disciplinaAdicionada = false;

				for (int i = 0; i < disciplinaCount; i++)
				{
					if (this.disciplinas[i].Id == disciplina.Id)
					{
						disciplinaAdicionada = true;
						break;
					}
				}
				if (!disciplinaAdicionada)
				{
					disciplinas[disciplinaCount] = disciplina;
					disciplinaCount++;
					return true;
				}
			}
			return false;
		}

		public Disciplina pesquisarDisciplina(Disciplina disciplina)
		{
			foreach (Disciplina d in disciplinas)
			{
				if (d != null && d.Id == disciplina.Id)
				{
					return d;
				}
			}
			return null;
		}

		public bool removerDisciplina(Disciplina disciplina)
		{
			int index = -1;

			for (int i = 0; i < disciplinaCount; i++)
			{
				if (disciplinas[i].Id == disciplina.Id)
				{
					index = i;
					break;
				}
			}

			if (index != -1)
			{
				for (int i = index; i < disciplinaCount - 1; i++)
				{
					disciplinas[i] = disciplinas[i + 1];
				}
				disciplinas[disciplinaCount - 1] = null;
				disciplinaCount--;
				return true;
			}

			return false;
		}


	}
}
