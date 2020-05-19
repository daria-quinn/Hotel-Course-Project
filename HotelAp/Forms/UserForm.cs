using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAp
{
    public partial class UserForm : Form
    {
        string loginUser;
        public UserForm()
        {
            InitializeComponent();
        }
        public UserForm(string loginUser)
        {
            this.loginUser = loginUser;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            dGVFreePlace.RowHeadersVisible = false;
            this.Text = "Вы зашли под логином - " + loginUser;
            ActionWithDB api = new ActionWithDB();
            if (!api.isChekingUserDocument(loginUser))
            {
                MessageBox.Show("Отсутстует паспорт у пользователя - " + loginUser, "Добавьте паспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SqlDataReader reader = api.enterDocument(loginUser);

            while (reader.Read())
            {
                cbChoosePassrport.Items.Add(reader[0].ToString() + " " );
            }

        }

        private void добавитьПаспортToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DocumentAdd documentAdd = new DocumentAdd(loginUser);
            documentAdd.ShowDialog();
            cbChoosePassrport.Items.Clear();
            ActionWithDB api = new ActionWithDB();
            SqlDataReader reader = api.enterDocument(loginUser);

            while (reader.Read())
            {
                cbChoosePassrport.Items.Add(reader[0].ToString());
            }
        }


        public void updateTable()
        {
            DateTime date = DateTime.Now;
            if (dtStartDate.Value.Date < dtEndDate.Value.Date && dtStartDate.Value.Date >= date)
            {
                Helper helper = new Helper();
                ActionWithDB api = new ActionWithDB();
                SqlDataReader reader = api.checkingFreeSpace(dtStartDate.Value.Date, dtEndDate.Value.Date);
                if (tbClubCard.Text != "")
                {
                    int  discont = api.getDiscont(dtStartDate.Value.Date, tbClubCard.Text);
                    helper.clearDataGridView(dGVFreePlace);
                    int i = 0;
                    while (reader.Read())
                    {
                        dGVFreePlace.RowCount++;
                        dGVFreePlace.Rows[i].Cells[0].Value = reader[0].ToString();
                        dGVFreePlace.Rows[i].Cells[1].Value = reader[1].ToString();
                        dGVFreePlace.Rows[i].Cells[2].Value = reader[2].ToString();
                        dGVFreePlace.Rows[i].Cells[3].Value = discont;
                        dGVFreePlace.Rows[i].Cells[4].Value = api.getTotalCost(discont, dGVFreePlace.Rows[i].Cells[2].Value.ToString());
                        i++;
                    }
                }
                 
            }
            else
            {
                Helper helper = new Helper();
                helper.clearDataGridView(dGVFreePlace);
            }
        }
        public void updateTableService()
        {
            DateTime date = DateTime.Now;
            if (dtStartDate.Value.Date <= dtEndDate.Value.Date && dtStartDate.Value.Date >= date)
            {
                Helper helper = new Helper();
                ActionWithDB api = new ActionWithDB();
                SqlDataReader reader = api.addServices();
                if (tbClubCard.Text != "")
                {
                    int Ccard = Int32.Parse(tbClubCard.Text);
                    int discont = api.getDiscont(Ccard);

                    helper.clearDataGridView(dGVServices);
                    int i = 0;
                    while (reader.Read())
                    {
                        dGVServices.RowCount++;
                        dGVServices.Rows[i].Cells[0].Value = reader[0].ToString();
                        dGVServices.Rows[i].Cells[1].Value = reader[1].ToString();
                        dGVServices.Rows[i].Cells[2].Value = reader[2].ToString();
                        dGVServices.Rows[i].Cells[3].Value = discont;
                        dGVServices.Rows[i].Cells[4].Value = api.getTotalCost(discont, dGVServices.Rows[i].Cells[2].Value.ToString());
                        i++;
                    }
                }
            }
            else
            {
                Helper helper = new Helper();
                helper.clearDataGridView(dGVFreePlace);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btDrop_Click(object sender, EventArgs e)
        {

            tbRangeStart.Text = "";
            tbRangEnd.Text = "";
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (dGVFreePlace.RowCount != 0)
            {
                DateTime date = DateTime.Now;
                if (dtStartDate.Value.Date < dtEndDate.Value.Date && dtStartDate.Value.Date >= date)
                {
                    if (tbRangeStart.Text.Length != 0 && tbRangEnd.Text.Length != 0)
                    {
                        double BeginPrice = double.Parse(tbRangeStart.Text);
                        double EndPrice = double.Parse(tbRangEnd.Text);
                        Helper helper = new Helper();
                        helper.seachDateGridView(dGVFreePlace, BeginPrice, EndPrice);
                    }
                    else
                    {
                        MessageBox.Show("Нет фильтров", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Некорректная дата", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Некорректно выбран фильтр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtStartDate_ValueChanged(object sender, EventArgs e)
        {
            updateTable();
            updateTableService();
        }

        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {
            updateTable();
            updateTableService();
        }

        private void tbClubCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbChoosePassrport_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionWithDB api = new ActionWithDB();
            string str = cbChoosePassrport.Text;
            string passport = str.Substring(0, 10);
            SqlDataReader reader = api.seachDocument(passport);
            while (reader.Read())
            {
                lbSurname.Text = "Surname(Фамилия): " + reader[1];
                lbName.Text = "Name(Имя): " + reader[0];
                lbSName.Text = "Second Name(Отчество): " + reader[2];
            }
        }

        private void tbRangEnd_TextChanged(object sender, EventArgs e)
        {
            if (tbRangeStart.Text.Length == 0 && tbRangEnd.Text.Length == 0)
            {
                updateTable();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btCountFreePlace_Click(object sender, EventArgs e)
        {
            if (dGVFreePlace.RowCount != 0)
            {
                Helper helper = new Helper();
                int countFreeSpace = helper.replaceFreeSpace(dGVFreePlace);
                MessageBox.Show("Количество свободных номеров с учетом всех фильтров = " + countFreeSpace.ToString(), "Номера", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите дату", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void сортироватьПоЦенеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            helper.sortByPrice(dGVFreePlace);
        }

        private void btnCheckAndBuy_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now;
            if (dtStartDate.Value.Date < dtEndDate.Value.Date && dtStartDate.Value.Date >= date)
            {
                if (cbChoosePassrport.Text.Length != 0)
                {
                    string name = "";
                    string SName = "";
                    string surname = "";
                    string str = cbChoosePassrport.Text;
                    string passport = str.Substring(0, 10);
                    int Ccard = Int32.Parse(tbClubCard.Text);
                    ActionWithDB api = new ActionWithDB();
                    SqlDataReader reader = api.seachDocument(passport);
                    while (reader.Read())
                    {
                        surname = reader[1].ToString();
                        name = reader[0].ToString();
                        SName = reader[2].ToString();
                        
                    }
                    int index = dGVFreePlace.CurrentRow.Index;
                    string price = dGVFreePlace.Rows[index].Cells[2].Value.ToString();
                    string discount = dGVFreePlace.Rows[index].Cells[3].Value.ToString();
                    string priceDiscount = dGVFreePlace.Rows[index].Cells[4].Value.ToString();
                    string typeNumber = dGVFreePlace.Rows[index].Cells[1].Value.ToString();
                    string numberHostel = dGVFreePlace.Rows[index].Cells[0].Value.ToString();

                    RecordCheck recordCheck = new RecordCheck(loginUser, surname, name, SName, Double.Parse(price), int.Parse(discount),
                        Double.Parse(priceDiscount), passport, typeNumber, int.Parse(numberHostel), dtStartDate.Value.Date, dtEndDate.Value.Date, Ccard);
                    recordCheck.ShowDialog();
                    updateTable();
                }
                else
                {
                    MessageBox.Show("Выберите паспорт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выбранная дата некорректна", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьКлубнуюКартуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Add_New_Club_Card addNewClubCard = new Forms.Add_New_Club_Card();
            addNewClubCard.ShowDialog();
            tbClubCard.Text = addNewClubCard.ReturnValue;
            updateTable();
            updateTableService();

        }

        private void tbClubCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbClubCard.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    updateTable();
                    updateTableService();
                }
            }
        }

        private void btnGetService_Click(object sender, EventArgs e)
        {
                if (cbChoosePassrport.Text.Length != 0)
                {
                    string nRecords = "";
                    string str = cbChoosePassrport.Text;
                    string passport = str.Substring(0, 10);
                    ActionWithDB api = new ActionWithDB();
                    SqlDataReader reader = api.searchRecord(passport);
                    while (reader.Read())
                    {
                        nRecords = reader[0].ToString();
                    }
                    int NRecord = int.Parse(nRecords);
                    int index = dGVServices.CurrentRow.Index;
                    string nService = dGVServices.Rows[index].Cells[0].Value.ToString();
                    int NService = int.Parse(nService);

                    api.addRecordOfService(NService, NRecord);
                    MessageBox.Show("Услуги приобретена успешно!", "Успешно", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Выберите паспорт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
}
