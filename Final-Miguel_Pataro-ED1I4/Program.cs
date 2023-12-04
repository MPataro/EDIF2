using System;
using System.Collections.Generic;
using System.Linq;

// Trabalho realizado por Miguel da Silva Pataro

namespace Locacao
{    
    public class TipoEquipamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorDiaria { get; set; }
    }

    public class Equipamento
    {
        public int IdPatrimonio { get; set; }
        public bool Avariado { get; set; }
        public TipoEquipamento Tipo { get; set; }
    }

    public class ContratoLocacao
    {
        public int NumeroSequencial { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataRetorno { get; set; }
        public List<Equipamento> Equipamentos { get; set; }
        public decimal ValorDevido { get; set; }

        public ContratoLocacao()
        {
            Equipamentos = new List<Equipamento>();
        }
    }

    public class EmpresaLocacaoEquipamentos
    {
        private List<TipoEquipamento> tiposEquipamento;
        private Stack<Equipamento> pilhaDisponibilidade;
        private List<ContratoLocacao> contratos;

        public EmpresaLocacaoEquipamentos()
        {
            tiposEquipamento = new List<TipoEquipamento>();
            pilhaDisponibilidade = new Stack<Equipamento>();
            contratos = new List<ContratoLocacao>();
        }

        public void CadastrarTipoEquipamento(TipoEquipamento tipo)
        {
            tiposEquipamento.Add(tipo);
        }

        public List<TipoEquipamento> ConsultarTiposEquipamento()
        {
            return tiposEquipamento;
        }

        public void CadastrarEquipamento(Equipamento equipamento)
        {
            pilhaDisponibilidade.Push(equipamento);
        }

        public void RegistrarContratoLocacao(ContratoLocacao contrato)
        {
            contratos.Add(contrato);
        }

        public List<ContratoLocacao> ConsultarContratosLocacao()
        {
            return contratos;
        }

        public List<Equipamento> LiberarContratoLocacao(ContratoLocacao contrato)
        {
            List<Equipamento> equipamentosLiberados = new List<Equipamento>();

            foreach (var equipamento in contrato.Equipamentos)
            {
                pilhaDisponibilidade.Push(equipamento);
                equipamentosLiberados.Add(equipamento);
            }

            contratos.Remove(contrato); 
            return equipamentosLiberados;
        }

        public void DevolverEquipamentos(List<Equipamento> equipamentos)
        {
            foreach (var equipamento in equipamentos)
            {
                pilhaDisponibilidade.Push(equipamento);
            }
        }

        public List<Equipamento> ConsultarEquipamentosDisponiveis()
        {
            return pilhaDisponibilidade.ToList();
        }
    }

    class Program
    {
        static void Main()
        {
            EmpresaLocacaoEquipamentos empresa = new EmpresaLocacaoEquipamentos();

            while (true)
            {
                Console.WriteLine("Bem vindo ao Menu de Escolha! Selecione:");
                Console.WriteLine("1. Cadastrar Tipo de Equipamento");
                Console.WriteLine("2. Consultar Tipos de Equipamento");
                Console.WriteLine("3. Cadastrar Equipamento");
                Console.WriteLine("4. Registrar Contrato de Locação");
                Console.WriteLine("5. Consultar Contratos de Locação");
                Console.WriteLine("6. Liberar Contrato de Locação");
                Console.WriteLine("7. Consultar Contratos de Locação Liberados");
                Console.WriteLine("8. Devolver Equipamentos de Contrato Liberado");
                Console.WriteLine("0. Sair");

                char opcao = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Nova linha para espaçamento

                switch (opcao)
                {
                    case '1':
                        // Cadastrar Tipo de Equipamento
                        Console.WriteLine("Informe o tipo de equipamento:");
                        string nomeTipo = Console.ReadLine();
                        Console.WriteLine("Informe o valor diário de locação:");
                        decimal valorDiaria = Convert.ToDecimal(Console.ReadLine());

                        TipoEquipamento novoTipo = new TipoEquipamento
                        {
                            Id = empresa.ConsultarTiposEquipamento().Count + 1,
                            Nome = nomeTipo,
                            ValorDiaria = valorDiaria
                        };

                        empresa.CadastrarTipoEquipamento(novoTipo);
                        Console.WriteLine($"Tipo de equipamento {novoTipo.Nome}, com valor diário de {novoTipo.ValorDiaria} cadastrado com sucesso. A ID do {novoTipo.Nome} é {novoTipo.Id}.");
                        break;

                    case '2':
                        // Consultar Tipos de Equipamento
                        List<TipoEquipamento> tipos = empresa.ConsultarTiposEquipamento();
                        foreach (var tipo in tipos)
                        {
                            Console.WriteLine($"Tipo: {tipo.Nome}, Valor Diária: {tipo.ValorDiaria}");
                        }
                        break;

                    case '3':
                        // Cadastrar Equipamento
                        Console.WriteLine("Informe o ID do patrimônio:");
                        int idPatrimonio = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("O equipamento está avariado? (s/n)");
                        bool avariado = Console.ReadLine().ToLower() == "s";

                        Console.WriteLine("Informe o ID do tipo de equipamento:");
                        int idTipo = Convert.ToInt32(Console.ReadLine());

                        TipoEquipamento tipoEquipamento = empresa.ConsultarTiposEquipamento().FirstOrDefault(t => t.Id == idTipo);

                        if (tipoEquipamento != null)
                        {
                            Equipamento novoEquipamento = new Equipamento
                            {
                                IdPatrimonio = idPatrimonio,
                                Avariado = avariado,
                                Tipo = tipoEquipamento
                            };

                            empresa.CadastrarEquipamento(novoEquipamento);
                            Console.WriteLine($"Equipamento {novoEquipamento.IdPatrimonio} cadastrado com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Tipo de equipamento não encontrado.");
                        }
                        break;

                    case '4':
                        // Registrar Contrato de Locação
                        Console.WriteLine("Informe o número sequencial do contrato:");
                        int numeroSequencial = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a data de saída (yyyy-MM-dd):");
                        DateTime dataSaida = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Informe a data de retorno (yyyy-MM-dd):");
                        DateTime dataRetorno = Convert.ToDateTime(Console.ReadLine());

                        List<Equipamento> equipamentosContratados = new List<Equipamento>();

                        while (true)
                        {
                            Console.WriteLine("Escolha um equipamento para o contrato (ID do patrimônio):");
                            int idPatrimonioEquipamento = Convert.ToInt32(Console.ReadLine());

                            Equipamento equipamentoEscolhido = empresa.ConsultarEquipamentosDisponiveis()
                                .FirstOrDefault(e => e.IdPatrimonio == idPatrimonioEquipamento);

                            if (equipamentoEscolhido != null)
                            {
                                equipamentosContratados.Add(equipamentoEscolhido);
                                Console.WriteLine($"Equipamento {idPatrimonioEquipamento} adicionado ao contrato.");
                            }
                            else
                            {
                                Console.WriteLine($"Equipamento {idPatrimonioEquipamento} não disponível para locação.");
                            }

                            Console.WriteLine("Deseja adicionar mais equipamentos ao contrato? (s/n)");
                            if (Console.ReadLine().ToLower() != "s")
                                break;
                        }

                        ContratoLocacao novoContrato = new ContratoLocacao
                        {
                            NumeroSequencial = numeroSequencial,
                            DataSaida = dataSaida,
                            DataRetorno = dataRetorno,
                            Equipamentos = equipamentosContratados
                        };

                        empresa.RegistrarContratoLocacao(novoContrato);
                        Console.WriteLine($"Contrato de locação #{novoContrato.NumeroSequencial} registrado com sucesso.");
                        break;


                    case '5':
                        // Consultar Contratos de Locação
                        List<ContratoLocacao> contratosLocacao = empresa.ConsultarContratosLocacao();

                        if (contratosLocacao.Any())
                        {
                            Console.WriteLine("Contratos de Locação:");
                            foreach (var contrato in contratosLocacao)
                            {
                                Console.WriteLine($"Número Sequencial: {contrato.NumeroSequencial}");
                                Console.WriteLine($"Data de Saída: {contrato.DataSaida.ToShortDateString()}");
                                Console.WriteLine($"Data de Retorno: {contrato.DataRetorno.ToShortDateString()}");

                                Console.WriteLine("Equipamentos Contratados:");
                                foreach (var equipamento in contrato.Equipamentos)
                                {
                                    Console.WriteLine($"- ID Patrimônio: {equipamento.IdPatrimonio}, Avariado: {equipamento.Avariado}");
                                }

                                Console.WriteLine($"Valor Devido: {contrato.ValorDevido:C}");
                                Console.WriteLine("-------------------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhum contrato de locação registrado.");
                        }
                        break;


                    case '6':
                        // Liberar Contrato de Locação
                        Console.WriteLine("Informe o número sequencial do contrato a ser liberado:");
                        int numeroSequencialLiberacao = Convert.ToInt32(Console.ReadLine());

                        ContratoLocacao contratoParaLiberar = empresa.ConsultarContratosLocacao()
                            .FirstOrDefault(c => c.NumeroSequencial == numeroSequencialLiberacao);

                        if (contratoParaLiberar != null)
                        {
                            List<Equipamento> equipamentosLiberados = empresa.LiberarContratoLocacao(contratoParaLiberar);

                            if (equipamentosLiberados.Any())
                            {
                                Console.WriteLine($"Contrato de locação #{numeroSequencialLiberacao} liberado com sucesso.");

                                Console.WriteLine("Equipamentos Liberados:");
                                foreach (var equipamento in equipamentosLiberados)
                                {
                                    Console.WriteLine($"- ID Patrimônio: {equipamento.IdPatrimonio}, Avariado: {equipamento.Avariado}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Nenhum equipamento disponível para liberar do contrato #{numeroSequencialLiberacao}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Contrato de locação #{numeroSequencialLiberacao} não encontrado.");
                        }
                        break;


                    case '7':
                        // Consultar Contratos de Locação Liberados
                        List<ContratoLocacao> contratosLiberados = empresa.ConsultarContratosLocacao()
                            .Where(c => c.Equipamentos.Any()) // Filtra contratos com pelo menos um equipamento
                            .ToList();

                        if (contratosLiberados.Any())
                        {
                            Console.WriteLine("Contratos de Locação Liberados:");
                            foreach (var contrato in contratosLiberados)
                            {
                                Console.WriteLine($"Número Sequencial: {contrato.NumeroSequencial}");
                                Console.WriteLine($"Data de Saída: {contrato.DataSaida.ToShortDateString()}");
                                Console.WriteLine($"Data de Retorno: {contrato.DataRetorno.ToShortDateString()}");

                                Console.WriteLine("Equipamentos Contratados:");
                                foreach (var equipamento in contrato.Equipamentos)
                                {
                                    Console.WriteLine($"- ID Patrimônio: {equipamento.IdPatrimonio}, Avariado: {equipamento.Avariado}");
                                }

                                Console.WriteLine($"Valor Devido: {contrato.ValorDevido:C}");
                                Console.WriteLine("-------------------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhum contrato de locação liberado registrado.");
                        }
                        break;


                    case '8':
                        // Devolver Equipamentos de Contrato Liberado
                        Console.WriteLine("Informe o número sequencial do contrato para devolução:");
                        int numeroSequencialDevolucao = Convert.ToInt32(Console.ReadLine());

                        ContratoLocacao contratoDeDevolucao = empresa.ConsultarContratosLocacao()
                            .FirstOrDefault(c => c.NumeroSequencial == numeroSequencialDevolucao);

                        if (contratoDeDevolucao != null)
                        {
                            Console.WriteLine("Equipamentos a serem devolvidos:");

                            foreach (var equipamento in contratoDeDevolucao.Equipamentos)
                            {
                                Console.WriteLine($"- ID Patrimônio: {equipamento.IdPatrimonio}, Avariado: {equipamento.Avariado}");
                            }

                            Console.WriteLine("Deseja confirmar a devolução? (s/n)");

                            if (Console.ReadLine().ToLower() == "s")
                            {
                                empresa.DevolverEquipamentos(contratoDeDevolucao.Equipamentos);
                                Console.WriteLine("Equipamentos devolvidos com sucesso.");

                                // Remover o contrato dos controles da empresa
                                empresa.ConsultarContratosLocacao().Remove(contratoDeDevolucao);
                            }
                            else
                            {
                                Console.WriteLine("Devolução cancelada.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Contrato de locação #{numeroSequencialDevolucao} não encontrado.");
                        }
                        break;


                    case '0':
                        Console.WriteLine("Saindo do programa. Obrigado!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
