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
    public partial class DocumentAdd : Form
    {
        string login;
        public DocumentAdd(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
           if (tbFirstName.Text.Length != 0 && tbLastName.Text.Length != 0 && tbPassport.Text.Length != 0)
            {
                ActionWithDB api = new ActionWithDB();
                if (!api.ischeckingDocumentForPassport(tbLastName.Text, tbPassport.Text))
                {
                    api.addDocument(login, tbLastName.Text, tbFirstName.Text, tbSecondName.Text, tbPassport.Text);
                    Helper helper = new Helper();
                    helper.clearAllTextBox(tbLastName, tbFirstName , tbSecondName, tbPassport);
                    MessageBox.Show("Добавлено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка", "Такие данные существуют", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка", "Не заполненные поля ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
}
