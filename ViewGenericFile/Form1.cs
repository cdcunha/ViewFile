using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GenericParsing;
using Utils;

namespace InterfaceColWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Used for link event to paint column number in the DataGridView
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
        }

        private int convertLabelQtdRegToInt()
        {
            return Convert.ToInt32(labelQtdeRegistros.Text.Replace(" Registros", "").Replace(" Registro", "").Replace(".", ""));
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void buttonConfigFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Arquivo XML (.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                labelXMLConfigFile.Text = openFileDialog1.FileName;
                buttonOpenFile.Visible = true;
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Todos os arquivos (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                labelFileName.Text = openFileDialog1.FileName;
                buttonExecute.Visible = true;
                labelQtdeRegistros.Visible = true;
                buttonExecute_Click(sender, e);
            }
        }

        private void buttonGotoLine_Click(object sender, EventArgs e)
        {
            ToggleCursorMouse();
            if (!string.IsNullOrEmpty(textBoxGotoLine.Text))
            {
                try
                {
                    int numLin = Convert.ToInt32(textBoxGotoLine.Text);
                    int qtdReg = convertLabelQtdRegToInt();
                    if (numLin <= qtdReg)
                    {
                        numLin--;
                        dataGridView1.Rows[numLin].Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = numLin;
                    }
                    else
                    {
                        MessageBox.Show(String.Format("O número da linha desejada deve ser menor ou igual à {0}", qtdReg));
                    }
                }
                catch
                {
                    MessageBox.Show("Número inválido");
                }
            }
            ToggleCursorMouse();
        }

        private void labelQtdeRegistros_TextChanged(object sender, EventArgs e)
        {
            if (convertLabelQtdRegToInt() > 0)
            {
                buttonOpenSearchPanel.Visible = true;
                panelSearch.Visible = true;
            }
            else
            {
                buttonOpenSearchPanel.Visible = false;
                panelSearch.Visible = false;
            }
        }

        private Encoding GetEncodingFromCombo()
        {
            if (comboBoxEncoding.SelectedItem.ToString() == "ASCII")
            {
                return Encoding.ASCII;
            }
            else if (comboBoxEncoding.SelectedItem.ToString() == "BigEndianUnicode")
            {
                return Encoding.BigEndianUnicode;
            }
            else if (comboBoxEncoding.SelectedItem.ToString() == "Default")
            {
                return Encoding.Default;
            }
            else if (comboBoxEncoding.SelectedItem.ToString() == "Padrão")
            {
                return Encoding.Default;
            }
            else if (comboBoxEncoding.SelectedItem.ToString() == "Unicode")
            {
                return Encoding.Unicode;
            }
            else if (comboBoxEncoding.SelectedItem.ToString() == "UTF32")
            {
                return Encoding.UTF32;
            }
            else if (comboBoxEncoding.SelectedItem.ToString() == "UTF7")
            {
                return Encoding.UTF7;
            }
            else if (comboBoxEncoding.SelectedItem.ToString() == "UTF8")
            {
                return Encoding.UTF8;
            }
            else
            {
                return Encoding.Default;
            }
        }

        private void FillComboSearchColumn()
        {
            comboBoxSearchColumn.Items.Clear();
            if (dataSet1.Tables.Count > 1)
            {
                foreach (DataColumn col in dataSet1.Tables[0].Columns)
                {
                    comboBoxSearchColumn.Items.Add(col.ToString());
                }
            }
            comboBoxSearchColumn.Refresh();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            ToggleCursorMouse();

            var checkbox = groupBoxTipoArquivo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkbox.Text == "Delimitado")
            {
                AbrirArquivoDelimitado();
            }
            else
            {
                AbrirArquivoLaguraFixa();
            }
            FillComboSearchColumn();

            ToggleCursorMouse();
        }

        private char? GetColumnDelimiterChar()
        {
            if (comboBoxColumnDelimiter.SelectedItem.ToString() == "Outro")
            {
                return Char.Parse(textBoxOtherDelimiter.Text);
            }
            else if (comboBoxColumnDelimiter.SelectedItem.ToString() == "Tabulação")
            {
                return '\t';
            }
            else if (comboBoxColumnDelimiter.SelectedItem.ToString() == "Vírgula")
            {
                return ',';
            }
            else if (comboBoxColumnDelimiter.SelectedItem.ToString() == "Espaço")
            {
                return ' ';
            }
            else if (comboBoxColumnDelimiter.SelectedItem.ToString() == "Ponto e Vírgula")
            {
                return ';';
            }
            else 
            {
                return null;
            }
        }

        private char? GetTextDelimiterChar()
        {
            if (comboBoxTextDelimiter.SelectedItem.ToString() == "\"")
            {
                return '\"';
            }
            else if (comboBoxTextDelimiter.SelectedItem.ToString() == "'")
            {
                return '\'';
            }

            else
            {
                return null;
            }
        }

        private void AbrirArquivoDelimitado() {
            if (comboBoxColumnDelimiter.SelectedItem.ToString() == "Outro")
            {
                if (string.IsNullOrEmpty(textBoxOtherDelimiter.Text))
                {
                    MessageBox.Show("Informe o delimitador desejado");
                    textBoxOtherDelimiter.Focus();
                    return;
                }
            }

            if (!string.IsNullOrEmpty(labelFileName.Text) && labelFileName.Text != "Nenhum arquivo selecionado")
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataSet1.Tables.Clear();
                using (GenericParser parser = new GenericParser())
                {
                    List<string> listHeader = new List<string>();
                    List<List<string>> listRows = new List<List<string>>();

                    parser.SetDataSource(labelFileName.Text);

                    parser.TextFieldType = FieldType.Delimited;
                    parser.ColumnDelimiter = GetColumnDelimiterChar();
                    parser.FirstRowHasHeader = checkBoxPrimeiraLinha.Checked;
                    //parser.SkipStartingDataRows = 10;
                    //parser.MaxBufferSize = 4096;
                    //parser.MaxRows = 500;
                    parser.TextQualifier = GetTextDelimiterChar();
                    
                    while (parser.Read())
                    {
                        List<string> listColsInRows = new List<string>();
                        if (listHeader.Count() == 0)
                        {
                            for (int i=0; i < parser.ColumnCount; i++)
                            {
                                if (string.IsNullOrEmpty(parser.GetColumnName(i))){
                                    listHeader.Add("Coluna " + (i + 1).ToString());
                                }
                                else
                                {
                                    listHeader.Add(parser.GetColumnName(i));
                                }
                            }
                        }
                        if (listHeader.Count() > 0)
                        {
                            for (int i = 0; i < parser.ColumnCount; i++)
                            {
                                listColsInRows.Add(parser[i]);
                            }
                        }
                        if (listColsInRows.Count() > 0)
                        {
                            listRows.Add(listColsInRows);
                        }
                    }

                    DataTable dataTable = new DataTable();

                    foreach (string col in listHeader)
                    {
                        dataTable.Columns.Add(col);
                    }

                    
                    foreach (List<string> row in listRows)
                    {
                        object[] values = new object[row.Count];
                        foreach (string col in row)
                        {
                            values[row.IndexOf(col)] = col;
                        }
                        dataTable.Rows.Add(values);
                    }

                    dataSet1.Tables.Add(dataTable);

                    VerifyGridNumRowAndSetLabelReg(dataSet1.Tables[0].Rows.Count);

                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dataSet1.Tables[0];
                    dataGridView1.Focus();
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(labelFileName.Text) && labelFileName.Text != "Nenhum arquivo selecionado")
                {
                    {
                        MessageBox.Show("Selecione o arquivo texto");
                    }
                }
            }
        }

        private void VerifyGridNumRowAndSetLabelReg(int count)
        {
            if (count > 1)
            {
                labelQtdeRegistros.Text = String.Format("{0:#,##0} Registros", count);
            }
            else
            {
                labelQtdeRegistros.Text = String.Format("{0:#,##0} Registro", count);
            }
        }
        
        private void AbrirArquivoLaguraFixa()
        {
            if (!string.IsNullOrEmpty(labelXMLConfigFile.Text) && labelXMLConfigFile.Text != "Nenhum arquivo selecionado"
                && !string.IsNullOrEmpty(labelFileName.Text) && labelFileName.Text != "Nenhum arquivo selecionado")
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();

                using (GenericParserAdapter parser = new GenericParserAdapter(labelFileName.Text, GetEncodingFromCombo()))
                {
                    parser.Load(labelXMLConfigFile.Text);
                    dataSet1 = parser.GetDataSet();
                    
                    VerifyGridNumRowAndSetLabelReg(dataSet1.Tables[0].Rows.Count);

                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dataSet1.Tables[0];
                    dataGridView1.Focus();
                }
            }
            else
            {
                string message = "";
                if (!string.IsNullOrEmpty(labelXMLConfigFile.Text) && labelXMLConfigFile.Text != "Nenhum arquivo selecionado")
                {
                    message += "Selecione o arquivo modelo (XML)\n";
                }
                if (!string.IsNullOrEmpty(labelFileName.Text) && labelFileName.Text != "Nenhum arquivo selecionado")
                {
                    {
                        message += "Selecione o arquivo texto\n";
                    }
                }
                MessageBox.Show(message);
            }
        }

        private void textBoxGotoLine_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonGotoLine_Click(sender, e);
            }
        }

        private void radioButtonDelimited_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = groupBoxTipoArquivo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkbox.Text == "Delimitado")
            {
                panelFixedWidth.Visible = false;
                buttonOpenFile.Visible = true;
                labelXMLConfigFile.Text = "Não é necessário";
            }
            else
            {
                panelFixedWidth.Visible = true;
                buttonOpenFile.Visible = false;
                labelXMLConfigFile.Text = "Nenhum arquivo selecionado";
            }
        }

        private void comboBoxColumnDelimiter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxColumnDelimiter.SelectedItem.ToString() == "Outro")
                textBoxOtherDelimiter.Visible = true;
            else
                textBoxOtherDelimiter.Visible = false;
        }

        private DialogResult ShowDialogYesNo(string msg, string title)
        {
            return MessageBox.Show(msg, title, MessageBoxButtons.YesNo);
        }

        private void ToggleCursorMouse()
        {
            if (Cursor.Current == Cursors.Default)
                Cursor.Current = Cursors.WaitCursor;
            else 
                Cursor.Current = Cursors.Default;
        }

        private void DataGridViewSelectLine(int numLin)
        {
            dataGridView1.Rows[numLin].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = numLin;
        }
        
        private void SearchValueInColumn(int colIndex, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (dataSet1.Tables[0].Rows.Count > 0)
                {
                    ToggleCursorMouse();

                    bool wasFound = false;

                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = dataSet1.Tables[0];
                    foreach (DataRow row in dataSet1.Tables[0].Rows)
                    {
                        if (checkBoxSearchPartial.Checked)
                        {
                            if (row.ItemArray[colIndex].ToString().Like(value))
                            {
                                DataGridViewSelectLine(dataSet1.Tables[0].Rows.IndexOf(row));
                                wasFound = true;
                                ToggleCursorMouse();
                                if (ShowDialogYesNo("Continuar busca?", string.Format("Procurando por {0}", value)) == DialogResult.No)
                                {
                                    break;
                                }
                                ToggleCursorMouse();
                            }
                        }
                        else
                        {
                            if (row.ItemArray[colIndex].ToString().ToUpper() == value.ToUpper())
                            {
                                DataGridViewSelectLine(dataSet1.Tables[0].Rows.IndexOf(row));
                                wasFound = true;
                                ToggleCursorMouse();
                                if (ShowDialogYesNo("Continuar busca?", string.Format("Procurando por {0}", value)) == DialogResult.No)
                                {
                                    break;
                                }
                                ToggleCursorMouse();
                            }
                        }
                    }
                    ToggleCursorMouse();
                    if (!wasFound)
                    {
                        MessageBox.Show("O texto informado não foi encontrado na coluna selecionada");
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite um valor para buscar");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelFixedWidth.Visible = false;
            buttonOpenSearchPanel.Visible = false;
            buttonExecute.Visible = false;
            comboBoxEncoding.SelectedIndex = 2;
            labelQtdeRegistros.Visible = false;

            comboBoxColumnDelimiter.SelectedIndex = 1;
            comboBoxTextDelimiter.SelectedIndex = 0;
            radioButtonDelimited_CheckedChanged(sender, e);
        }

        private void buttonOpenSearchPanel_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = !panelSearch.Visible;
            if (buttonOpenSearchPanel.Text.Like("Abrir%"))
            {
                buttonOpenSearchPanel.Text = "Fechar Pesquisa";
            }
            else
            {
                buttonOpenSearchPanel.Text = "Abrir Pesquisa";
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text) || comboBoxSearchColumn.SelectedItem == null)
            {
                string message = "";
                if (string.IsNullOrEmpty(textBoxSearch.Text))
                {
                    message = "Informe o texto\n";
                    textBoxSearch.Focus();
                }
                if (comboBoxSearchColumn.SelectedItem == null)
                {
                    message = "Informe a coluna\n";
                    comboBoxSearchColumn.Focus();
                }
                MessageBox.Show(message);
            }   
            else
                SearchValueInColumn(comboBoxSearchColumn.Items.IndexOf(comboBoxSearchColumn.SelectedItem), textBoxSearch.Text);
        }
    }
}
