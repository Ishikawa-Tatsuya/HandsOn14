using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            using (var form = new AddForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    _listBoxEmployee.Items.Add(form.Employee);
                }
            }
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {
            using (var form = new SearchForm(_listBoxEmployee.Items.Cast<EmployeeData>()))
            {
                form.ShowDialog(this);
            }
        }
    }
}
