using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace incidentMap
{
    public partial class CloseIncidentForm : Form
    {
        public int id_inc;

        public CloseIncidentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(Properties.Settings.Default.incidentMapConnectionString),
                CommandText = "incidentClose",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@closeDate", dtDate.Value.Date);
            cmd.Parameters.AddWithValue("@ncVerdict", txCloseNotes.Text);
            cmd.Parameters.AddWithValue("@id_inc", id_inc);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
