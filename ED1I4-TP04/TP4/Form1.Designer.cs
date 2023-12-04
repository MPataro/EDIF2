namespace TP4
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonNew = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBoxEmail = new System.Windows.Forms.TextBox();
			this.txtBoxName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBoxDay = new System.Windows.Forms.TextBox();
			this.txtBoxMonth = new System.Windows.Forms.TextBox();
			this.txtBoxYear = new System.Windows.Forms.TextBox();
			this.dataGridViewPhones = new System.Windows.Forms.DataGridView();
			this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPrincipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
			this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBoxPhone = new System.Windows.Forms.TextBox();
			this.checkBoxPrincipal = new System.Windows.Forms.CheckBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonNew
			// 
			this.buttonNew.Location = new System.Drawing.Point(99, 24);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(75, 23);
			this.buttonNew.TabIndex = 0;
			this.buttonNew.Text = "Novo";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(252, 24);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Text = "Salvar";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(404, 24);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 2;
			this.buttonSearch.Text = "Pesquisar";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// buttonRemove
			// 
			this.buttonRemove.Location = new System.Drawing.Point(547, 24);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(75, 23);
			this.buttonRemove.TabIndex = 3;
			this.buttonRemove.Text = "Remover";
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "E-mail";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nome";
			// 
			// txtBoxEmail
			// 
			this.txtBoxEmail.Location = new System.Drawing.Point(74, 74);
			this.txtBoxEmail.Name = "txtBoxEmail";
			this.txtBoxEmail.Size = new System.Drawing.Size(100, 20);
			this.txtBoxEmail.TabIndex = 6;
			// 
			// txtBoxName
			// 
			this.txtBoxName.Location = new System.Drawing.Point(74, 134);
			this.txtBoxName.Name = "txtBoxName";
			this.txtBoxName.Size = new System.Drawing.Size(100, 20);
			this.txtBoxName.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label3.Location = new System.Drawing.Point(33, 176);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "Data de nascimento";
			// 
			// txtBoxDay
			// 
			this.txtBoxDay.Location = new System.Drawing.Point(43, 197);
			this.txtBoxDay.MaxLength = 2;
			this.txtBoxDay.Name = "txtBoxDay";
			this.txtBoxDay.Size = new System.Drawing.Size(22, 20);
			this.txtBoxDay.TabIndex = 9;
			// 
			// txtBoxMonth
			// 
			this.txtBoxMonth.Location = new System.Drawing.Point(71, 197);
			this.txtBoxMonth.MaxLength = 2;
			this.txtBoxMonth.Name = "txtBoxMonth";
			this.txtBoxMonth.Size = new System.Drawing.Size(22, 20);
			this.txtBoxMonth.TabIndex = 10;
			// 
			// txtBoxYear
			// 
			this.txtBoxYear.Location = new System.Drawing.Point(99, 197);
			this.txtBoxYear.MaxLength = 4;
			this.txtBoxYear.Name = "txtBoxYear";
			this.txtBoxYear.Size = new System.Drawing.Size(41, 20);
			this.txtBoxYear.TabIndex = 11;
			// 
			// dataGridViewPhones
			// 
			this.dataGridViewPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPhones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnType,
            this.ColumnNumber,
            this.ColumnPrincipal});
			this.dataGridViewPhones.Location = new System.Drawing.Point(226, 74);
			this.dataGridViewPhones.Name = "dataGridViewPhones";
			this.dataGridViewPhones.Size = new System.Drawing.Size(349, 150);
			this.dataGridViewPhones.TabIndex = 12;
			// 
			// ColumnType
			// 
			this.ColumnType.HeaderText = "Tipo";
			this.ColumnType.Name = "ColumnType";
			// 
			// ColumnNumber
			// 
			this.ColumnNumber.HeaderText = "Número";
			this.ColumnNumber.Name = "ColumnNumber";
			// 
			// ColumnPrincipal
			// 
			this.ColumnPrincipal.HeaderText = "Principal";
			this.ColumnPrincipal.Name = "ColumnPrincipal";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(226, 247);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(28, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Tipo";
			// 
			// comboBoxType
			// 
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Items.AddRange(new object[] {
            "Móvel",
            "Residencial",
            "Comercial"});
			this.comboBoxType.Location = new System.Drawing.Point(260, 244);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(121, 21);
			this.comboBoxType.TabIndex = 14;
			// 
			// dataGridViewContacts
			// 
			this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnEmail,
            this.columnName,
            this.ColumnBirth,
            this.ColumnAge,
            this.ColumnPhone});
			this.dataGridViewContacts.Location = new System.Drawing.Point(99, 343);
			this.dataGridViewContacts.Name = "dataGridViewContacts";
			this.dataGridViewContacts.Size = new System.Drawing.Size(550, 150);
			this.dataGridViewContacts.TabIndex = 15;
			this.dataGridViewContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContacts_CellContentClick);
			// 
			// columnEmail
			// 
			this.columnEmail.HeaderText = "E-mail";
			this.columnEmail.Name = "columnEmail";
			// 
			// columnName
			// 
			this.columnName.HeaderText = "Nome";
			this.columnName.Name = "columnName";
			// 
			// ColumnBirth
			// 
			this.ColumnBirth.HeaderText = "Data Nasc";
			this.ColumnBirth.Name = "ColumnBirth";
			// 
			// ColumnAge
			// 
			this.ColumnAge.HeaderText = "Idade";
			this.ColumnAge.Name = "ColumnAge";
			// 
			// ColumnPhone
			// 
			this.ColumnPhone.HeaderText = "Telefone";
			this.ColumnPhone.Name = "ColumnPhone";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(400, 247);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Número";
			// 
			// txtBoxPhone
			// 
			this.txtBoxPhone.Location = new System.Drawing.Point(450, 244);
			this.txtBoxPhone.Name = "txtBoxPhone";
			this.txtBoxPhone.Size = new System.Drawing.Size(100, 20);
			this.txtBoxPhone.TabIndex = 17;
			// 
			// checkBoxPrincipal
			// 
			this.checkBoxPrincipal.AutoSize = true;
			this.checkBoxPrincipal.Location = new System.Drawing.Point(562, 246);
			this.checkBoxPrincipal.Name = "checkBoxPrincipal";
			this.checkBoxPrincipal.Size = new System.Drawing.Size(66, 17);
			this.checkBoxPrincipal.TabIndex = 18;
			this.checkBoxPrincipal.Text = "Principal";
			this.checkBoxPrincipal.UseVisualStyleBackColor = true;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Enabled = false;
			this.buttonAdd.Location = new System.Drawing.Point(634, 242);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 19;
			this.buttonAdd.Text = "Adicionar";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// btnList
			// 
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.btnList.Location = new System.Drawing.Point(279, 499);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(200, 32);
			this.btnList.TabIndex = 20;
			this.btnList.Text = "Listar contatos";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 609);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.checkBoxPrincipal);
			this.Controls.Add(this.txtBoxPhone);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dataGridViewContacts);
			this.Controls.Add(this.comboBoxType);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dataGridViewPhones);
			this.Controls.Add(this.txtBoxYear);
			this.Controls.Add(this.txtBoxMonth);
			this.Controls.Add(this.txtBoxDay);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtBoxName);
			this.Controls.Add(this.txtBoxEmail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonRemove);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonNew);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBoxEmail;
		private System.Windows.Forms.TextBox txtBoxName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBoxDay;
		private System.Windows.Forms.TextBox txtBoxMonth;
		private System.Windows.Forms.TextBox txtBoxYear;
		private System.Windows.Forms.DataGridView dataGridViewPhones;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrincipal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBoxType;
		private System.Windows.Forms.DataGridView dataGridViewContacts;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBirth;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtBoxPhone;
		private System.Windows.Forms.CheckBox checkBoxPrincipal;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button btnList;
	}
}

