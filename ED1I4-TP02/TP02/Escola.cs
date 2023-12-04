using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
	internal class Escola
	{
		private Curso[] cursos = new Curso[5];
		private int cursoCount = 0;

		public Curso[] Cursos
		{
			get => this.cursos;
		}

		public bool adicionarCurso(Curso curso)
		{
			if (cursoCount < 5)
			{
				bool cursoAdicionado = false;

				for (int i = 0; i < cursoCount; i++)
				{
					if (this.cursos[i].Id == curso.Id)
					{
						cursoAdicionado = true;
						break;
					}
				}

				if (!cursoAdicionado)
				{
					cursos[cursoCount] = curso;
					cursoCount++;
					return true;
				}
			}
			return false;
		}

		public Curso pesquisarCurso(Curso curso)
		{
			foreach (Curso c in cursos)
			{
				if (c != null && c.Id == curso.Id)
				{
					return c;
				}
			}
			return null;
		}

		public bool removerCurso(Curso curso)
		{
			int index = -1;

			for (int i = 0; i < cursoCount; i++)
			{
				if (cursos[i].Id == curso.Id)
				{
					index = i;
					break;
				}
			}

			if (index != -1)
			{
				for (int i = index; i < cursoCount - 1; i++)
				{
					cursos[i] = cursos[i + 1];
				}
				cursos[cursoCount - 1] = null;
				cursoCount--;
				return true;
			}

			return false;
		}
	}

}
