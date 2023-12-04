using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp_Comercial
{
    internal class Vendedores
    {
        private Vendedor[] osVendedores; //variavel
        private int max;
        private int qtde;
    
        public Vendedor[] OsVendedores
        {
            get => this.osVendedores;
        }

        public int Max
        {
            get => this.max;
        }

        public int Qtde
        {
            get => this.qtde;
        }

        public Vendedores(int max, int qtde, Vendedor[] osVendedores)
        {
            
            this.max = max;
            this.qtde = qtde;
            this.osVendedores = osVendedores;
        }

        public bool AddVendedor(Vendedor v)
        {
            
            if (this.qtde < this.max)
                {
                
                this.osVendedores[this.qtde] = v;
                this.qtde++;
                    return true;
                
                }

            return false;
        }


        public bool SemVenda(Venda[] vendas)
        {

            bool vazio = true;

            foreach (Venda venda in vendas)
            {
                if (venda.Qntd != 0 || venda.Valor != 0)
                {
                    vazio = false;
                    break;
                }
            }
            return vazio;

        }

        public bool DelVendedor(Vendedor v)
        {
            bool podeRemover;
            
                int i = 0;
                while (i < this.max && this.osVendedores[i].Id != v.Id)
                {
                    i++;
                }
                podeRemover = i < this.max && this.SemVenda(this.osVendedores[i].AsVendas);
    

                if (podeRemover)
                {
                    while (i < this.max - 1)
                    {
                        this.osVendedores[i] = this.osVendedores[i + 1];
                        i++;
                    }

                this.osVendedores[i] = new Vendedor(-1, "...", 0, new Venda[] { new Venda(0, 0) });
                    this.qtde--;

                }
            
            return podeRemover;
        }

        public Vendedor SearchVendedor(Vendedor v)
        {
            Vendedor vendedorAchado = new Vendedor(-1, "...", 0, new Venda[] { new Venda(0, 0) });


            foreach (Vendedor vendedor in this.osVendedores)
            {
                if ( vendedor.Id == v.Id)
                {
                    vendedorAchado = vendedor;
                    break;
                }
            }
            return vendedorAchado;
        }


        public double valorVendas()
        {
            double valorVendas = 0;

            foreach (Vendedor vendedor in this.osVendedores)
            {
                valorVendas += vendedor.valorVendas();
            }

            return valorVendas;
        }

        public double valorComissao()
        {
            double valorComissao = 0;

            foreach (Vendedor vendedor in this.osVendedores)
            {
                valorComissao += vendedor.valorComissao();
            }

            return valorComissao;
        }

    }
}
