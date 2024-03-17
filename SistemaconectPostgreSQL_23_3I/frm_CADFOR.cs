using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaconectPostgreSQL_23_3I
{
    public partial class frm_CADFOR : Form
    {
        public frm_CADFOR()
        {
            InitializeComponent();
        }

        //Declarar Classe de ConexÃ£o e suas variaveis publicas.
        public NpgsqlConnection Conectar;
        public NpgsqlCommand ComandoSQL;
        public NpgsqlDataReader LerRegistro;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=root;Database=bancox";
        public string strSQL = "";

        private void frm_CADCLI_Load(object sender, EventArgs e)
        {
            //Desabilitando BotÃµes Alterar e Excluir
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        public void LimparObjetos()
        {

            //Limpar Objetos do FormulÃ¡rio
            txt_CNPJ.Clear();
            txt_NomeFantasia.Clear();
            txt_Telefonef.Clear();
            txt_Email.Clear();
            txt_RS.Clear();
            txt_date.Clear();

            return;

        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            //Inserir Registro

            //Bloco try/catch serve para tratamento de exceÃ§Ãµes (possiveis falhas ou erros),
            //Tratamento de cÃ³digos que podem nÃ£o ser totalmente atendidos e gerarem alguma exceÃ§Ã£o/erro.
            try
            {
                //Lembramos que estamos usando o Objeto para CPF (MaskTextBox),
                //quando usamos a propiedade Mask, invertemos o simbolo (,) por (.) e vice e versa
                //Analisando a consistencia (validaÃ§Ã£o) do Objeto "mkt_CNPJ",
                //onde nÃ£o pode ser menor que 18 caracteres (extraindo os espaÃ§os vazios)
                if (txt_CNPJ.Text.Trim().Length == 20)
                {
                    //Criar e Estanciar Objeto a Classe de ConexÃ£o com o Danco de Dados 
                    Conectar = new NpgsqlConnection(strCon);

                    //Abrir Objeto de ConexÃ£o com Banco de Dados criada acima;
                    Conectar.Open();

                    //Montando a variavel tipo String "strSQL" de Leitura de Dados (concatenando) com os objetos do FormulÃ¡rio
                    strSQL = "SELECT * FROM fornecedor WHERE CNPJ = '" + txt_CNPJ.Text + "'";

                    //MessageBox.Show(message, title, buttons)
                    //Mensagem para apresentar a String (strSQL)
                    MessageBox.Show(strSQL);

                    //Instanciando o Objeto de classe de Command (comando) para armazenar a InstruÃ§Ã£o / Clausulas SQL
                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    //Executando comando com resposta de Leitura de Registros (linha por Linha)
                    LerRegistro = ComandoSQL.ExecuteReader();

                    //Metodo Read(): Informe um "boolean" "True" (Existe Registro) e "False" (NÃ£o Existe Registro),
                    //Possibilita Ler o Proximo Regsitro de uma Tabela (Enquanto for True, Se existir registro)

                    if (LerRegistro.Read())
                    {
                        MessageBox.Show("Cliente jÃ¡ Existe!!!", "Sistema Informa");
                    }
                    else
                    {
                        //Fechar Classe DataReader e Dispose (limpar o Objeto) da Classe de ComandoSQL
                        LerRegistro.Close();
                        ComandoSQL.Dispose();
                        ComandoSQL.Transaction = null;

                        //Podemos efetuar a validaÃ§Ã£o de todos os campos, antes de inserirmos o registro...
                        //Montando a variavel tipo String "strSQL" de InserÃ§Ã£o dos Dados (concatenando) com os objetos do FormulÃ¡rio 
                        strSQL = "INSERT INTO fornecedor " +
                                 "(CNPJ, nome_fantasia, telefone, email, razao_social, dn) " +
                                 "VALUES (" +
                                 "'" + txt_CNPJ.Text + "'," +
                                 "'" + txt_NomeFantasia.Text + "'," +
                                 "'" + txt_Telefonef.Text + "'," +
                                 "'" + txt_Email.Text + "'," +
                                 "'" + txt_RS.Text + "'," +
                                 "TO_DATE ('" + txt_date.Text + "', 'DD/MM/YYYY'));";

                        //Mensagem para apresentar a String (strSQL)
                        MessageBox.Show(strSQL);

                        //Criar o Objeto com a classe de Command (comando) para armazenar a InstruÃ§Ã£o / Comando SQL
                        //comandoSQL jÃ¡ Ã© uma Classe NpgsqlCommand, portanto sÃ³ precisamos Instacia-lÃ¡
                        ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                        //Executando sem resposta
                        ComandoSQL.ExecuteNonQuery();
                        MessageBox.Show("Registro Inserido com Sucesso...", "Sistema Informa");


                        //Limpar Objetos usando a funÃ§Ã£o 
                        LimparObjetos();
                    }

                    //Fechar ConexÃ£o
                    Conectar.Close();

                }
                else
                {
                    MessageBox.Show("Preencher corretamente pelo menos o campo CNPJ!!!");
                }

                //Votar Cursor para o Objeto de Formulario
                txt_CNPJ.Focus();


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            //Consultar Registro

            //Bloco try/catch serve para tratamento de exceÃ§Ãµes (possiveis falhas ou erros),
            //Tratamento de cÃ³digos que podem nÃ£o ser totalmente atendidos e gerarem alguma exceÃ§Ã£o/erro.
            try
            {
                if (txt_CNPJ.Text.Trim().Length == 20)
                {
                    //Instanciar Objeto da Classe de ConexÃ£o com o Danco de Dados 
                    Conectar = new NpgsqlConnection(strCon);

                    //Abrir Objeto de ConexÃ£o com Banco de Dados criada acima;
                    Conectar.Open();

                    //Mondando a String (concatenando) com os objetos do FormulÃ¡rio 
                    strSQL = "SELECT * FROM fornecedor WHERE (CNPJ =" + "'" + txt_CNPJ.Text + "')";

                    //Mensagem para apresentar a String (strSQL)
                    MessageBox.Show(strSQL);

                    //Instanciando o Objeto da classe de Command (comando) para armazenar a InstruÃ§Ã£o / Clausulas SQL
                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    //OleDbDataReader rs = new OleDbDataReader(comandoSQL); 
                    //Executando sem resposta
                    //comandoSQL.ExecuteNonQuery();

                    LerRegistro = ComandoSQL.ExecuteReader();

                    //Metodo Read(): Informe um "boolean" "True" (exite Registro) e "False" (NÃ£o Existe Registro),
                    //Possibilita Ler o Proximo Regsitro de uma Tabela (Enquanto for True, Se existir registro)

                    if (LerRegistro.Read())
                    {
                        //Populando Objetos do Form com Dados do Registro (lerRegistro)
                        txt_CNPJ.Text = LerRegistro.GetString(0);
                        txt_NomeFantasia.Text = LerRegistro.GetString(1);
                        txt_Telefonef.Text = LerRegistro.GetString(2);
                        txt_Email.Text = LerRegistro.GetString(3);
                        txt_RS.Text = LerRegistro.GetString(4);
                        txt_date.Text = LerRegistro.GetDateTime(5).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        MessageBox.Show("CNPJ " + txt_CNPJ.Text + " NÃ£o Localizado!!!", "Sistema Informa");
                       txt_CNPJ.Focus();
                    }

                    if (DialogResult.No == MessageBox.Show("Deseja Editar Registro?", "Sistema Informa",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {

                        //Limpar Objetos do FormulÃ¡rio usando a funÃ§Ã£o
                        LimparObjetos();
                    }
                    else
                    {
                        btn_Alterar.Enabled = true;
                        btn_Excluir.Enabled = true;
                    }


                    //Fechar Classe DataReader e Dispose (limpar o Objeto) da Classe de ComandoSQL
                    LerRegistro.Close();
                    ComandoSQL.Dispose();
                    ComandoSQL.Transaction = null;

                    //Fechar ConexÃ£o
                    Conectar.Close();

                }
                else
                {
                    MessageBox.Show("Preencher corretamente pelo menos o campo CNPJ!!!");
                }

                //Votar Cursor para o Objeto de Formulario
                txt_CNPJ.Focus();

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar e Estanciar Objeto a Classe de ConexÃ£o com o Danco de Dados 
                Conectar = new NpgsqlConnection(strCon);

                //Abrir Objeto de ConexÃ£o com Banco de Dados criada acima;
                Conectar.Open();

                if (DialogResult.Yes == MessageBox.Show("Confirma AlteraÃ§Ã£o do Registro?", "Sistema Informa",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button2))
                {
                    //Mondando a String de Consulta (concatenando) com os objetos do FormulÃ¡rio 
                    strSQL = "UPDATE fornecedor SET " +
                                    "nome_fantasia = '" + txt_NomeFantasia.Text + "', " +
                                    "telefone = '" + txt_Telefonef.Text + "', " +
                                    "email = '" + txt_Email.Text + "', " +
                                    "razao_social = '" + txt_RS.Text + "', " +
                                    "dn = TO_DATE('" + txt_date.Text + "', 'DD/MM/YYYY') " +
                                    "WHERE (cnpj = '" + txt_CNPJ.Text + "')";

                    //Mensagem para apresentar a String (strSQL)
                    MessageBox.Show(strSQL);

                    //comandoSQL jÃ¡ Ã© uma Classe OleDbCommand, portanto sÃ³ precisamos Instacia-lÃ¡
                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    //Executando sem resposta
                    ComandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Registro Alterado com Sucesso...", "Sistema Informa");
                }
                else
                {
                    MessageBox.Show("OperaÃ§Ã£o Cancelada!!!", "Sistema Informa");
                }

                MessageBox.Show("Limpar FormulÃ¡rio (Dados)...", "Sistema Informa");

                //Limpar Objetos do FormulÃ¡rio
                LimparObjetos();

                //Desabilitar (desativar) os botÃµes Alterar e Excluir
                btn_Alterar.Enabled = false;
                btn_Excluir.Enabled = false;
                //Habilitar os botÃµes Inserir e Consultar
                btn_Consultar.Enabled = true;
                btn_Inserir.Enabled = true;
                //Habilitar o mkt_CPF
                txt_CNPJ.Enabled = true;

                //Fechar Classe DataReader e Dispose (limpar o Objeto) da Classe de ComandoSQL
                LerRegistro.Close();
                ComandoSQL.Dispose();
                ComandoSQL.Transaction = null;

                //Fechar ConexÃ£o
                Conectar.Close();

                //Votar Cursor para o Objeto de Formulario
                txt_CNPJ.Focus();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Excluir Registro

            //Bloco try/catch serve para tratamento de exceÃ§Ãµes (possiveis falhas ou erros),
            //Tratamento de cÃ³digos que podem nÃ£o ser totalmente atendidos e gerarem alguma exceÃ§Ã£o/erro.
            try
            {

                //Criar e Estanciar Objeto a Classe de ConexÃ£o com o Danco de Dados 
                Conectar = new NpgsqlConnection(strCon);

                //Abrir Objeto de ConexÃ£o com Banco de Dados criada acima;
                Conectar.Open();


                //ConsistÃªncia para ExclusÃ£o 
                if (DialogResult.Yes == MessageBox.Show("Excluir Registro?", "Sistema Informa",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question,
                                                   MessageBoxDefaultButton.Button2))
                {
                    //Mondando a String de Consulta (concatenando) com os objetos do FormulÃ¡rio 
                    strSQL = "DELETE FROM fornecedor WHERE(cnpj = '" + txt_CNPJ.Text + "')";
                    MessageBox.Show(strSQL);

                    //comandoSQL jÃ¡ Ã© uma Classe NpgsqlCommand, portanto sÃ³ precisamos Instacia-lÃ¡
                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    //Executando sem resposta
                    ComandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Registro ExcluÃ­do com Sucesso...", "Sistema Informa");
                }
                else
                {
                    MessageBox.Show("OperaÃ§Ã£o Cancelada!!!", "Sistema Informa");
                }

                MessageBox.Show("Limpar FormulÃ¡rio (Dados)...", "Sistema Informa");

                //Limpar Objetos do FormulÃ¡rio
                LimparObjetos();

                //Desabilitar (desativar) os botÃµes Alterar e Excluir
                btn_Alterar.Enabled = false;
                btn_Excluir.Enabled = false;
                //Habilitar os botÃµes Inserir e Consultar
                btn_Consultar.Enabled = true;
                btn_Inserir.Enabled = true;
                //Habilitar o mkt_CPF
                txt_CNPJ.Enabled = true;

                //Fechar Classe DataReader e Dispose (limpar o Objeto) da Classe de ComandoSQL
                LerRegistro.Close();
                ComandoSQL.Dispose();
                ComandoSQL.Transaction = null;

                //Fechar ConexÃ£o
                Conectar.Close();

                //Votar Cursor para o Objeto de Formulario
                txt_CNPJ.Focus();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
