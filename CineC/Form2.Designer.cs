namespace CineC
{
    partial class Form2
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
            this.columnHeaderGen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFilmesPesq = new System.Windows.Forms.ListView();
            this.dateTimePickerData2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.comboBoxGen = new System.Windows.Forms.ComboBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelGeneroPesq = new System.Windows.Forms.Label();
            this.labelNomePesq = new System.Windows.Forms.Label();
            this.dateTimePickerData1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxNome = new System.Windows.Forms.CheckBox();
            this.checkBoxGen = new System.Windows.Forms.CheckBox();
            this.checkBoxLocal = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeaderGen
            // 
            this.columnHeaderGen.Text = "Gênero";
            this.columnHeaderGen.Width = 143;
            // 
            // columnHeaderLocal
            // 
            this.columnHeaderLocal.Text = "Local que foi Assistido";
            this.columnHeaderLocal.Width = 252;
            // 
            // columnHeaderDataI
            // 
            this.columnHeaderDataI.Text = "Data Inicial";
            this.columnHeaderDataI.Width = 114;
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 232;
            // 
            // listViewFilmesPesq
            // 
            this.listViewFilmesPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFilmesPesq.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome,
            this.columnHeaderGen,
            this.columnHeaderLocal,
            this.columnHeaderDataI});
            this.listViewFilmesPesq.FullRowSelect = true;
            this.listViewFilmesPesq.GridLines = true;
            this.listViewFilmesPesq.Location = new System.Drawing.Point(15, 103);
            this.listViewFilmesPesq.Name = "listViewFilmesPesq";
            this.listViewFilmesPesq.Size = new System.Drawing.Size(747, 322);
            this.listViewFilmesPesq.TabIndex = 21;
            this.listViewFilmesPesq.UseCompatibleStateImageBehavior = false;
            this.listViewFilmesPesq.View = System.Windows.Forms.View.Details;
            // 
            // dateTimePickerData2
            // 
            this.dateTimePickerData2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerData2.Location = new System.Drawing.Point(527, 77);
            this.dateTimePickerData2.Name = "dateTimePickerData2";
            this.dateTimePickerData2.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerData2.TabIndex = 20;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocal.Location = new System.Drawing.Point(15, 77);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(237, 20);
            this.textBoxLocal.TabIndex = 19;
            // 
            // comboBoxGen
            // 
            this.comboBoxGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGen.FormattingEnabled = true;
            this.comboBoxGen.Items.AddRange(new object[] {
            "Selecione...",
            "Ação",
            "Aventura",
            "Comédia",
            "Terror",
            "Suspense",
            "Documentário",
            "Infantil",
            "Romance",
            "Ficção Científica"});
            this.comboBoxGen.Location = new System.Drawing.Point(527, 26);
            this.comboBoxGen.Name = "comboBoxGen";
            this.comboBoxGen.Size = new System.Drawing.Size(235, 21);
            this.comboBoxGen.TabIndex = 18;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Location = new System.Drawing.Point(15, 26);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(492, 20);
            this.textBoxNome.TabIndex = 17;
            // 
            // labelData
            // 
            this.labelData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(524, 61);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(55, 13);
            this.labelData.TabIndex = 16;
            this.labelData.Text = "Data Final";
            // 
            // labelLocal
            // 
            this.labelLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(12, 61);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(36, 13);
            this.labelLocal.TabIndex = 15;
            this.labelLocal.Text = "Local ";
            // 
            // labelGeneroPesq
            // 
            this.labelGeneroPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGeneroPesq.AutoSize = true;
            this.labelGeneroPesq.Location = new System.Drawing.Point(524, 10);
            this.labelGeneroPesq.Name = "labelGeneroPesq";
            this.labelGeneroPesq.Size = new System.Drawing.Size(42, 13);
            this.labelGeneroPesq.TabIndex = 14;
            this.labelGeneroPesq.Text = "Gênero";
            // 
            // labelNomePesq
            // 
            this.labelNomePesq.AutoSize = true;
            this.labelNomePesq.Location = new System.Drawing.Point(12, 10);
            this.labelNomePesq.Name = "labelNomePesq";
            this.labelNomePesq.Size = new System.Drawing.Size(35, 13);
            this.labelNomePesq.TabIndex = 13;
            this.labelNomePesq.Text = "Nome";
            // 
            // dateTimePickerData1
            // 
            this.dateTimePickerData1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerData1.Location = new System.Drawing.Point(272, 77);
            this.dateTimePickerData1.Name = "dateTimePickerData1";
            this.dateTimePickerData1.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerData1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(269, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Data Inicial";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFiltrar.Location = new System.Drawing.Point(525, 431);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 32;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Location = new System.Drawing.Point(687, 431);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 33;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpar.Location = new System.Drawing.Point(606, 431);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 35;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // checkBoxNome
            // 
            this.checkBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxNome.AutoSize = true;
            this.checkBoxNome.Location = new System.Drawing.Point(15, 435);
            this.checkBoxNome.Name = "checkBoxNome";
            this.checkBoxNome.Size = new System.Drawing.Size(54, 17);
            this.checkBoxNome.TabIndex = 26;
            this.checkBoxNome.Text = "Nome";
            this.checkBoxNome.UseVisualStyleBackColor = true;
            this.checkBoxNome.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxGen
            // 
            this.checkBoxGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxGen.AutoSize = true;
            this.checkBoxGen.Location = new System.Drawing.Point(75, 435);
            this.checkBoxGen.Name = "checkBoxGen";
            this.checkBoxGen.Size = new System.Drawing.Size(61, 17);
            this.checkBoxGen.TabIndex = 27;
            this.checkBoxGen.Text = "Gênero";
            this.checkBoxGen.UseVisualStyleBackColor = true;
            this.checkBoxGen.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxLocal
            // 
            this.checkBoxLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxLocal.AutoSize = true;
            this.checkBoxLocal.Location = new System.Drawing.Point(142, 435);
            this.checkBoxLocal.Name = "checkBoxLocal";
            this.checkBoxLocal.Size = new System.Drawing.Size(52, 17);
            this.checkBoxLocal.TabIndex = 28;
            this.checkBoxLocal.Text = "Local";
            this.checkBoxLocal.UseVisualStyleBackColor = true;
            this.checkBoxLocal.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxData
            // 
            this.checkBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Location = new System.Drawing.Point(200, 435);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(49, 17);
            this.checkBoxData.TabIndex = 29;
            this.checkBoxData.Text = "Data";
            this.checkBoxData.UseVisualStyleBackColor = true;
            this.checkBoxData.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 466);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.dateTimePickerData1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxData);
            this.Controls.Add(this.checkBoxLocal);
            this.Controls.Add(this.checkBoxGen);
            this.Controls.Add(this.checkBoxNome);
            this.Controls.Add(this.listViewFilmesPesq);
            this.Controls.Add(this.dateTimePickerData2);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.comboBoxGen);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.labelGeneroPesq);
            this.Controls.Add(this.labelNomePesq);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário para pesquisa de filmes";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeaderGen;
        private System.Windows.Forms.ColumnHeader columnHeaderLocal;
        private System.Windows.Forms.ColumnHeader columnHeaderDataI;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ListView listViewFilmesPesq;
        private System.Windows.Forms.DateTimePicker dateTimePickerData2;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.ComboBox comboBoxGen;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelGeneroPesq;
        private System.Windows.Forms.Label labelNomePesq;
        private System.Windows.Forms.DateTimePicker dateTimePickerData1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.CheckBox checkBoxLocal;
        private System.Windows.Forms.CheckBox checkBoxGen;
        private System.Windows.Forms.CheckBox checkBoxNome;
    }
}