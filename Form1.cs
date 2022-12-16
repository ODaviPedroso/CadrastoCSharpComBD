using System.Data;
using System.Data.SqlClient;

namespace CadrastoCSharpComBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unesclabs102\\source\\repos\\CadrastoCSharpComBD\\Database1.mdf;Integrated Security=True";
            string stringDeComando = "INSERT INTO TabelaCadastro (Nome, Documento, Nascimento, Rua, Numero) VALUES (@VarNome, @VarDocumento, @VarNascimento, @VarRua, @VarNumero)";
            SqlConnection? con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                sqlCommand.Parameters.AddWithValue("@VarNome", textBoxNomecompleto.Text);
                sqlCommand.Parameters.AddWithValue("@VarDocumento", textBoxDocumento.Text);
                sqlCommand.Parameters.AddWithValue("@VarNascimento", textBoxDataNascimento.Text);
                sqlCommand.Parameters.AddWithValue("@VarRua", textBoxNomeDaRua.Text);
                sqlCommand.Parameters.AddWithValue("@VarNumero", textBoxNumeroDaCasa.Text);
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unesclabs102\\source\\repos\\CadrastoCSharpComBD\\Database1.mdf;Integrated Security=True";
            string stringDeComando = "SELECT Nome, Documento, Nascimento, Rua, Numero FROM TabelaCadastro WHERE Documento = @VarDocumento";
            SqlConnection? con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                sqlCommand.Parameters.AddWithValue("@VarDocumento", textBoxPesquisaDocumento.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                con.Open();
                adapter.Fill(dt);
                dataGridViewCadastro.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (con != null) con.Close();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\unesclabs102\\source\\repos\\CadrastoCSharpComBD\\Database1.mdf;Integrated Security=True";
            string stringDeComando = "DELETE  FROM TabelaCadastro WHERE Documento = @VarDocumento";
            SqlConnection? con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                sqlCommand.Parameters.AddWithValue("@VarDocumento", textBoxPesquisaDocumento.Text);
                con.Open();;
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (con != null) con.Close();
            }
        }
    }
}