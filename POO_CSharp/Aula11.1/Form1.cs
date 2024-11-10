using System.Data;
using System.Data.SqlClient;

namespace Aula11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (SqlConnection connection = new SQL().connection)
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM Estado";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string nome = reader["estado_nNome"].ToString();
                        cmbEstado.Items.Add(nome);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstado.Items.Clear();
            using(SqlConnection connection = new SQL().connection)
            {

              
                try
                {

                    connection.Open();
                    string sql = @"SELECT * FROM Municipio INNER JOIN Estado ON Municipio.estado_codigo = Estado.estado_codigo where Estado.estado_nNome = @ESTADO";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add("@ESTADO", SqlDbType.VarChar);
                    command.Parameters["@ESTADO"].Value = cmbEstado.SelectedItem.ToString();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string nome = reader["municipio_nome"].ToString();
                        cmbMunicipios.Items.Add(nome);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
}