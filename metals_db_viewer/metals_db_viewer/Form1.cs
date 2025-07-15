using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace metals_db_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=metals;User Id=postgres;Password=123321;");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT material_id AS Индекс, material_name AS Название, material_description AS Сортамент FROM materials";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_materials.DataSource = dt;
            }
            cmd.Dispose();
            connection.Close();
        }

        private void dataGridView_materials_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            Data_buffer.cur_material_id = dataGridView_materials.Rows[e.RowIndex].Cells[0].Value.ToString();
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
