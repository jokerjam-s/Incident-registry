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
    public partial class IncidentNewForm : Form
    {
        public decimal pointX;
        public decimal pointY;

        public IncidentNewForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand() 
            { 
                Connection = new SqlConnection(Properties.Settings.Default.incidentMapConnectionString),
                CommandText = "identIns",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@ncDate", dtDate.Value.Date);
            cmd.Parameters.AddWithValue("@ncSubj", txTitle.Text);
            cmd.Parameters.AddWithValue("@ncNotes", txNotes.Text);
            cmd.Parameters.AddWithValue("@ncAdres", txAdr.Text);
            cmd.Parameters.AddWithValue("@pointX", (double)nPointX.Value);
            cmd.Parameters.AddWithValue("@pointY", (double)nPointY.Value);
            cmd.Parameters.AddWithValue("@id_kn", cbKind.SelectedValue);
            cmd.Parameters.AddWithValue("@id_hd", cbHard.SelectedValue);
            cmd.Parameters.AddWithValue("@id_rg", cbRegion.SelectedValue);
            cmd.Parameters.AddWithValue("@id_us", OptionsApp.id_us);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Clone();
        }

        private void IncidentNewForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hardsDataSet.hards". При необходимости она может быть перемещена или удалена.
            this.hardsTableAdapter.Fill(this.hardsDataSet.hards);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindDataSet.kind". При необходимости она может быть перемещена или удалена.
            this.kindTableAdapter.Fill(this.kindDataSet.kind);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "regionDataSet.region". При необходимости она может быть перемещена или удалена.
            this.regionTableAdapter.Fill(this.regionDataSet.region);
            nPointX.Value = pointX;
            nPointY.Value = pointY;
        }
    }
}
