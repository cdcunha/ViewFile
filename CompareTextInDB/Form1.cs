using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericParsing;
using System.Data.SqlClient;

namespace CompareTextInDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            buttonOpenFile.Visible = false;
            textBoxGotoLine.Visible = false;
            buttonGotoLine.Visible = false;
            buttonExecute.Visible = false;
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
            }
        }

        private void buttonGotoLine_Click(object sender, EventArgs e)
        {
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

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelXMLConfigFile.Text) && !string.IsNullOrEmpty(labelFileName.Text))
            {
                dataGridView1.DataSource = null;
                using (GenericParserAdapter parser = new GenericParserAdapter(labelFileName.Text))
                {
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

                    dataSet1.Tables[0].Columns.Add("Existe", typeof(System.String));
                    List<String> listCpfFound = new List<String>();

                    if (!string.IsNullOrEmpty(textBoxConnectioString.Text) && !string.IsNullOrEmpty(textBoxQuery.Text))
                    {
                        try
                        {
                            //Password=sqluser;User ID=sqluser;Data Source=serverss003;Initial Catalog=COL_COLWEBACEITE;Persist Security Info=True
                            using (var con = new SqlConnection(textBoxConnectioString.Text))
                            {
                                string filtro = "";
                                foreach (DataRow row in dataSet1.Tables[0].Rows)
                                {
                                    string text = row[2].ToString();
                                    string cpf = text.Substring(0, 3) + "." +
                                                 text.Substring(3, 3) + "." +
                                                 text.Substring(6, 3) + "-" +
                                                 text.Substring(9, 2);

                                    text = row[9].ToString();
                                    string data = text.Substring(4, 4) + text.Substring(2, 2) + text.Substring(0, 2);

                                    string propCia = row[11].ToString().TrimStart('0');

                                    if (string.IsNullOrEmpty(filtro))
                                    {
                                        filtro = string.Format(" where (tc.Cgc_cpf = '{0}' and td.Inicio_vigencia = '{1}' and td.Proposta_cia = '{2}')\n", cpf, data, propCia);
                                    }
                                    else
                                    {
                                        filtro += string.Format(" or (tc.Cgc_cpf = '{0}' and td.Inicio_vigencia = '{1}' and td.Proposta_cia = '{2}')\n", cpf, data, propCia);
                                    }
                                }
                                con.Open();
                                using (SqlCommand command = new SqlCommand(string.Format(textBoxQuery.Text, filtro), con))
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        listCpfFound.Add(reader.GetString(0));
                                    }
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                        }
                    }

                    foreach (DataRow row in dataSet1.Tables[0].Rows)
                    {
                        if (listCpfFound.Where(c => c[0].ToString() == row[2].ToString()).Count() > 0)
                        {
                            row["Existe"] = "Sim";
                        }
                        else
                        {
                            row["Existe"] = "Não";
                        }

                    }

                    dataGridView1.Focus();
                }
            }
        }
    }
}
