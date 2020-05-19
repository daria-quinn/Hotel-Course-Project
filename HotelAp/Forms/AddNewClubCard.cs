using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAp.Forms
{
    public partial class Add_New_Club_Card : Form
    {
        public Add_New_Club_Card()
        {
            InitializeComponent();
        }

        private void btnCloseAddNewClubCard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string ReturnValue { get; set; }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            if (tbCardID.Text.Length != 0 && tbCardDiscount.Text.Length != 0)
            {
                ActionWithDB api = new ActionWithDB();
                if (api.checkCard(tbCardID.Text) == 0)
                {
                    this.ReturnValue = tbCardID.Text;
                    api.addCard(int.Parse(tbCardID.Text), int.Parse(tbCardDiscount.Text));
                    
                    Helper helper = new Helper();
                    helper.clearAllTextBox(tbCardID, tbCardDiscount);
                    MessageBox.Show("Новая карта успешно добавлена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Карта с таким номером зарегистирована", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
