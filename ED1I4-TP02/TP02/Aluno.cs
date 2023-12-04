using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
	internal class Aluno
	{
		private int id;
		private string nome;
		private Curso cursoMatriculado;
		private Disciplina[] disciplinasMatriculadas = new Disciplina[6];
		private int disciplinaCount = 0;

		public Aluno(int id, string nome)
		{
			this.id = id;
			this.nome = nome;
		}

		public int Id
		{
			get => this.id;
		}

		public string Nome
		{
			get => this.nome;
		}

		public bool podeMatricular(Curso curso)
		{
			if (cursoMatriculado != null || disciplinaCount >= 6)
			{
				return false;
			}

			foreach (Disciplina disciplina in curso.Disciplinas)
			{
				if (disciplina != null && disciplina.AlunoCount < 15)
				{
					bool alunoEnrolled = false;
					foreach (Aluno aluno in disciplina.Alunos)
					{
						if (aluno != null && aluno.Id == this.id)
						{
							alunoEnrolled = true;
							break;
						}
					}
					if (!alunoEnrolled)
					{
						return true;
					}
				}
			}

			return false;
		}
	}

}
