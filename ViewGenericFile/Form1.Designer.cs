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
            this.buttonConfigFile = new System.Windows.Forms.Button();
            this.labelXMLConfigFile = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxGotoLine = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelQtdeRegistros = new System.Windows.Forms.Label();
            this.buttonGotoLine = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.comboBoxEncoding = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "XML";
            this.openFileDialog1.Filter = "Arquivo XML (.xml)|*.xml";
            // 
            // buttonConfigFile
            // 
            this.buttonConfigFile.Location = new System.Drawing.Point(12, 4);
            this.buttonConfigFile.Name = "buttonConfigFile";
            this.buttonConfigFile.Size = new System.Drawing.Size(110, 90);
            this.buttonConfigFile.TabIndex = 0;
            this.buttonConfigFile.Text = "Abrir arquivo modelo (XML)";
            this.toolTip1.SetToolTip(this.buttonConfigFile, resources.GetString("buttonConfigFile.ToolTip"));
            this.buttonConfigFile.UseVisualStyleBackColor = true;
            this.buttonConfigFile.Click += new System.EventHandler(this.buttonConfigFile_Click);
            // 
            // labelXMLConfigFile
            // 
            this.labelXMLConfigFile.AutoSize = true;
            this.labelXMLConfigFile.Location = new System.Drawing.Point(424, 9);
            this.labelXMLConfigFile.Name = "labelXMLConfigFile";
            this.labelXMLConfigFile.Size = new System.Drawing.Size(145, 13);
            this.labelXMLConfigFile.TabIndex = 1;
            this.labelXMLConfigFile.Text = "Nenhum arquivo selecionado";
            // 
            // textBoxGotoLine
            // 
            this.textBoxGotoLine.Location = new System.Drawing.Point(453, 72);
            this.textBoxGotoLine.Name = "textBoxGotoLine";
            this.textBoxGotoLine.Size = new System.Drawing.Size(61, 20);
            this.textBoxGotoLine.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxGotoLine, "Informe a linha desejada");
            this.textBoxGotoLine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxGotoLine_KeyUp);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(128, 4);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(110, 90);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Abrir arquivo texto";
            this.toolTip1.SetToolTip(this.buttonOpenFile, "Abrir o arquivo texto");
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(754, 244);
            this.dataGridView1.TabIndex = 9;
            // 
            // labelQtdeRegistros
            // 
            this.labelQtdeRegistros.AutoSize = true;
            this.labelQtdeRegistros.Location = new System.Drawing.Point(359, 75);
            this.labelQtdeRegistros.Name = "labelQtdeRegistros";
            this.labelQtdeRegistros.Size = new System.Drawing.Size(84, 13);
            this.labelQtdeRegistros.TabIndex = 6;
            this.labelQtdeRegistros.Text = "Nenhum registro";
            this.labelQtdeRegistros.TextChanged += new System.EventHandler(this.labelQtdeRegistros_TextChanged);
            // 
            // buttonGotoLine
            // 
            this.buttonGotoLine.Location = new System.Drawing.Point(520, 70);
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
            this.buttonExecute.Location = new System.Drawing.Point(243, 4);
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
            this.labelFileName.Location = new System.Drawing.Point(424, 28);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(145, 13);
            this.labelFileName.TabIndex = 3;
            this.labelFileName.Text = "Nenhum arquivo selecionado";
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
            this.comboBoxEncoding.Location = new System.Drawing.Point(427, 45);
            this.comboBoxEncoding.Name = "comboBoxEncoding";
            this.comboBoxEncoding.Size = new System.Drawing.Size(106, 21);
            this.comboBoxEncoding.TabIndex = 4;
            this.toolTip1.SetToolTip(this.comboBoxEncoding, "Codificação do arquivo texto.\r\nAltere somente se houver caracteres estranhos. \r\nE" +
        "xemplo: \"2�via\"");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Arquivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Codificação:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 354);
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
            this.Controls.Add(this.buttonConfigFile);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador Genérico de Arquivos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonConfigFile;
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
    }
}

