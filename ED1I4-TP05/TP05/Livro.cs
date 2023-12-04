using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
	internal class Livro
	{
		/**
		 * ------------------------------------------------
| Livro                                        | 
|----------------------------------------------|
| - isbn: int                                  |
| - titulo: string                             |
| - autor: string                              |
| - editora: string                            |
| - exemplares: List<Exemplar>                 |
|----------------------------------------------|
| + adicionarExemplar(Exemplar exemplar): void |
| + qtdeExemplares(): int                      |
| + qtdeDisponiveis(): int                     |
| + qtdeEmprestimos(): int                     |
| + percDisponibilidade(): double              |
------------------------------------------------

		*/
		private int isbn;
		private string titulo;
		private string autor;
		private string editora;
		private List<Exemplar> exemplares;

		public Livro(int isbn, string titulo, string autor, string editora)
		{
			this.isbn = isbn;
			this.titulo = titulo;
			this.autor = autor;
			this.editora = editora;
			this.exemplares = new List<Exemplar>();
		}

		public Livro(int isbn)
		{
			this.isbn = isbn;
			this.titulo = "";
			this.autor = "";
			this.editora = "";
			this.exemplares = new List<Exemplar>();
		}

		public int Isbn { get => isbn; set => isbn = value; }
		public string Titulo { get => titulo; set => titulo = value; }
		public string Autor { get => autor; set => autor = value; }
		public string Editora { get => editora; set => editora = value; }
		public List<Exemplar> Exemplares { get => exemplares; set => exemplares = value; }
			
		public void AdicionarExemplar(Exemplar exemplar)
		{
			this.exemplares.Add(exemplar);
		}

		public Exemplar pesquisarExemplar (int tombo)
		{
			foreach (Exemplar exemplar in this.exemplares)
			{
				if (exemplar.Tombo == tombo)
				{
					return exemplar;
				}
			}
			return null;
		}

		public int QtdeExemplares()
		{
			return this.exemplares.Count;
		}

		public int QtdeDisponiveis()
		{
			int qtde = 0;
			foreach (Exemplar exemplar in this.exemplares)
			{
				if (exemplar.Disponivel())
				{
					qtde++;
				}
			}
			return qtde;
		}

		public int QtdeEmprestimos()
		{
			int qtde = 0;
			foreach (Exemplar exemplar in this.exemplares)
			{
				qtde += exemplar.QtdeEmprestimos();
			}
			return qtde;
		}

		public double PercDisponibilidade()
		{
			return (double)this.QtdeDisponiveis() / this.QtdeExemplares();
		}
	}
}
