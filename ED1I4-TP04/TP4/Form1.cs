using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
	public partial class Form1 : Form
	{
		private Contatos contatos = new Contatos();
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			// make all text boxes empty
			txtBoxEmail.Text = "";
			txtBoxName.Text = "";
			txtBoxPhone.Text = "";
			txtBoxDay.Text = "";
			txtBoxMonth.Text = "";
			txtBoxYear.Text = "";
			checkBoxPrincipal.Checked = false;
			//disable the option from combo box
			comboBoxType.SelectedIndex = -1;
			buttonAdd.Enabled = false;

		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			dataGridViewPhones.Rows.Clear();

			if (txtBoxName.Text == "" || txtBoxEmail.Text == "" || txtBoxDay.Text == "" || txtBoxMonth.Text == "" || txtBoxYear.Text == "")
			{
				MessageBox.Show("Preencha todos os campos!");
				return;
			}
			Data birthDate = new Data(int.Parse(txtBoxDay.Text), int.Parse(txtBoxMonth.Text), int.Parse(txtBoxYear.Text));
			Contato contato = new Contato(txtBoxEmail.Text, txtBoxName.Text, birthDate);
			this.contatos.adicionar(contato);
			buttonAdd.Enabled = true;


			MessageBox.Show("Contato adicionado com sucesso!");
		}

		private void btnList_Click(object sender, EventArgs e)
		{			
			dataGridViewContacts.Rows.Clear();
			foreach (Contato contato in this.contatos.Agenda)
			{
				dataGridViewContacts.Rows.Add(contato.Email, contato.Nome, contato.DtNasc, contato.getIdade(), contato.getTelefonePrincipal());
			}
		}

		private void dataGridViewContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (txtBoxName.Text == "" || txtBoxEmail.Text == "" || txtBoxDay.Text == "" || txtBoxMonth.Text == "" || txtBoxYear.Text == "" || comboBoxType.Text == "" || txtBoxPhone.Text == "")
			{
				MessageBox.Show("Preencha todos os campos!");
				return;
			}
			
			Contato contato = new Contato(txtBoxEmail.Text);
			Contato contatoPesquisado = this.contatos.pesquisar(contato);
			if (contatoPesquisado == null)
			{
				MessageBox.Show("Contato não encontrado!");
				return;
			}
			
			contatoPesquisado.adicionarTelefone(new Telefone(comboBoxType.Text, txtBoxPhone.Text, checkBoxPrincipal.Checked));

			dataGridViewPhones.Rows.Clear();
			foreach (Telefone telefone in contatoPesquisado.Telefones)
			{
				dataGridViewPhones.Rows.Add(telefone.Tipo, telefone.Numero, telefone.Principal ? "Sim" : "Não");
			}

			MessageBox.Show("Telefone adicionado com sucesso!");
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			if (txtBoxEmail.Text == "")
			{
				MessageBox.Show("Preencha o campo de email!");
				return;
			}
			Contato contato = new Contato(txtBoxEmail.Text);
			Contato contatoPesquisado = this.contatos.pesquisar(contato);
			if (contatoPesquisado == null)
			{
				MessageBox.Show("Contato não encontrado!");
				return;
			}
			txtBoxName.Text = contatoPesquisado.Nome;
			txtBoxDay.Text = contatoPesquisado.DtNasc.Dia.ToString();
			txtBoxMonth.Text = contatoPesquisado.DtNasc.Mes.ToString();
			txtBoxYear.Text = contatoPesquisado.DtNasc.Ano.ToString();
			txtBoxEmail.Text = contatoPesquisado.Email;
			buttonAdd.Enabled = true;
			dataGridViewPhones.Rows.Clear();
			foreach (Telefone telefone in contatoPesquisado.Telefones)
			{
				dataGridViewPhones.Rows.Add(telefone.Tipo, telefone.Numero, telefone.Principal);
			}

		}

		private void buttonRemove_Click(object sender, EventArgs e)
		{
			if (txtBoxEmail.Text == "")
			{
				MessageBox.Show("Preencha o campo de email!");
				return;
			}
			Contato contato = new Contato(txtBoxEmail.Text);
			Contato contatoPesquisado = this.contatos.pesquisar(contato);
			if (contatoPesquisado == null)
			{
				MessageBox.Show("Contato não encontrado!");
				return;
			}
			this.contatos.remover(contatoPesquisado);

			txtBoxEmail.Text = "";
			txtBoxName.Text = "";
			txtBoxDay.Text = "";
			txtBoxMonth.Text = "";
			txtBoxYear.Text = "";
			dataGridViewPhones.Rows.Clear();

			dataGridViewContacts.Rows.Clear();

			foreach (Contato contatoAgenda in this.contatos.Agenda)
			{
				dataGridViewContacts.Rows.Add(contatoAgenda.Email, contatoAgenda.Nome, contatoAgenda.DtNasc, contatoAgenda.getIdade(), contatoAgenda.getTelefonePrincipal());
			}

			MessageBox.Show("Contato removido com sucesso!");
		}
	}
}
