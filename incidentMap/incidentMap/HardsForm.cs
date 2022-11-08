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
    public partial class HardsForm : Form
    {
        public HardsForm()
        {
            InitializeComponent();
        }

        private void HardsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flagsDataSet.flags". При необходимости она может быть перемещена или удалена.
            this.flagsTableAdapter.Fill(this.flagsDataSet.flags);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hardsDataSet.hards". При необходимости она может быть перемещена или удалена.
            this.hardsTableAdapter.Fill(this.hardsDataSet.hards);

        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            hardsTableAdapter.Update(hardsDataSet);
        }
    }
}
