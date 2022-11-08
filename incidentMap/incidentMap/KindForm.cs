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
    public partial class KindForm : Form
    {
        public KindForm()
        {
            InitializeComponent();
        }

        private void KindForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindDataSet.kind". При необходимости она может быть перемещена или удалена.
            this.kindTableAdapter.Fill(this.kindDataSet.kind);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            kindTableAdapter.Update(kindDataSet);
        }

        private void kindBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            tbSave.Enabled = (kindBindingSource.Current != null);
        }
    }
}
