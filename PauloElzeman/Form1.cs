using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;


namespace PauloElzeman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataBaseConnection();
            CriarBancoSQLite();
            CriarTabelaSQlite();
            AtualizaListWier();
        }

        //Inicia a conexão com o banco de dados NOVO
        private static SQLiteConnection conexao;
        //Inicia a conexão com o DataAdapter
        private static SQLiteDataAdapter dataAdapter;
        //Cria DataTable
        private static DataTable DTable;
        // Armazena ID_VOO
        int ID_VOO;
        char radioButton;

        //Abre conexão com o DB
        private static SQLiteConnection DataBaseConnection()
        {
            conexao = new SQLiteConnection("DATA SOURCE=ACME.sqlite; Version=3;");

            try {conexao.Open(); /* MessageBox.Show("Banco de dados Conectado");*/}
            catch (Exception ex) {/*MessageBox.Show(ex.Message.ToString(), "Erro");*/}
            return conexao;
        }

        //Cria banco de dados caso inesxistente
        public static void CriarBancoSQLite()
        {
            try
            {SQLiteConnection.CreateFile(@"ACME.sqlite");}
            catch (Exception ex) {/*MessageBox.Show(ex.Message.ToString(), "Erro");*/}
        }

        //Cria tabela do banco de dados
        public static void CriarTabelaSQlite()
        {
            try
            {
                using (var cmd = DataBaseConnection().CreateCommand())
                {                    
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TB_VOO(" +
                                      "ID_VOO INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL," +
                                      "DATA_VOO DATETIME," + //NOT NULL
                                      "CUSTO NUMERIC (10, 2)," + //NOT NULL
                                      "DISTANCIA INT," + //NOT NULL
                                      "CAPTURA CHAR," + //NOT NULL
                                      "NIVEL_DOR INT)"; //NOT NULL

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {MessageBox.Show(ex.Message.ToString(), "Erro");}
        }

        public void AtualizaListWier()
        {
            try
            {
                using (var cmd = DataBaseConnection().CreateCommand())
                {
                    DTable = new DataTable();
                    cmd.CommandText = "SELECT * FROM TB_VOO";// "SELECT DATA_VOO, CUSTO, DISTANCIA, CAPTURA, NIVEL_DOR FROM TB_VOO";
                    dataAdapter = new SQLiteDataAdapter(cmd.CommandText, DataBaseConnection());
                    dataAdapter.Fill(DTable);
                    dataGridView.DataSource = DTable.DefaultView.Table;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[2].Visible = false;
                    dataGridView.Columns[3].Visible = false;
                }
            }
            catch (Exception ex) {/*MessageBox.Show(ex.Message.ToString());*/}
        }

        //Limpa campos de voo existente e abilita buttons SALVAR e CANCELAR
        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            ID_VOO = 0;
            dateTimePicker.Refresh();
            textBoxCusto.Text = string.Empty;
            textBoxDistancia.Text = string.Empty;
            textBoxNivelDor.Text = string.Empty;
            radioButtonCapN.Checked = false;
            radioButtonCapS.Checked = false;
        }

        //Deleta item selecionado do DataGridView e atualiza DB
        private void buttonExcluir_Click(object sender, EventArgs e)
        {            
            try
            {
                //Identifica o ID_VOO da row selecionada
                ID_VOO = Convert.ToInt32( dataGridView.CurrentRow.Cells[0].Value.ToString());

                ExecuteQuery("DELETE FROM TB_VOO WHERE ID_VOO ="+ID_VOO);
                AtualizaListWier();

                dateTimePicker.Refresh();
                textBoxCusto.Text = string.Empty;
                textBoxDistancia.Text = string.Empty;
                textBoxNivelDor.Text = string.Empty;
                radioButtonCapN.Checked = false;
                radioButtonCapS.Checked = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString());}
            ID_VOO = 0;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID_VOO!=0)
                {
                    ExecuteQuery("UPDATE TB_VOO SET DATA_VOO='"+ dateTimePicker.Value.Date.ToString("yyyyMMdd")+ "', CUSTO='" + textBoxCusto.Text + "', DISTANCIA='" +textBoxDistancia.Text+ "', CAPTURA='" + radioButton.ToString() + "',NIVEL_DOR='" +textBoxNivelDor.Text+ "' WHERE ID_VOO=" + ID_VOO + "");
                    AtualizaListWier();
                }
                else
                {
                    ExecuteQuery("INSERT INTO TB_VOO values(NULL,"+ dateTimePicker.Value.Date.ToString("yyyyMMdd")+ ","+textBoxCusto.Text+","+textBoxDistancia.Text+",'"+radioButton.ToString()+"',"+textBoxNivelDor.Text+")");
                    AtualizaListWier();
                }                
            }
            catch (Exception ex) { MessageBox.Show("Complete todos os campos para salvar"); }
            buttonIncluir_Click(null,null);
        }

        //Atualiza o DataGrid e desabilita as opções SALVAR e CANCELAR
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            buttonSalvar.Enabled = false;
            buttonCancelar.Enabled = false;
            AtualizaListWier();
        }
        
        //Controle chave de alternância do radio button
        private void radioButtonClick(object sender, EventArgs e)
        {
            if (radioButtonCapN.Checked == true)
            {radioButton = 'N'; radioButtonCapS.Checked = false; }
            else if (radioButtonCapS.Checked == true)
            {radioButton = 'S'; radioButtonCapN.Checked = false; }
            buttonCancelar.Enabled = true;
            buttonSalvar.Enabled = true;
        }

        //Ativa button SALVAR e CANCELAR ao clicar na textbox
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            buttonSalvar.Enabled = true;
            buttonCancelar.Enabled = true;
        }

        //Controle de selecão de itens do ListView e atulização de campos
        public void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            try
            {
                ID_VOO = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

                DTable = new DataTable();
                ExecuteQuery("SELECT * FROM TB_VOO Where ID_VOO=" + ID_VOO);
                dataAdapter.Fill(DTable);

                dateTimePicker.Value = Convert.ToDateTime(DTable.Rows[e.RowIndex][1].ToString());
                textBoxCusto.Text = DTable.Rows[e.RowIndex][2].ToString();
                textBoxDistancia.Text = DTable.Rows[e.RowIndex][3].ToString();
                textBoxNivelDor.Text = DTable.Rows[e.RowIndex][5].ToString();

                if (DTable.Rows[e.RowIndex][4].ToString() == "N")
                {radioButtonCapN.Checked = true; radioButton = 'N'; }
                else if (DTable.Rows[e.RowIndex][4].ToString() == "S")
                {radioButtonCapS.Checked = true; radioButton = 'S'; }
                else { radioButton = ' '; radioButtonCapS.Checked = false;  radioButtonCapN.Checked = false; }

                buttonSalvar.Enabled = false;
                buttonCancelar.Enabled = false;
            }
            catch(Exception ex) {MessageBox.Show(ex.Message.ToString());}
        }

        //Executar query
        public void ExecuteQuery(string strQuery)
        {
            var con = DataBaseConnection();
            var cmd = DataBaseConnection().CreateCommand();
            cmd.CommandText = strQuery;
            cmd.ExecuteNonQuery();
        }

        //Valida tipo de entrade de dados no textbox
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {e.Handled = true;}
        }

        private void textBoxCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {e.Handled = true;}
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1))
            { e.Handled = true;}
        }
    }
}


