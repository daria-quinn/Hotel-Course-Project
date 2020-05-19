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
    public partial class RecordCheck : Form
    {
        string login;
        string surname;
        string name;
        string SName;
        double price;
        int discount;
        double priceInDiscount;
        string document;
        string typeNumber;
        int number;
        DateTime dateBegin;
        DateTime dateEnd;
        int cCard;
        public RecordCheck(string login,  string surname, string name, string SName, double price, int discount,
           double priceInDiscount, string document, string typeNumber, int number, DateTime dateBegin, DateTime dateEnd, int cCard)
        {
            this.login = login;
            this.surname = surname;
            this.name = name;
            this.SName = SName;
            this.price = price;
            this.discount = discount;
            this.priceInDiscount = priceInDiscount;
            this.document = document;
            this.dateBegin = dateBegin;
            this.dateEnd = dateEnd;
            this.number = number;
            this.typeNumber = typeNumber;
            this.cCard = cCard;
            InitializeComponent();
        }

        private void RecordCheck_Load(object sender, EventArgs e)
        {
            lbLogin.Text = "Логин: " + login;
            lbFirstName.Text = "Имя: " + name;
            lbSecondName.Text = "Отчество: " + SName;
            lbLastName.Text = "Фамилия: " + surname;
            lbPassport.Text = "Паспорт: " + document;
            lbCost.Text = "Цена: " + price +" рублей";
            lbDiscount.Text = "Скидка: " + discount+" %";
            lbCostWithDiscount.Text = "Цена со скидкой: " + priceInDiscount + " рублей";
            lbHotelNumber.Text = "Номер: " + number;
            lbNumberType.Text = "Тип отеля: " + typeNumber;
            lbStartDate.Text = "Дата въезда: " + dateBegin;
            lbEndDate.Text = "Дата выезда: " + dateEnd;
            lbClubCard.Text = "Номер клубной карты: " + cCard;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            ActionWithDB api = new ActionWithDB();
            api.addRecordInHotel(number, login, document, discount, cCard, dateBegin, dateEnd, price, priceInDiscount);
            MessageBox.Show("Номер успешно куплен на дату с " + dateBegin.Date.ToString() + " по " + dateEnd.Date.ToString(), "Успешно", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCashVoucher_Click(object sender, EventArgs e)
        {
            Forms.CashVoucher cashVoucher = new Forms.CashVoucher();
            cashVoucher.Show();
        }
    }
}
