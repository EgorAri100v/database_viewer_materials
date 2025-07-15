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

namespace metals_db_viewer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = "Физико-механические свойства материала " + Data_buffer.cur_material_id.ToString();

            send_quary(dataGridView_phys_mech_prop, "SELECT property_name AS Температура, unit_mesure AS c, _20 AS \"20\", _50 AS \"50\", _100 AS \"100\", _150 AS \"150\", _200 AS \"200\", _250 AS \"250\", _300 AS \"300\", _350 AS \"350\", _400 AS \"400\", _450 AS \"450\", _500 AS \"500\" FROM phys_mech_properties WHERE material_id = " + Data_buffer.cur_material_id);
            send_quary(dataGridView_sources, "SELECT source_name AS Источник, application AS Приложение, table_num AS Таблица, drawing AS Рисунок, page AS страница FROM sources WHERE material_id = " + Data_buffer.cur_material_id + " AND property_type = 'phys_mech'");
            send_quary(dataGridView_properties_2, "SELECT temperature AS \"Температура / время\", _10 AS \"10\", _30 AS \"30\", _100 AS \"100\", _300 AS \"300\", _1000 AS \"1000\", _3000 AS \"3000\", _10000 AS \"10000\", _30000 AS \"30000\", _100000 AS \"100000\" FROM properties_2 WHERE material_id = " + Data_buffer.cur_material_id);
            send_quary(dataGridView_sources_2, "SELECT source_name AS Источник, application AS Приложение, drawing AS Таблица, table_num AS Рисунок, page AS страница FROM sources WHERE material_id = " + Data_buffer.cur_material_id + " AND property_type = 'Zt'");
        }
        private void send_quary(DataGridView obj, string q)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=metals;User Id=postgres;Password=123321;");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = q;
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                obj.DataSource = dt;
            }
            cmd.Dispose();
            connection.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
