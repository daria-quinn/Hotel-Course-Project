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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           if (tbLogin.Text.Length != 0 && tbPassword.Text.Length != 0 && tbRePassword.Text.Length != 0)
            {
                if (!tbLogin.Text.Contains("@"))
                {
                    ActionWithDB api = new ActionWithDB();
                    if (api.checkingUser(tbLogin.Text) == 0)
                    {
                        if (tbPassword.Text == tbRePassword.Text)
                        {
                            api.addUser(tbLogin.Text, tbPassword.Text);
                            Helper helper = new Helper();
                            helper.clearAllTextBox(tbLogin, tbPassword, tbRePassword);
                            MessageBox.Show("Регистрация прошла успешна", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        else
                        {
                            MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином зарегестрирован", "Ошибка"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Имееться спец символ '@'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

