using System;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void ButtonEntryClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_textBoxName.Text))
            {
                MessageBox.Show("名前を入力してください。");
            }
            else if (string.IsNullOrEmpty(_textBoxAddress.Text))
            {
                MessageBox.Show("住所を入力してください。");
            }
            else if (!_radioButtonMan.Checked && !_radioButtonWoman.Checked)
            {
                MessageBox.Show("性別を入力してください。");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        public EmployeeData Employee
        {
            get
            {
                return new EmployeeData()
                {
                    Name = _textBoxName.Text,
                    Address = _textBoxAddress.Text,
                    IsMan = _radioButtonMan.Checked
                };
            }
        }
    }
}
