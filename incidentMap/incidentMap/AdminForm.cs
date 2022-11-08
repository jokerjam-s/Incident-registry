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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rolesDataSet.roles". При необходимости она может быть перемещена или удалена.
            this.rolesTableAdapter.Fill(this.rolesDataSet.roles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.usersDataSet.users);

        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Update(usersDataSet);
        }
    }
}
