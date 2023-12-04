using dp_Comercial;
using System.ComponentModel;

int option = -1;
int vendedorId = 0;
int max = 10;
int dias = 31;
Venda[] vendas = new Venda[max];

for (int i = 0; i < max; i++)
{
    vendas[i] = new Venda(0, 0);
}

Vendedor[] vendedorDef = new Vendedor[max];

for (int i = 0; i < max; i++)
{
    vendedorDef[i] = new Vendedor(-1, "...", 0, vendas);
}

Vendedores vendedores = new Vendedores(max, 0, vendedorDef);

do
{
    Console.WriteLine("Escolha uma opção");
    Console.WriteLine("0.Sair");
    Console.WriteLine("1.Cadastrar vendedor");
    Console.WriteLine("2.Consultar vendedor");
    Console.WriteLine("3.Excluir vendedor");
    Console.WriteLine("4.Registrar Venda");
    Console.WriteLine("5.Listar vendedores");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine("Digite as informações do vendedor");
            Console.WriteLine("Digite o nome do vendedor:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o percentual de Comissão do vendedor");
            double percentual = double.Parse(Console.ReadLine());
            
            Venda[] vendasDef = new Venda[dias];
            
            for (int i = 0; i < dias; i++)
            {
                vendasDef[i] = new Venda(0, 0);
            }
            
            Vendedor vendedor = new Vendedor(vendedorId, nome, percentual, vendasDef);
            Console.WriteLine(vendedores.AddVendedor(vendedor) ? "Vendedor adicionado!" : "Não foi possível adicionar o vendedor");
            break;
        
        case 2:
            Console.WriteLine("Digite o id do vendedor");
            int pesquisarId = int.Parse(Console.ReadLine());
            Vendedor VendedorPesq = new Vendedor(pesquisarId, "...", 0, new Venda[] { new Venda(0, 0) });
            Vendedor VendedorAchado = vendedores.SearchVendedor(VendedorPesq);
            Console.WriteLine("Nome do Vendedor: " + VendedorAchado.Name);
            Console.WriteLine("Id do Vendedor: " + VendedorAchado.Id);
            Console.WriteLine("Comissão do Vendedor: " + VendedorAchado.PercComissao);
            Console.WriteLine("Valor das vendas do Vendedor: " + VendedorAchado.valorVendas());
            // valor médio das vendas diárias (de cada dia que houve registro de venda).
            for (int i = 0; i < dias; i++)
            {
                bool temVenda = VendedorAchado.AsVendas[i].Valor != 0 && VendedorAchado.AsVendas[i].Qntd != 0;
                if (temVenda)
                {
                    Console.WriteLine("Valor médio do dia " + i + ": " + VendedorAchado.AsVendas[i].valorMedio());
                }
            }
            double valorVendas = 0; 
            foreach(Venda venda in VendedorAchado.AsVendas)
            {
                valorVendas += venda.valorMedio();
            }
            Console.WriteLine("Valor Médio das vendas" + valorVendas);
            break;

        case 3:
            Console.WriteLine("Digite o id do vendedor à ser excluído");
            int excluirId = int.Parse(Console.ReadLine());
            Vendedor VendedorExcluir = new Vendedor(excluirId, "...", 0, new Venda[] { new Venda(0, 0) });
            Console.WriteLine(vendedores.DelVendedor(VendedorExcluir) ? "Vendedor excluído!" : "Vendedor inexistente");
            break;

        case 4:
            Console.WriteLine("Digite o id do vendedor que fez a venda ");
            int idVendaVendedor = int.Parse(Console.ReadLine());
            Vendedor VendedorAchar = new Vendedor(idVendaVendedor, "...", 0, new Venda[] { new Venda(0, 0) });
            Vendedor VendedorAcharAchado = vendedores.SearchVendedor(VendedorAchar);
            if (VendedorAcharAchado.Id != -1)
            {
                Console.WriteLine("Digite o dia que fez a venda: ");
                int diadaVenda = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de vendas: ");
                int qtdVenda = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor das vendas: ");
                double valorVenda = double.Parse(Console.ReadLine());
                VendedorAcharAchado.registrarVenda(diadaVenda, new Venda(qtdVenda, valorVenda));
                Console.WriteLine("Venda registrada!");
            }
            else
            {
                Console.WriteLine("Vendedor não encontrado!");
            }
            break;
        case 5:
            Console.WriteLine("Lista de todos os vendedores: ");
            double totValorVenda = 0;
            double totValorComissao = 0;
            int qtdVendedores = 0;
            foreach (Vendedor oVendedor in vendedores.OsVendedores)
            {
                if (oVendedor.Id != -1)
                {
                    qtdVendedores++;
                    Console.WriteLine("ID do vendedor: " + oVendedor.Id);
                    Console.WriteLine("Nome do vendedor: " + oVendedor.Name);
                    Console.WriteLine("Valor das vendas do vendedor: " + oVendedor.valorVendas());
                    Console.WriteLine("Comissão do vendedor: " + oVendedor.PercComissao);
                    totValorComissao += oVendedor.PercComissao;
                    double valorVendasR = 0;
                    foreach (Venda venda in oVendedor.AsVendas)
                    {
                        valorVendasR += venda.valorMedio();
                    }
                    totValorVenda += valorVendasR;
                    Console.WriteLine("Valor medio das vendas do vendedor: " + valorVendasR);
                }
            }
            if (qtdVendedores > 0)
            {
                Console.WriteLine("Valor total das vendas: " + totValorVenda);
                Console.WriteLine("Valor total das comissões: " + totValorComissao);
            } else
            {
                Console.WriteLine("Não há nenhum vendedor registrado no momento");
            }
            break;
            
    }



} while (option != 0);

