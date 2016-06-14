using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using GenericParsing;

namespace InterfaceColWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);

            panelFixedWidth.Visible = false;
            //panelDelimited.Visible = false;

            buttonOpenFile.Visible = false;
            textBoxGotoLine.Visible = false;
            buttonGotoLine.Visible = false;
            buttonExecute.Visible = false;
            comboBoxEncoding.SelectedIndex = 2;
            labelQtdeRegistros.Visible = false;
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
            Cursor.Current = Cursors.WaitCursor;
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
            Cursor.Current = Cursors.Default;
        }

        private void labelQtdeRegistros_TextChanged(object sender, EventArgs e)
        {
            if (convertLabelQtdRegToInt() > 0)
            {
                textBoxGotoLine.Visible = true;
                buttonGotoLine.Visible = true;
            }
            else
            {
                textBoxGotoLine.Visible = false;
                buttonGotoLine.Visible = false;
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

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!string.IsNullOrEmpty(labelXMLConfigFile.Text) && labelXMLConfigFile.Text != "Nenhum arquivo selecionado"
                && !string.IsNullOrEmpty(labelFileName.Text) && labelFileName.Text != "Nenhum arquivo selecionado")
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                
                using (GenericParserAdapter parser = new GenericParserAdapter(labelFileName.Text, GetEncodingFromCombo()))
                {
                    //parser.ColumnDelimiter = 
                    //parser.TextQualifier = 
                    parser.TextFieldType = FieldType.FixedWidth;
                    parser.Load(labelXMLConfigFile.Text);
                    dataSet1 = parser.GetDataSet();

                    int qtdRegistros = dataSet1.Tables[0].Rows.Count;
                    if (qtdRegistros > 1)
                    {
                        labelQtdeRegistros.Text = String.Format("{0:#,##0} Registros", dataSet1.Tables[0].Rows.Count);
                    }
                    else
                    {
                        labelQtdeRegistros.Text = String.Format("{0:#,##0} Registro", dataSet1.Tables[0].Rows.Count);
                    }

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
            Cursor.Current = Cursors.Default;
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
            if (radioButtonDelimitado.Checked)
            {
                panelFixedWidth.Visible = false;
            }
            else
            {
                panelFixedWidth.Visible = true;
            }
        }
        
    }
}
