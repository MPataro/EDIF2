using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP06
{
	public partial class Form1 : Form
	{
		private Senhas senhas;
		private Guiches guiches;
		int qtdGuiches = 0;

		public Form1()
		{
			InitializeComponent();
			this.senhas = new Senhas();
			this.guiches = new Guiches();
			this.dataGridView1.Columns.Add("senha", "Senha");
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.Columns.Add("senha", "Senha");
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.senhas.gerar();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.dataGridView1.Rows.Clear();

			foreach (Senha senha in this.senhas.FilaSenhas)
			{
				this.dataGridView1.Rows.Add(senha.dadosParciais());
			}

		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.guiches.adicionar(new Guiche(this.qtdGuiches));
			this.qtdGuiches++;
			label2.Text = qtdGuiches.ToString();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(textBox1.Text);
			Guiche guiche = this.guiches.buscar(id);
			if (guiche != null)
			{
				guiche.chamar(this.senhas.FilaSenhas);
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.dataGridView2.Rows.Clear();
			foreach (Guiche guiche in this.guiches.ListaGuiches)
			{
				foreach (Senha senha in guiche.Atendimentos)
				{
					this.dataGridView2.Rows.Add(senha.dadosCompletos());
				}
			}
		}
	}
}
