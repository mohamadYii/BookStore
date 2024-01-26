using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BookStore
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=BookStoreDB;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Book", connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            DataInfos.DataSource = table;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            connection.Open();
            command.CommandText = "Insert Into Book Values(@Title, @Author, @BNumber, @Review, @Genre, @price)";
            command.Parameters.AddWithValue("@Title", TxtTitle.Text);
            command.Parameters.AddWithValue("@Author", TxtAuthor.Text);
            command.Parameters.AddWithValue("@BNumber", TxtBNumber.Text);
            command.Parameters.AddWithValue("@Review", TxtReview.Text);
            command.Parameters.AddWithValue("@Genre", TxtGenre.Text);
            command.Parameters.AddWithValue("@price", TxtPrice.Value);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Saved");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Book Where Title Like '%" + TxtTitle.Text + "%'", connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            DataInfos.DataSource = table;
        }

        private void DataInfos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtTitle.Tag = DataInfos.CurrentRow.Cells[0].Value;
            TxtTitle.Text = DataInfos.CurrentRow.Cells[1].Value.ToString();
            TxtAuthor.Text = DataInfos.CurrentRow.Cells[2].Value.ToString();
            TxtBNumber.Text = DataInfos.CurrentRow.Cells[3].Value.ToString();
            TxtReview.Text = DataInfos.CurrentRow.Cells[4].Value.ToString();
            TxtGenre.Text = DataInfos.CurrentRow.Cells[5].Value.ToString();
            TxtPrice.Value = int.Parse(DataInfos.CurrentRow.Cells[6].Value.ToString());
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            connection.Open();
            command.CommandText = "Update Book Set Title = @Title, Author = @Author, BNumber = @BNumber, Review = @Review, Genre = @Genre, Price = @price Where Id = @id";
            command.Parameters.AddWithValue("@Title", TxtTitle.Text);
            command.Parameters.AddWithValue("@Author", TxtAuthor.Text);
            command.Parameters.AddWithValue("@BNumber", TxtBNumber.Text);
            command.Parameters.AddWithValue("@Review", TxtReview.Text);
            command.Parameters.AddWithValue("@Genre", TxtGenre.Text);
            command.Parameters.AddWithValue("@price", TxtPrice.Value);
            command.Parameters.AddWithValue("@id", TxtTitle.Tag);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Edited!");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            connection.Open();
            command.CommandText = "Delete From Book Where Id = @id";
            command.Parameters.AddWithValue("@id", TxtTitle.Tag);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Removed!");
        }
    }
}
