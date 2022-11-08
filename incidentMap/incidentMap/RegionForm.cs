using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace incidentMap
{
    public partial class RegionForm : Form
    {
        public RegionForm()
        {
            InitializeComponent();
        }

        private void RegionForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "regionDataSet.region". При необходимости она может быть перемещена или удалена.
            this.regionTableAdapter.Fill(this.regionDataSet.region);

        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            regionTableAdapter.Update(regionDataSet);
        }
    }
}
