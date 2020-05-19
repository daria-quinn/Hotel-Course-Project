using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdit_Click(object sender, EventArgs e)
        {
           if (!(tbLogin.Text.Length == 0 && tbPassword.Text.Length == 0))
            {
                Helper helper = new Helper();
                ActionWithDB api = new ActionWithDB();

                if (api.verificationLoginAdnPassword(tbLogin.Text, tbPassword.Text) == 1)
                {
                    UserForm userForm = new UserForm(tbLogin.Text);
                    userForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправльный логин или пароль", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            tbLogin.Text = "123";
            tbPassword.Text = "123";

            string addStr;
            ActionWithDB api = new ActionWithDB();
            bool flagConect = api.isVerificationConnect();
            if (flagConect)
            {
                addStr = "активно";
                btnAdit.Enabled = true;
                регистрацияToolStripMenuItem.Enabled = true;
            }
            else
            {
                addStr = "не активно";
                btnAdit.Enabled = false;
                регистрацияToolStripMenuItem.Enabled = false;
            }
            lbConnection.Text += " " + addStr;
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
