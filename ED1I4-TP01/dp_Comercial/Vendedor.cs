using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp_Comercial
{
    internal class Vendedor
    {
        private int id;
        private string name;
        private double percComissao;
        private Venda[] asVendas;

        public int Id
        {
            get => this.id;
        }
        public string Name
        {
            get => this.name;
        }
        public double PercComissao
        {
            get => this.percComissao;
        }
        public Venda[] AsVendas
        {
            get => this.asVendas;
        }

        public Vendedor(int id, string name, double percComissao, Venda[] asVendas)
        {
            this.id = id;
            this.name = name;
            this.percComissao = percComissao;
            this.asVendas = asVendas;
            
        }


        public void registrarVenda(int dia, Venda venda)
        {
            this.asVendas[dia - 1] = venda;
        }

        public double valorVendas()
        {
            double valorVendas = 0;
            foreach (Venda venda in asVendas)
            {
                valorVendas += venda.Valor;
            }
            return valorVendas;
        }

        public double valorComissao()
        {
            return this.valorVendas() * this.percComissao;
        }
    }
}
