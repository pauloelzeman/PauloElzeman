namespace PauloElzeman
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
            this.buttonIncluir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDistancia = new System.Windows.Forms.TextBox();
            this.textBoxNivelDor = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.radioButtonCapS = new System.Windows.Forms.RadioButton();
            this.radioButtonCapN = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxCusto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.AutoSize = true;
            this.buttonIncluir.Location = new System.Drawing.Point(6, 14);
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(127, 35);
            this.buttonIncluir.TabIndex = 10;
            this.buttonIncluir.Text = "Incluir";
            this.buttonIncluir.UseVisualStyleBackColor = true;
            this.buttonIncluir.Click += new System.EventHandler(this.buttonIncluir_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.AutoSize = true;
            this.buttonExcluir.Location = new System.Drawing.Point(156, 14);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(120, 35);
            this.buttonExcluir.TabIndex = 11;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonIncluir);
            this.groupBox1.Controls.Add(this.buttonExcluir);
            this.groupBox1.Location = new System.Drawing.Point(486, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 60);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCusto);
            this.groupBox2.Controls.Add(this.textBoxDistancia);
            this.groupBox2.Controls.Add(this.textBoxNivelDor);
            this.groupBox2.Controls.Add(this.dateTimePicker);
            this.groupBox2.Controls.Add(this.buttonSalvar);
            this.groupBox2.Controls.Add(this.buttonCancelar);
            this.groupBox2.Controls.Add(this.radioButtonCapS);
            this.groupBox2.Controls.Add(this.radioButtonCapN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(486, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 360);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // textBoxDistancia
            // 
            this.textBoxDistancia.Location = new System.Drawing.Point(66, 117);
            this.textBoxDistancia.MaxLength = 9;
            this.textBoxDistancia.Name = "textBoxDistancia";
            this.textBoxDistancia.Size = new System.Drawing.Size(291, 20);
            this.textBoxDistancia.TabIndex = 3;
            this.textBoxDistancia.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxNivelDor
            // 
            this.textBoxNivelDor.Location = new System.Drawing.Point(66, 192);
            this.textBoxNivelDor.MaxLength = 9;
            this.textBoxNivelDor.Name = "textBoxNivelDor";
            this.textBoxNivelDor.Size = new System.Drawing.Size(291, 20);
            this.textBoxNivelDor.TabIndex = 6;
            this.textBoxNivelDor.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxNivelDor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(66, 40);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(291, 20);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Value = new System.DateTime(2020, 11, 9, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.Location = new System.Drawing.Point(37, 276);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(127, 35);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.Location = new System.Drawing.Point(202, 276);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(127, 35);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // radioButtonCapS
            // 
            this.radioButtonCapS.AutoSize = true;
            this.radioButtonCapS.Location = new System.Drawing.Point(195, 157);
            this.radioButtonCapS.Name = "radioButtonCapS";
            this.radioButtonCapS.Size = new System.Drawing.Size(44, 17);
            this.radioButtonCapS.TabIndex = 5;
            this.radioButtonCapS.TabStop = true;
            this.radioButtonCapS.Text = "SIM";
            this.radioButtonCapS.UseVisualStyleBackColor = true;
            this.radioButtonCapS.Click += new System.EventHandler(this.radioButtonClick);
            // 
            // radioButtonCapN
            // 
            this.radioButtonCapN.AutoSize = true;
            this.radioButtonCapN.Location = new System.Drawing.Point(78, 157);
            this.radioButtonCapN.Name = "radioButtonCapN";
            this.radioButtonCapN.Size = new System.Drawing.Size(48, 17);
            this.radioButtonCapN.TabIndex = 4;
            this.radioButtonCapN.TabStop = true;
            this.radioButtonCapN.Text = "NÂO";
            this.radioButtonCapN.UseVisualStyleBackColor = true;
            this.radioButtonCapN.Click += new System.EventHandler(this.radioButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nivel dor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Captura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distância";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Custo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(468, 426);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // textBoxCusto
            // 
            this.textBoxCusto.Location = new System.Drawing.Point(66, 80);
            this.textBoxCusto.MaxLength = 9;
            this.textBoxCusto.Name = "textBoxCusto";
            this.textBoxCusto.Size = new System.Drawing.Size(291, 20);
            this.textBoxCusto.TabIndex = 2;
            this.textBoxCusto.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCusto_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACME FLIGHT MANAGER";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIncluir;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.RadioButton radioButtonCapS;
        private System.Windows.Forms.RadioButton radioButtonCapN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxNivelDor;
        private System.Windows.Forms.TextBox textBoxDistancia;
        private System.Windows.Forms.TextBox textBoxCusto;
    }
}

