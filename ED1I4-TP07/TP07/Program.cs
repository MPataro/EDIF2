using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Medicamentos medicamentos = new Medicamentos();
			int opcao = 0;
			
			do
			{
				Console.WriteLine("0. Finalizar processo");
				Console.WriteLine("1. Cadastrar medicamento");
				Console.WriteLine("2. Consultar medicamento (sintético: informar dados1)");
				Console.WriteLine("3. Consultar medicamento (analítico: informar dados1 + lotes2)");
				Console.WriteLine("4. Comprar medicamento (cadastrar lote)");
				Console.WriteLine("5. Vender medicamento (abater do lote mais antigo)");
				Console.WriteLine("6. Listar medicamentos (informando dados sintéticos)");
				Console.Write("Opção: ");
				opcao = int.Parse(Console.ReadLine());
				Console.WriteLine();
				switch (opcao)
				{
					case 0:
						Console.WriteLine("Finalizando processo...");
						break;
					case 1:
						Console.WriteLine("Cadastrar medicamento");
						Console.Write("ID: ");
						int id = int.Parse(Console.ReadLine());
						Medicamento medicamentoCriar = medicamentos.pesquisar(new Medicamento(id, "", ""));
						if (medicamentoCriar.Id != -1)
						{
							Console.WriteLine("ID já cadastrado!");
							break;
						}
						Console.Write("Nome: ");
						string nome = Console.ReadLine();
						Console.Write("Laboratório: ");
						string laboratorio = Console.ReadLine();
						medicamentos.adicionar(new Medicamento(id, nome, laboratorio));
						Console.WriteLine("Medicamento cadastrado com sucesso!");
						break;
					case 2:
						Console.WriteLine("Consultar medicamento (dados)");
						Console.Write("ID: ");
						id = int.Parse(Console.ReadLine());
						Medicamento medicamento = medicamentos.pesquisar(new Medicamento(id, "", ""));
						if (medicamento.Id != -1)
						{
							Console.WriteLine("\n\n");
							Console.WriteLine("ID: " + medicamento.Id);
							Console.WriteLine("Nome: " + medicamento.Nome);
							Console.WriteLine("Laboratório: " + medicamento.Laboratorio);
							Console.WriteLine("Quantidade disponível: " + medicamento.qtdeDisponivel());
						}
						else
						{
							Console.WriteLine("Medicamento não encontrado!");
						}
						break;
					case 3:
						Console.WriteLine("Consultar medicamento (dados + lotes)");
						Console.Write("ID: ");
						id = int.Parse(Console.ReadLine());
						medicamento = medicamentos.pesquisar(new Medicamento(id, "", ""));
						if (medicamento.Id != -1)
						{
							Console.WriteLine("\n\n");
							Console.WriteLine("ID: " + medicamento.Id);
							Console.WriteLine("Nome: " + medicamento.Nome);
							Console.WriteLine("Laboratório: " + medicamento.Laboratorio);
							Console.WriteLine("Quantidade disponível: " + medicamento.qtdeDisponivel());
							if (medicamento.Lotes.Count > 0)
							{
								Console.WriteLine("Lotes:");
								foreach (Lote lote in medicamento.Lotes)
								{
									Console.WriteLine("ID: " + lote.Id);
									Console.WriteLine("Quantidade: " + lote.Qtde);
									Console.WriteLine("Data de vencimento: " + lote.DataVencimento);
								}
							}
						}
						else
						{
							Console.WriteLine("Medicamento não encontrado!");
						}
						break;
					case 4:
						Console.WriteLine("Comprar medicamento (cadastrar lote)");
						Console.Write("ID do medicamento: ");
						id = int.Parse(Console.ReadLine());
						medicamento = medicamentos.pesquisar(new Medicamento(id, "", ""));
						if (medicamento.Id != -1)
						{
							Console.Write("ID do lote: ");
							int idLote = int.Parse(Console.ReadLine());
							Lote lotePesquisar = medicamentos.pesquisarLote(medicamento, new Lote(idLote, 0, DateTime.Now));
                            if (lotePesquisar.Id != -1)
							{
								Console.WriteLine("ID do lote já cadastrado!");
								break;
							}
                            Console.Write("Quantidade: ");
							int qtde = int.Parse(Console.ReadLine());
							Console.Write("Data de vencimento...");
							Console.Write("Dia: ");
							int dia = int.Parse(Console.ReadLine());
							Console.Write("Mês: ");
							int mes = int.Parse(Console.ReadLine());
							Console.Write("Ano: ");
							int ano = int.Parse(Console.ReadLine());
							DateTime venc = new DateTime(ano, mes, dia);
							Lote lote = new Lote(idLote, qtde, venc);
							medicamento.comprar(lote);
							Console.WriteLine("Lote cadastrado com sucesso!");
						}
						else
						{
							Console.WriteLine("Medicamento não encontrado!");
						}
						break;
					case 5:
						Console.WriteLine("Vender medicamento (abater do lote mais antigo)");
						Console.Write("ID: ");
						id = int.Parse(Console.ReadLine());
						medicamento = medicamentos.pesquisar(new Medicamento(id, "", ""));
						if (medicamento.Id != -1)
						{
							Console.Write("Quantidade: ");
							int qtde = int.Parse(Console.ReadLine());
							if (medicamento.vender(qtde))
							{
								Console.WriteLine("Venda realizada com sucesso!");
							} else
							{
								Console.WriteLine("Não foi possível realizar a venda!");
							}
						}
						else
						{
							Console.WriteLine("Medicamento não encontrado!");
						}
						break;
					case 6:
						Console.WriteLine("Listar medicamentos");
						Console.WriteLine("Medicamentos: \n\n");
						foreach (Medicamento m in medicamentos.ListaMedicamentos)
						{
							Console.WriteLine("ID: " + m.Id);
							Console.WriteLine("Nome: " + m.Nome);
							Console.WriteLine("Laboratório: " + m.Laboratorio);
							Console.WriteLine("Quantidade disponível: " + m.qtdeDisponivel());
						}
						break;
				}
			} while (opcao != 0);
		}
	}
}
