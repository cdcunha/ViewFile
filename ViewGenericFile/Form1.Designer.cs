﻿namespace InterfaceColWeb
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonFixedWidth = new System.Windows.Forms.RadioButton();
            this.radioButtonDelimitado = new System.Windows.Forms.RadioButton();
            this.comboBoxColumnDelimiter = new System.Windows.Forms.ComboBox();
            this.comboBoxTextDelimiter = new System.Windows.Forms.ComboBox();
            this.textBoxOtherDelimiter = new System.Windows.Forms.TextBox();
            this.checkBoxPrimeiraLinha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBoxTipoArquivo.SuspendLayout();
            this.panelDelimited.SuspendLayout();
            this.panelFixedWidth.SuspendLayout();
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
            this.labelXMLConfigFile.Location = new System.Drawing.Point(620, 9);
            this.labelXMLConfigFile.Name = "labelXMLConfigFile";
            this.labelXMLConfigFile.Size = new System.Drawing.Size(145, 13);
            this.labelXMLConfigFile.TabIndex = 1;
            this.labelXMLConfigFile.Text = "Nenhum arquivo selecionado";
            // 
            // textBoxGotoLine
            // 
            this.textBoxGotoLine.Location = new System.Drawing.Point(649, 72);
            this.textBoxGotoLine.Name = "textBoxGotoLine";
            this.textBoxGotoLine.Size = new System.Drawing.Size(61, 20);
            this.textBoxGotoLine.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxGotoLine, "Informe a linha desejada");
            this.textBoxGotoLine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxGotoLine_KeyUp);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(324, 4);
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
            this.comboBoxEncoding.Location = new System.Drawing.Point(623, 45);
            this.comboBoxEncoding.Name = "comboBoxEncoding";
            this.comboBoxEncoding.Size = new System.Drawing.Size(106, 21);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(882, 288);
            this.dataGridView1.TabIndex = 9;
            // 
            // labelQtdeRegistros
            // 
            this.labelQtdeRegistros.AutoSize = true;
            this.labelQtdeRegistros.Location = new System.Drawing.Point(555, 75);
            this.labelQtdeRegistros.Name = "labelQtdeRegistros";
            this.labelQtdeRegistros.Size = new System.Drawing.Size(84, 13);
            this.labelQtdeRegistros.TabIndex = 6;
            this.labelQtdeRegistros.Text = "Nenhum registro";
            this.labelQtdeRegistros.TextChanged += new System.EventHandler(this.labelQtdeRegistros_TextChanged);
            // 
            // buttonGotoLine
            // 
            this.buttonGotoLine.Location = new System.Drawing.Point(716, 70);
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
            this.buttonExecute.Location = new System.Drawing.Point(439, 4);
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
            this.labelFileName.Location = new System.Drawing.Point(620, 28);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(145, 13);
            this.labelFileName.TabIndex = 3;
            this.labelFileName.Text = "Nenhum arquivo selecionado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Arquivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 48);
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
            this.groupBoxTipoArquivo.Location = new System.Drawing.Point(13, 4);
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
            this.panelFixedWidth.Location = new System.Drawing.Point(0, 1);
            this.panelFixedWidth.Name = "panelFixedWidth";
            this.panelFixedWidth.Size = new System.Drawing.Size(198, 76);
            this.panelFixedWidth.TabIndex = 16;
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
            // textBoxOtherDelimiter
            // 
            this.textBoxOtherDelimiter.Location = new System.Drawing.Point(171, 27);
            this.textBoxOtherDelimiter.MaxLength = 1;
            this.textBoxOtherDelimiter.Name = "textBoxOtherDelimiter";
            this.textBoxOtherDelimiter.Size = new System.Drawing.Size(20, 20);
            this.textBoxOtherDelimiter.TabIndex = 19;
            this.textBoxOtherDelimiter.Visible = false;
            // 
            // checkBoxPrimeiraLinha
            // 
            this.checkBoxPrimeiraLinha.AutoSize = true;
            this.checkBoxPrimeiraLinha.Location = new System.Drawing.Point(9, 5);
            this.checkBoxPrimeiraLinha.Name = "checkBoxPrimeiraLinha";
            this.checkBoxPrimeiraLinha.Size = new System.Drawing.Size(154, 17);
            this.checkBoxPrimeiraLinha.TabIndex = 20;
            this.checkBoxPrimeiraLinha.Text = "Primeira Linha é cabeçalho";
            this.checkBoxPrimeiraLinha.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 398);
            this.Controls.Add(this.groupBoxTipoArquivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEncoding);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.textBoxGotoLine);
            this.Controls.Add(this.buttonGotoLine);
            this.Controls.Add(this.labelQtdeRegistros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.labelXMLConfigFile);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador Genérico de Arquivo Texto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBoxTipoArquivo.ResumeLayout(false);
            this.groupBoxTipoArquivo.PerformLayout();
            this.panelDelimited.ResumeLayout(false);
            this.panelDelimited.PerformLayout();
            this.panelFixedWidth.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

