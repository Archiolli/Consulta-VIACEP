namespace tpasenjo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBPessoasDataSet = new tpasenjo.DBPessoasDataSet();
            this.pessoasTableAdapter = new tpasenjo.DBPessoasDataSetTableAdapters.PessoasTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.cepMaskedTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ufTxtBox = new System.Windows.Forms.TextBox();
            this.localidadeTxtBox = new System.Windows.Forms.TextBox();
            this.bairroTxtBox = new System.Windows.Forms.TextBox();
            this.logradouroTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nomeTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.complementoTxtBox = new System.Windows.Forms.TextBox();
            this.numeroTxtBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.telefoneTxtBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPessoasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pessoasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "rua";
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataMember = "Pessoas";
            this.pessoasBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dBPessoasDataSet;
            this.bindingSource1.Position = 0;
            // 
            // dBPessoasDataSet
            // 
            this.dBPessoasDataSet.DataSetName = "DBPessoasDataSet";
            this.dBPessoasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar CEP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cepMaskedTxtBox
            // 
            this.cepMaskedTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "cep", true));
            this.cepMaskedTxtBox.Location = new System.Drawing.Point(110, 343);
            this.cepMaskedTxtBox.Mask = "99999\\-999";
            this.cepMaskedTxtBox.Name = "cepMaskedTxtBox";
            this.cepMaskedTxtBox.Size = new System.Drawing.Size(100, 20);
            this.cepMaskedTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CEP:";
            // 
            // ufTxtBox
            // 
            this.ufTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "estado", true));
            this.ufTxtBox.Location = new System.Drawing.Point(110, 380);
            this.ufTxtBox.Name = "ufTxtBox";
            this.ufTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ufTxtBox.TabIndex = 4;
            // 
            // localidadeTxtBox
            // 
            this.localidadeTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "cidade", true));
            this.localidadeTxtBox.Location = new System.Drawing.Point(110, 418);
            this.localidadeTxtBox.Name = "localidadeTxtBox";
            this.localidadeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.localidadeTxtBox.TabIndex = 5;
            // 
            // bairroTxtBox
            // 
            this.bairroTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "bairro", true));
            this.bairroTxtBox.Location = new System.Drawing.Point(291, 380);
            this.bairroTxtBox.Name = "bairroTxtBox";
            this.bairroTxtBox.Size = new System.Drawing.Size(100, 20);
            this.bairroTxtBox.TabIndex = 6;
            // 
            // logradouroTxtBox
            // 
            this.logradouroTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "rua", true));
            this.logradouroTxtBox.Location = new System.Drawing.Point(291, 418);
            this.logradouroTxtBox.Name = "logradouroTxtBox";
            this.logradouroTxtBox.Size = new System.Drawing.Size(100, 20);
            this.logradouroTxtBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "UF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Localidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Logradouro";
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "nome", true));
            this.nomeTxtBox.Location = new System.Drawing.Point(108, 237);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTxtBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Número:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Complemento:";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "email", true));
            this.emailTxtBox.Location = new System.Drawing.Point(108, 304);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(100, 20);
            this.emailTxtBox.TabIndex = 19;
            // 
            // complementoTxtBox
            // 
            this.complementoTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "complemento", true));
            this.complementoTxtBox.Location = new System.Drawing.Point(475, 418);
            this.complementoTxtBox.Name = "complementoTxtBox";
            this.complementoTxtBox.Size = new System.Drawing.Size(100, 20);
            this.complementoTxtBox.TabIndex = 20;
            // 
            // numeroTxtBox
            // 
            this.numeroTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "numero", true));
            this.numeroTxtBox.Location = new System.Drawing.Point(475, 383);
            this.numeroTxtBox.Name = "numeroTxtBox";
            this.numeroTxtBox.Size = new System.Drawing.Size(100, 20);
            this.numeroTxtBox.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Proximo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(262, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Adicionar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Anterior";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LawnGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(358, 178);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 32);
            this.button6.TabIndex = 26;
            this.button6.Text = "Salvar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // telefoneTxtBox
            // 
            this.telefoneTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoasBindingSource, "telefone", true));
            this.telefoneTxtBox.Location = new System.Drawing.Point(108, 271);
            this.telefoneTxtBox.Mask = "(99) 00000-0000";
            this.telefoneTxtBox.Name = "telefoneTxtBox";
            this.telefoneTxtBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTxtBox.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.telefoneTxtBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numeroTxtBox);
            this.Controls.Add(this.complementoTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nomeTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logradouroTxtBox);
            this.Controls.Add(this.bairroTxtBox);
            this.Controls.Add(this.localidadeTxtBox);
            this.Controls.Add(this.ufTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cepMaskedTxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPessoasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DBPessoasDataSet dBPessoasDataSet;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private DBPessoasDataSetTableAdapters.PessoasTableAdapter pessoasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox cepMaskedTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ufTxtBox;
        private System.Windows.Forms.TextBox localidadeTxtBox;
        private System.Windows.Forms.TextBox bairroTxtBox;
        private System.Windows.Forms.TextBox logradouroTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nomeTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox complementoTxtBox;
        private System.Windows.Forms.TextBox numeroTxtBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MaskedTextBox telefoneTxtBox;
    }
}

