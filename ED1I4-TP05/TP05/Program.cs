using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
	class Program
	{
		static void Main(string[] args)
		{
			/**
			 * 
			 * O PROJETO DEVERÁ SER DESENVOLVIDO EM C# CONSOLE APPLICATION, OFERECENDO AS SEGUINTES OPÇÕES PARA O USUÁRIO:

--------------------------------------
| 0. Sair                            |
| 1. Adicionar livro                 |
| 2. Pesquisar livro (sintético)*    |
| 3. Pesquisar livro (analítico)**   |
| 4. Adicionar exemplar              |
| 5. Registrar empréstimo            |
| 6. Registrar devolução             |
--------------------------------------
* . Informar dos dados básicos do livro com as quantidades: total de exemplares, de exemplares disponíveis, de empréstimos e o respectivo percentual de disponibilidade do título

**. Informando, além dos dados acima, os detalhes dos seus exemplares e respectivos empréstimos



			*/

			Livros livros = new Livros();
			int opcao = 0;

			
			//make the options available to the user

			do
			{
				Console.WriteLine("0. Sair");
				Console.WriteLine("1. Adicionar livro");
				Console.WriteLine("2. Pesquisar livro (sintético)*");
				Console.WriteLine("3. Pesquisar livro (analítico)**");
				Console.WriteLine("4. Adicionar exemplar");
				Console.WriteLine("5. Registrar empréstimo");
				Console.WriteLine("6. Registrar devolução");
				opcao = int.Parse(Console.ReadLine());
				
				switch (opcao)
				{
					case 0:
						Console.WriteLine("Saindo...");
						break;
					case 1:
						Console.WriteLine("Adicionar livro");
						Console.WriteLine("Digite o ISBN do livro");
						int isbn = int.Parse(Console.ReadLine());
						Console.WriteLine("Digite o título do livro");
						string titulo = Console.ReadLine();
						Console.WriteLine("Digite o autor do livro");
						string autor = Console.ReadLine();
						Console.WriteLine("Digite a editora do livro");
						string editora = Console.ReadLine();
						Livro livro = new Livro(isbn, titulo, autor, editora);
						livros.Adicionar(livro);
						break;

					case 2:
						Console.WriteLine("Pesquisar livro (sintético)*");
						Console.WriteLine("Digite o ISBN do livro");
						int isbnPesquisa = int.Parse(Console.ReadLine());
						Livro livroIsbn = new Livro(isbnPesquisa);
						Livro livroPesquisa = livros.Pesquisar(livroIsbn);
						Console.WriteLine("ISBN: " + livroPesquisa.Isbn);
						Console.WriteLine("Título: " + livroPesquisa.Titulo);
						Console.WriteLine("Autor: " + livroPesquisa.Autor);
						Console.WriteLine("Editora: " + livroPesquisa.Editora);
						Console.WriteLine("Quantidade de exemplares: " + livroPesquisa.QtdeExemplares());
						Console.WriteLine("Quantidade de exemplares disponíveis: " + livroPesquisa.QtdeDisponiveis());
						Console.WriteLine("Quantidade de empréstimos: " + livroPesquisa.QtdeEmprestimos());
						Console.WriteLine("Percentual de disponibilidade: " + livroPesquisa.PercDisponibilidade());
						break;

					case 3:
						Console.WriteLine("Pesquisar livro (analítico)**");
						Console.WriteLine("Digite o ISBN do livro");
						int isbnPesquisaAnalitico = int.Parse(Console.ReadLine());
						Livro livroIsbnAnalitico = new Livro(isbnPesquisaAnalitico);
						Livro livroPesquisaAnalitico = livros.Pesquisar(livroIsbnAnalitico);
						Console.WriteLine("ISBN: " + livroPesquisaAnalitico.Isbn);
						Console.WriteLine("Título: " + livroPesquisaAnalitico.Titulo);
						Console.WriteLine("Autor: " + livroPesquisaAnalitico.Autor);
						Console.WriteLine("Editora: " + livroPesquisaAnalitico.Editora);
						Console.WriteLine("Quantidade de exemplares: " + livroPesquisaAnalitico.QtdeExemplares());
						Console.WriteLine("Quantidade de exemplares disponíveis: " + livroPesquisaAnalitico.QtdeDisponiveis());
						Console.WriteLine("Quantidade de empréstimos: " + livroPesquisaAnalitico.QtdeEmprestimos());
						Console.WriteLine("Percentual de disponibilidade: " + livroPesquisaAnalitico.PercDisponibilidade());
						Console.WriteLine("Exemplares: ");
						

						foreach (Exemplar exemplar in livroPesquisaAnalitico.Exemplares)
						{
							
							Console.WriteLine("Empréstimos: ");
							Console.WriteLine("Número de tombo: " + exemplar.Tombo);
							Console.WriteLine("Situação: " + (exemplar.Disponivel() ? "Disponível" : "Indisponível"));
							foreach (Emprestimo emprestimo in exemplar.Emprestimos)
							{
								Console.WriteLine("Data de empréstimo: " + emprestimo.DtEmprestimo);
								Console.WriteLine("Data de devolução: " + emprestimo.DtDevolucao);
							}
						}

						break;

						case 4:
						Console.WriteLine("Adicionar exemplar");
						Console.WriteLine("Digite o ISBN do livro");
						int isbnExemplar = int.Parse(Console.ReadLine());
						Console.WriteLine("Digite o número de tombo do exemplar");
						int tombo = int.Parse(Console.ReadLine());
						Livro livroExemplar = new Livro(isbnExemplar);
						Livro livroPesquisaExemplar = livros.Pesquisar(livroExemplar);
						if (livroPesquisaExemplar == null)
						{
							Console.WriteLine("Livro não encontrado");
							break;
						}
						Exemplar exemplar1 = new Exemplar(tombo);
						livroPesquisaExemplar.Exemplares.Add(exemplar1);
						Console.WriteLine("Exemplar adicionado com sucesso");
						break;

						case 5:
						Console.WriteLine("Registrar empréstimo");
						Console.WriteLine("Digite o ISBN do livro");
						int isbnEmprestimo = int.Parse(Console.ReadLine());
						Livro livroEmprestimo = new Livro(isbnEmprestimo);
						Livro livroPesquisaEmprestimo = livros.Pesquisar(livroEmprestimo);
						if (livroPesquisaEmprestimo == null)
						{
							Console.WriteLine("Livro não encontrado");
							break;
						}
						Console.WriteLine("Digite o número de tombo do exemplar");
						int tomboEmprestimo = int.Parse(Console.ReadLine());
						Exemplar exemplarEmprestimo = livroPesquisaEmprestimo.pesquisarExemplar(tomboEmprestimo);
						if (exemplarEmprestimo == null)
						{
							Console.WriteLine("Exemplar não encontrado");
							break;
						}
						Console.WriteLine("Digite a data de empréstimo");
						Console.WriteLine("Dia: ");
						int diaEmprestimo = int.Parse(Console.ReadLine());
						Console.WriteLine("Mês: ");
						int mesEmprestimo = int.Parse(Console.ReadLine());
						Console.WriteLine("Ano: ");
						int anoEmprestimo = int.Parse(Console.ReadLine());
						exemplarEmprestimo.Emprestimos.Add(new Emprestimo(new DateTime(anoEmprestimo, mesEmprestimo, diaEmprestimo)));
						Console.WriteLine("Empréstimo registrado com sucesso");
						break;

						case 6:
						Console.WriteLine("Registrar devolução");
						Console.WriteLine("Digite o ISBN do livro");
						int isbnDevolucao = int.Parse(Console.ReadLine());
						Livro livroDevolucao = new Livro(isbnDevolucao);
						Livro livroPesquisaDevolucao = livros.Pesquisar(livroDevolucao);
						if (livroPesquisaDevolucao == null)
						{
							Console.WriteLine("Livro não encontrado");
							break;
						}
						Console.WriteLine("Digite o número de tombo do exemplar");
						int tomboDevolucao = int.Parse(Console.ReadLine());
						Exemplar exemplarDevolucao = livroPesquisaDevolucao.pesquisarExemplar(tomboDevolucao);
						if (exemplarDevolucao == null)
						{
							Console.WriteLine("Exemplar não encontrado");
							break;
						}
						exemplarDevolucao.Devolver();
						Console.WriteLine("Devolução registrada com sucesso");
						break;
				}


			} while (opcao != 0);


			

				
		}
	}
}
