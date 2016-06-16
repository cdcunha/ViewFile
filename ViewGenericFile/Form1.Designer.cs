namespace InterfaceColWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelXMLConfigFile = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxGotoLine = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.comboBoxEncoding = new System.Windows.Forms.ComboBox();
            this.buttonConfigFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelQtdeRegistros = new System.Windows.Forms.Label();
            this.buttonGotoLine = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxTipoArquivo = new System.Windows.Forms.GroupBox();
            this.panelDelimited = new System.Windows.Forms.Panel();
            this.panelFixedWidth = new System.Windows.Forms.Panel();
            this.checkBoxPrimeiraLinha = new System.Windows.Forms.CheckBox();
            this.comboBoxTextDelimiter = new System.Windows.Forms.ComboBox();
            this.comboBoxColumnDelimiter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOtherDelimiter = new System.Windows.Forms.TextBox();
            this.radioButtonFixedWidth = new System.Windows.Forms.RadioButton();
            this.radioButtonDelimitado = new System.Windows.Forms.RadioButton();
            this.buttonOpenSearchPanel = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSearchColumn = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxSearchPartial = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBoxTipoArquivo.SuspendLayout();
            this.panelDelimited.SuspendLayout();
            this.panelFixedWidth.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "XML";
            this.openFileDialog1.Filter = "Arquivo XML (.xml)|*.xml";
            // 
            // labelXMLConfigFile
            // 
            this.labelXMLConfigFile.AutoSize = true;
            this.labelXMLConfigFile.Location = new System.Drawing.Point(614, 11);
            this.labelXMLConfigFile.Name = "labelXMLConfigFile";
            this.labelXMLConfigFile.Size = new System.Drawing.Size(145, 13);
            this.labelXMLConfigFile.TabIndex = 1;
            this.labelXMLConfigFile.Text = "Nenhum arquivo selecionado";
            // 
            // textBoxGotoLine
            // 
            this.textBoxGotoLine.Location = new System.Drawing.Point(9, 20);
            this.textBoxGotoLine.Name = "textBoxGotoLine";
            this.textBoxGotoLine.Size = new System.Drawing.Size(61, 20);
            this.textBoxGotoLine.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxGotoLine, "Informe a linha desejada");
            this.textBoxGotoLine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxGotoLine_KeyUp);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(318, 6);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(110, 90);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Abrir arquivo texto";
            this.toolTip1.SetToolTip(this.buttonOpenFile, "Abrir o arquivo texto");
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // comboBoxEncoding
            // 
            this.comboBoxEncoding.FormattingEnabled = true;
            this.comboBoxEncoding.Items.AddRange(new object[] {
            "ASCII",
            "BigEndianUnicode",
            "Padrão",
            "Unicode",
            "UTF32",
            "UTF7",
            "UTF8"});
            this.comboBoxEncoding.Location = new System.Drawing.Point(617, 47);
            this.comboBoxEncoding.Name = "comboBoxEncoding";
            this.comboBoxEncoding.Size = new System.Drawing.Size(168, 21);
            this.comboBoxEncoding.TabIndex = 4;
            this.toolTip1.SetToolTip(this.comboBoxEncoding, "Codificação do arquivo texto.\r\nAltere somente se houver caracteres estranhos. \r\nE" +
        "xemplo: \"2�via\"");
            // 
            // buttonConfigFile
            // 
            this.buttonConfigFile.Location = new System.Drawing.Point(43, 8);
            this.buttonConfigFile.Name = "buttonConfigFile";
            this.buttonConfigFile.Size = new System.Drawing.Size(110, 62);
            this.buttonConfigFile.TabIndex = 1;
            this.buttonConfigFile.Text = "Abrir arquivo modelo (XML)";
            this.toolTip1.SetToolTip(this.buttonConfigFile, resources.GetString("buttonConfigFile.ToolTip"));
            this.buttonConfigFile.UseVisualStyleBackColor = true;
            this.buttonConfigFile.Click += new System.EventHandler(this.buttonConfigFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 228);
            this.dataGridView1.TabIndex = 9;
            // 
            // labelQtdeRegistros
            // 
            this.labelQtdeRegistros.AutoSize = true;
            this.labelQtdeRegistros.Location = new System.Drawing.Point(549, 77);
            this.labelQtdeRegistros.Name = "labelQtdeRegistros";
            this.labelQtdeRegistros.Size = new System.Drawing.Size(84, 13);
            this.labelQtdeRegistros.TabIndex = 6;
            this.labelQtdeRegistros.Text = "Nenhum registro";
            this.labelQtdeRegistros.TextChanged += new System.EventHandler(this.labelQtdeRegistros_TextChanged);
            // 
            // buttonGotoLine
            // 
            this.buttonGotoLine.Location = new System.Drawing.Point(76, 18);
            this.buttonGotoLine.Name = "buttonGotoLine";
            this.buttonGotoLine.Size = new System.Drawing.Size(75, 23);
            this.buttonGotoLine.TabIndex = 8;
            this.buttonGotoLine.Text = "Ir para linha";
            this.buttonGotoLine.UseVisualStyleBackColor = true;
            this.buttonGotoLine.Click += new System.EventHandler(this.buttonGotoLine_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(433, 6);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(110, 90);
            this.buttonExecute.TabIndex = 5;
            this.buttonExecute.Text = "Recarregar";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(614, 30);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(145, 13);
            this.labelFileName.TabIndex = 3;
            this.labelFileName.Text = "Nenhum arquivo selecionado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Arquivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Codificação:";
            // 
            // groupBoxTipoArquivo
            // 
            this.groupBoxTipoArquivo.Controls.Add(this.panelDelimited);
            this.groupBoxTipoArquivo.Controls.Add(this.radioButtonFixedWidth);
            this.groupBoxTipoArquivo.Controls.Add(this.radioButtonDelimitado);
            this.groupBoxTipoArquivo.Location = new System.Drawing.Point(7, 3);
            this.groupBoxTipoArquivo.Name = "groupBoxTipoArquivo";
            this.groupBoxTipoArquivo.Size = new System.Drawing.Size(294, 90);
            this.groupBoxTipoArquivo.TabIndex = 13;
            this.groupBoxTipoArquivo.TabStop = false;
            this.groupBoxTipoArquivo.Text = "Tipo de arquivo";
            // 
            // panelDelimited
            // 
            this.panelDelimited.Controls.Add(this.panelFixedWidth);
            this.panelDelimited.Controls.Add(this.checkBoxPrimeiraLinha);
            this.panelDelimited.Controls.Add(this.comboBoxTextDelimiter);
            this.panelDelimited.Controls.Add(this.comboBoxColumnDelimiter);
            this.panelDelimited.Controls.Add(this.label5);
            this.panelDelimited.Controls.Add(this.label4);
            this.panelDelimited.Controls.Add(this.textBoxOtherDelimiter);
            this.panelDelimited.Location = new System.Drawing.Point(92, 11);
            this.panelDelimited.Name = "panelDelimited";
            this.panelDelimited.Size = new System.Drawing.Size(196, 76);
            this.panelDelimited.TabIndex = 2;
            // 
            // panelFixedWidth
            // 
            this.panelFixedWidth.Controls.Add(this.buttonConfigFile);
            this.panelFixedWidth.Location = new System.Drawing.Point(-2, 1);
            this.panelFixedWidth.Name = "panelFixedWidth";
            this.panelFixedWidth.Size = new System.Drawing.Size(198, 76);
            this.panelFixedWidth.TabIndex = 16;
            // 
            // checkBoxPrimeiraLinha
            // 
            this.checkBoxPrimeiraLinha.AutoSize = true;
            this.checkBoxPrimeiraLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPrimeiraLinha.Location = new System.Drawing.Point(9, 5);
            this.checkBoxPrimeiraLinha.Name = "checkBoxPrimeiraLinha";
            this.checkBoxPrimeiraLinha.Size = new System.Drawing.Size(180, 17);
            this.checkBoxPrimeiraLinha.TabIndex = 20;
            this.checkBoxPrimeiraLinha.Text = "Primeira Linha é cabeçalho";
            this.checkBoxPrimeiraLinha.UseVisualStyleBackColor = true;
            // 
            // comboBoxTextDelimiter
            // 
            this.comboBoxTextDelimiter.FormattingEnabled = true;
            this.comboBoxTextDelimiter.Items.AddRange(new object[] {
            "",
            "\"",
            "\'"});
            this.comboBoxTextDelimiter.Location = new System.Drawing.Point(72, 52);
            this.comboBoxTextDelimiter.Name = "comboBoxTextDelimiter";
            this.comboBoxTextDelimiter.Size = new System.Drawing.Size(93, 21);
            this.comboBoxTextDelimiter.TabIndex = 17;
            // 
            // comboBoxColumnDelimiter
            // 
            this.comboBoxColumnDelimiter.FormattingEnabled = true;
            this.comboBoxColumnDelimiter.Items.AddRange(new object[] {
            "Tabulação",
            "Vírgula",
            "Ponto e Vírgula",
            "Espaço",
            "Outro"});
            this.comboBoxColumnDelimiter.Location = new System.Drawing.Point(72, 26);
            this.comboBoxColumnDelimiter.Name = "comboBoxColumnDelimiter";
            this.comboBoxColumnDelimiter.Size = new System.Drawing.Size(93, 21);
            this.comboBoxColumnDelimiter.TabIndex = 16;
            this.comboBoxColumnDelimiter.SelectedValueChanged += new System.EventHandler(this.comboBoxColumnDelimiter_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Qualificador \r\n  de Texto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Delimitador:";
            // 
            // textBoxOtherDelimiter
            // 
            this.textBoxOtherDelimiter.Location = new System.Drawing.Point(171, 27);
            this.textBoxOtherDelimiter.MaxLength = 1;
            this.textBoxOtherDelimiter.Name = "textBoxOtherDelimiter";
            this.textBoxOtherDelimiter.Size = new System.Drawing.Size(20, 20);
            this.textBoxOtherDelimiter.TabIndex = 19;
            this.textBoxOtherDelimiter.Visible = false;
            // 
            // radioButtonFixedWidth
            // 
            this.radioButtonFixedWidth.AutoSize = true;
            this.radioButtonFixedWidth.Location = new System.Drawing.Point(9, 58);
            this.radioButtonFixedWidth.Name = "radioButtonFixedWidth";
            this.radioButtonFixedWidth.Size = new System.Drawing.Size(83, 17);
            this.radioButtonFixedWidth.TabIndex = 1;
            this.radioButtonFixedWidth.TabStop = true;
            this.radioButtonFixedWidth.Text = "Largura Fixa";
            this.radioButtonFixedWidth.UseVisualStyleBackColor = true;
            this.radioButtonFixedWidth.CheckedChanged += new System.EventHandler(this.radioButtonDelimited_CheckedChanged);
            // 
            // radioButtonDelimitado
            // 
            this.radioButtonDelimitado.AutoSize = true;
            this.radioButtonDelimitado.Checked = true;
            this.radioButtonDelimitado.Location = new System.Drawing.Point(9, 16);
            this.radioButtonDelimitado.Name = "radioButtonDelimitado";
            this.radioButtonDelimitado.Size = new System.Drawing.Size(74, 17);
            this.radioButtonDelimitado.TabIndex = 0;
            this.radioButtonDelimitado.TabStop = true;
            this.radioButtonDelimitado.Text = "Delimitado";
            this.radioButtonDelimitado.UseVisualStyleBackColor = true;
            this.radioButtonDelimitado.CheckedChanged += new System.EventHandler(this.radioButtonDelimited_CheckedChanged);
            // 
            // buttonOpenSearchPanel
            // 
            this.buttonOpenSearchPanel.Location = new System.Drawing.Point(650, 73);
            this.buttonOpenSearchPanel.Name = "buttonOpenSearchPanel";
            this.buttonOpenSearchPanel.Size = new System.Drawing.Size(135, 23);
            this.buttonOpenSearchPanel.TabIndex = 14;
            this.buttonOpenSearchPanel.Text = "Fechar Pesquisa";
            this.buttonOpenSearchPanel.UseVisualStyleBackColor = true;
            this.buttonOpenSearchPanel.Click += new System.EventHandler(this.buttonOpenSearchPanel_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.panel2);
            this.panelSearch.Controls.Add(this.checkBoxSearchPartial);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.label7);
            this.panelSearch.Controls.Add(this.label6);
            this.panelSearch.Controls.Add(this.comboBoxSearchColumn);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSearch.Location = new System.Drawing.Point(0, 340);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1017, 83);
            this.panelSearch.TabIndex = 15;
            this.panelSearch.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelXMLConfigFile);
            this.panel1.Controls.Add(this.buttonOpenFile);
            this.panel1.Controls.Add(this.labelQtdeRegistros);
            this.panel1.Controls.Add(this.buttonOpenSearchPanel);
            this.panel1.Controls.Add(this.buttonExecute);
            this.panel1.Controls.Add(this.groupBoxTipoArquivo);
            this.panel1.Controls.Add(this.labelFileName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxEncoding);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 102);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Coluna:";
            // 
            // comboBoxSearchColumn
            // 
            this.comboBoxSearchColumn.FormattingEnabled = true;
            this.comboBoxSearchColumn.Location = new System.Drawing.Point(55, 5);
            this.comboBoxSearchColumn.Name = "comboBoxSearchColumn";
            this.comboBoxSearchColumn.Size = new System.Drawing.Size(220, 21);
            this.comboBoxSearchColumn.TabIndex = 13;
            this.toolTip1.SetToolTip(this.comboBoxSearchColumn, "Escolha a coluna desejada");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Texto:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(55, 30);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(220, 20);
            this.textBoxSearch.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textBoxSearch, "Informe a linha desejada");
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(140, 56);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(135, 23);
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.Text = "Pesquisar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBoxSearchPartial
            // 
            this.checkBoxSearchPartial.AutoSize = true;
            this.checkBoxSearchPartial.Location = new System.Drawing.Point(19, 59);
            this.checkBoxSearchPartial.Name = "checkBoxSearchPartial";
            this.checkBoxSearchPartial.Size = new System.Drawing.Size(91, 17);
            this.checkBoxSearchPartial.TabIndex = 18;
            this.checkBoxSearchPartial.Text = "Busca Parcial";
            this.toolTip1.SetToolTip(this.checkBoxSearchPartial, "Clique aqui para busca parcial\r\n\r\nExemplo do texto para busca parcial:\r\n\"NOTE%\"\r\n" +
        "\r\nIrá encontrar qualquer texto que inicie com \"NOTE\"");
            this.checkBoxSearchPartial.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxGotoLine);
            this.panel2.Controls.Add(this.buttonGotoLine);
            this.panel2.Location = new System.Drawing.Point(288, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 68);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 102);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(1017, 238);
            this.panel3.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 423);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSearch);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador Genérico de Arquivo Texto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBoxTipoArquivo.ResumeLayout(false);
            this.groupBoxTipoArquivo.PerformLayout();
            this.panelDelimited.ResumeLayout(false);
            this.panelDelimited.PerformLayout();
            this.panelFixedWidth.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelXMLConfigFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelQtdeRegistros;
        private System.Windows.Forms.Button buttonGotoLine;
        private System.Windows.Forms.TextBox textBoxGotoLine;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.ComboBox comboBoxEncoding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxTipoArquivo;
        private System.Windows.Forms.RadioButton radioButtonFixedWidth;
        private System.Windows.Forms.RadioButton radioButtonDelimitado;
        private System.Windows.Forms.Panel panelDelimited;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelFixedWidth;
        private System.Windows.Forms.Button buttonConfigFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTextDelimiter;
        private System.Windows.Forms.ComboBox comboBoxColumnDelimiter;
        private System.Windows.Forms.TextBox textBoxOtherDelimiter;
        private System.Windows.Forms.CheckBox checkBoxPrimeiraLinha;
        private System.Windows.Forms.Button buttonOpenSearchPanel;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSearchColumn;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxSearchPartial;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel3;
    }
}

