using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
	internal class Disciplina
	{
		private int id;
		private string descricao;
		private Aluno[] alunos = new Aluno[15];
		private int alunoCount = 0;

		public Disciplina(int id, string descricao)
		{
			this.id = id;
			this.descricao = descricao;
		}

		public int Id
		{
			get => this.id;
		}

		public int AlunoCount
		{
			get => this.alunoCount;
		}

		public string Descricao
		{
			get => this.descricao;
		}

		public Aluno[] Alunos
		{
			get => this.alunos;
		}

		public bool matricularAluno(Aluno aluno)
		{
			if (alunoCount < 15)
			{
				bool alunoMatriculado = false;

				for (int i = 0; i < this.alunoCount; i++)
				{
					if (this.alunos[i].Id == aluno.Id)
					{
						alunoMatriculado = true;
						break;
					}
				}

				if (!alunoMatriculado)
				{
					this.alunos[this.alunoCount] = aluno;
					this.alunoCount++;
					return true;
				}
			}
			return false;
		}

		public bool desmatricularAluno(Aluno aluno)
		{
			int index = -1;

			for (int i = 0; i < alunoCount; i++)
			{
				if (alunos[i].Id == aluno.Id)
				{
					index = i;
					break;
				}
			}

			if (index != -1)
			{
				for (int i = index; i < alunoCount - 1; i++)
				{
					alunos[i] = alunos[i + 1];
				}
				alunos[alunoCount - 1] = null;
				alunoCount--;
				return true;
			}

			return false;
		}

	}
}
