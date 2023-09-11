using Microsoft.Data.SqlClient;

namespace Faktury
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-KI00HH7\\SQLEXPRESS; Initial Catalog=Sales; Integrated Security=True; TrustServerCertificate=True";

            string sqlQuery = "INSERT INTO Invoice (firstname, lastname, value, item) VALUES (@firstname, @lastname, @value, @item)";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand sc = new SqlCommand(sqlQuery, conn);

            sc.Parameters.AddWithValue("@firstname", firstNameTxt.Text);
            sc.Parameters.AddWithValue("@lastname", lastNameTxt.Text);
            sc.Parameters.AddWithValue("@value", valueTxt.Value);
            sc.Parameters.AddWithValue("@item", itemTxt.Text);

            conn.Open();
            sc.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Dane zapisane.");
        }
    }
}