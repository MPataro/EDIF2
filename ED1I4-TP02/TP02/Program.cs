using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Escola escola = new Escola();
			int opcao;

			do
			{
				Console.WriteLine("Opções no seletor:");
				Console.WriteLine("0. Sair");
				Console.WriteLine("1. Adicionar curso");
				Console.WriteLine("2. Pesquisar curso (mostrar inclusive as disciplinas associadas)");
				Console.WriteLine("3. Remover curso (não pode ter nenhuma disciplina associada)");
				Console.WriteLine("4. Adicionar disciplina no curso");
				Console.WriteLine("5. Pesquisar disciplina (mostrar inclusive os alunos matriculados)");
				Console.WriteLine("6. Remover disciplina do curso (não pode ter nenhum aluno matriculado)");
				Console.WriteLine("7. Matricular aluno na disciplina");
				Console.WriteLine("8. Remover aluno da disciplina");
				Console.WriteLine("9. Pesquisar aluno (informar seu nome e em quais disciplinas ele está matriculado)");
				Console.Write("Escolha uma opção: ");
				opcao = int.Parse(Console.ReadLine());

				switch (opcao)
				{
					case 0:
						Console.WriteLine("finalizando...");
						break;
					case 1:
						Console.Write("Digite o ID do curso: ");
						int cursoId = int.Parse(Console.ReadLine());
						Console.Write("Digite a descrição do curso: ");
						string cursoDescricao = Console.ReadLine();
						Curso novoCurso = new Curso(cursoId, cursoDescricao);
						escola.adicionarCurso(novoCurso);
						Console.WriteLine("Curso adicionado com sucesso!");
						break;

					case 2:
						Console.Write("Digite o ID do curso a ser pesquisado: ");
						int pesquisaCursoId = int.Parse(Console.ReadLine());
						Curso cursoEncontrado = escola.pesquisarCurso(new Curso(pesquisaCursoId, ""));
						if (cursoEncontrado != null)
						{
							Console.WriteLine($"Curso encontrado: ID={cursoEncontrado.Id}, Descrição={cursoEncontrado.Descricao}");
							foreach (Disciplina disciplina in cursoEncontrado.Disciplinas)
							{
								if (disciplina != null)
								{
									Console.WriteLine($"  Disciplina: ID={disciplina.Id}, Descrição={disciplina.Descricao}");
								}
							}
						}
						else
						{
							Console.WriteLine("Curso não encontrado.");
						}
						break;

					case 3:
						Console.Write("Digite o ID do curso a ser removido: ");
						int removeCursoId = int.Parse(Console.ReadLine());
						Curso cursoRemover = escola.pesquisarCurso(new Curso(removeCursoId, ""));
						if (cursoRemover != null)
						{
							if (cursoRemover.DisciplinaCount > 0)
							{
								Console.WriteLine("Não é possível excluir o curso. Há disciplinas associadas.");
							} else
							{
								escola.removerCurso(cursoRemover);
								Console.WriteLine("Curso removido com sucesso!");
							}
						}
						else
						{
							Console.WriteLine("Curso não encontrado.");
						}
						break;

					case 4:
						Console.Write("Digite o ID do curso onde deseja adicionar a disciplina: ");
						int addDisciplinaCursoId = int.Parse(Console.ReadLine());
						Curso cursoAdicionarDisciplina = escola.pesquisarCurso(new Curso(addDisciplinaCursoId, ""));
						if (cursoAdicionarDisciplina != null)
						{
							Console.Write("Digite o ID da disciplina: ");
							int disciplinaId = int.Parse(Console.ReadLine());
							Console.Write("Digite a descrição da disciplina: ");
							string disciplinaDescricao = Console.ReadLine();
							Disciplina novaDisciplina = new Disciplina(disciplinaId, disciplinaDescricao);
							if (cursoAdicionarDisciplina.adicionarDisciplina(novaDisciplina))
							{
								Console.WriteLine("Disciplina adicionada ao curso com sucesso!");
							}
							else
							{
								Console.WriteLine("Não foi possível adicionar a disciplina ao curso.");
							}
						}
						else
						{
							Console.WriteLine("Curso não encontrado.");
						}
						break;

					case 5:
						Console.Write("Digite o ID da disciplina a ser pesquisada: ");
						int pesquisaDisciplinaId = int.Parse(Console.ReadLine());
						Disciplina disciplinaEncontrada = null;
						foreach (Curso curso in escola.Cursos)
						{
							if (curso != null)
							{
								disciplinaEncontrada = curso.pesquisarDisciplina(new Disciplina(pesquisaDisciplinaId, ""));
								if (disciplinaEncontrada != null)
								{
									break;
								}
							}
						}
						if (disciplinaEncontrada != null)
						{
							Console.WriteLine($"Disciplina encontrada: ID={disciplinaEncontrada.Id}, Descrição={disciplinaEncontrada.Descricao}");
							foreach (Aluno aluno in disciplinaEncontrada.Alunos)
							{
								if (aluno != null)
								{
									Console.WriteLine($"  Aluno: ID={aluno.Id}, Nome={aluno.Nome}");
								}
							}
						}
						else
						{
							Console.WriteLine("Disciplina não encontrada.");
						}
						break;

					case 6:
						Console.Write("Digite o ID do curso onde deseja remover a disciplina: ");
						int removeDisciplinaCursoId = int.Parse(Console.ReadLine());
						Curso cursoRemoverDisciplina = escola.pesquisarCurso(new Curso(removeDisciplinaCursoId, ""));
						if (cursoRemoverDisciplina != null)
						{
							Console.Write("Digite o ID da disciplina a ser removida: ");
							int removeDisciplinaId = int.Parse(Console.ReadLine());
							Disciplina disciplinaRemove = cursoRemoverDisciplina.pesquisarDisciplina(new Disciplina(removeDisciplinaId, ""));
							if (disciplinaRemove != null)
							{
								bool alunosMatriculados = false;
								foreach (Aluno aluno in disciplinaRemove.Alunos)
								{
									if (aluno != null)
									{
										alunosMatriculados = true;
										break;
									}
								}

								if (!alunosMatriculados)
								{
									cursoRemoverDisciplina.removerDisciplina(disciplinaRemove);
									Console.WriteLine("Disciplina removida do curso com sucesso!");
								}
								else
								{
									Console.WriteLine("Não foi possível remover a disciplina. Ela possui alunos matriculados.");
								}
							}
							else
							{
								Console.WriteLine("Disciplina não encontrada.");
							}
						}
						else
						{
							Console.WriteLine("Curso não encontrado.");
						}
						break;

					case 7:
						Console.Write("Digite o ID do aluno: ");
						int matricularAlunoId = int.Parse(Console.ReadLine());
						Console.Write("Digite o nome do aluno: ");
						string matricularAlunoNome = Console.ReadLine();
						Aluno alunoMatricular = new Aluno(matricularAlunoId, matricularAlunoNome);

						Console.Write("Digite o ID da disciplina para matricular o aluno: ");
						int matricularDisciplinaId = int.Parse(Console.ReadLine());

						Curso cursoDaDisciplina = null;
						Disciplina disciplinaMatricular = null;

						foreach (Curso curso in escola.Cursos)
						{
							if (curso != null)
							{
								disciplinaMatricular = curso.pesquisarDisciplina(new Disciplina(matricularDisciplinaId, ""));
								if (disciplinaMatricular != null)
								{
									cursoDaDisciplina = curso;
									break;
								}
							}
						}

						if (disciplinaMatricular != null && cursoDaDisciplina != null)
						{
							if (alunoMatricular.podeMatricular(cursoDaDisciplina))
							{
								if (disciplinaMatricular.matricularAluno(alunoMatricular))
								{
									Console.WriteLine($"Aluno {alunoMatricular.Nome} matriculado na disciplina {disciplinaMatricular.Descricao}.");
								}
								else
								{
									Console.WriteLine("Não foi possível matricular o aluno na disciplina.");
								}
							}
							else
							{
								Console.WriteLine("O aluno não pode ser matriculado na disciplina devido a limitações.");
							}
						}
						else
						{
							Console.WriteLine("Disciplina não encontrada.");
						}
						break;

					case 8:
						Console.Write("Digite o ID do aluno: ");
						int removerAlunoId = int.Parse(Console.ReadLine());
						Aluno alunoRemover = new Aluno(removerAlunoId, "");

						Console.Write("Digite o ID da disciplina para remover o aluno: ");
						int removerDisciplinaId = int.Parse(Console.ReadLine());

						Curso cursoDaDisciplinaRemover = null;
						Disciplina disciplinaRemover = null;

						foreach (Curso curso in escola.Cursos)
						{
							if (curso != null)
							{
								disciplinaRemover = curso.pesquisarDisciplina(new Disciplina(removerDisciplinaId, ""));
								if (disciplinaRemover != null)
								{
									cursoDaDisciplinaRemover = curso;
									break;
								}
							}
						}

						if (disciplinaRemover != null && cursoDaDisciplinaRemover != null)
						{
							if (disciplinaRemover.desmatricularAluno(alunoRemover))
							{
								Console.WriteLine($"Aluno {alunoRemover.Nome} removido da disciplina {disciplinaRemover.Descricao}.");
							}
							else
							{
								Console.WriteLine("Não foi possível remover o aluno da disciplina.");
							}
						}
						else
						{
							Console.WriteLine("Disciplina não encontrada.");
						}
						break;

					case 9:
						Console.Write("Digite o ID do aluno: ");
						int idAlunoPesquisar = int.Parse(Console.ReadLine());

						foreach (Curso curso in escola.Cursos)
						{
							if (curso != null)
							{
								foreach (Disciplina disciplina in curso.Disciplinas)
								{
									if (disciplina != null)
									{
										foreach (Aluno aluno in disciplina.Alunos)
										{
											if (aluno != null && aluno.Id == idAlunoPesquisar)
											{
												Console.WriteLine($"Aluno {aluno.Nome} está matriculado na disciplina {disciplina.Descricao}");
											}
										}
									}
								}
							}
						}

						break;

					default:
						Console.WriteLine("Opção inválida!");
						break;
				}

			} while (opcao != 0);
		}
    }
}
