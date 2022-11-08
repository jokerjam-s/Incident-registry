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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            txDepart.Text = OptionsApp.department;
            txPlace.Text = OptionsApp.place;
            nPointX.Value = OptionsApp.beginX;
            nPointY.Value = OptionsApp.beginY;
            cbMap.SelectedIndex = OptionsApp.UsedMap;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OptionsApp.department = txDepart.Text;
            OptionsApp.place = txPlace.Text;
            OptionsApp.beginX = nPointX.Value;
            OptionsApp.beginY = nPointY.Value;
            OptionsApp.UsedMap = cbMap.SelectedIndex;

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(Properties.Settings.Default.incidentMapConnectionString),
                CommandText = "setOptions",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@department", OptionsApp.department);
            cmd.Parameters.AddWithValue("@place", OptionsApp.place);
            cmd.Parameters.AddWithValue("@beginX", OptionsApp.beginX);
            cmd.Parameters.AddWithValue("@beginY", OptionsApp.beginY);
            cmd.Parameters.AddWithValue("@usedMap", OptionsApp.UsedMap);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
