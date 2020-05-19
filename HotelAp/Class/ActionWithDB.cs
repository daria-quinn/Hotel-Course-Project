using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAp
{
    class ActionWithDB
    {
        private string connectionText = "Server=localhost\\SQLEXPRESS01;Database=Hotel_DB;Trusted_Connection=True;";
        /// <summary>
        /// проверка подключения к базе
        /// </summary>
        /// <returns></returns>
        public bool isVerificationConnect()
        {
            bool chekintConnection;
            try
            {
                SqlConnection con = new SqlConnection(connectionText);
                con.Open();
                chekintConnection = true;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chekintConnection = false;
            }
            return chekintConnection;
        }
        /// <summary>
        /// соеднинение с базой
        /// </summary>
        /// <returns></returns>
        private SqlCommand connection()
        {
            SqlConnection con = new SqlConnection(connectionText);
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            return cmd;
        }
        /// <summary>
        /// проверка и подтверждение логина и пароля в базе
        /// </summary>
        /// <param name="loginBox"></param>
        /// <param name="passwordBox"></param>
        /// <returns></returns>
        public int verificationLoginAdnPassword(string loginBox, string passwordBox)
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE verificationLoginAndPassword @Login,@Password, @Count OUTPUT";
            cmd.Parameters.Add("@Login", SqlDbType.NVarChar).Value = loginBox;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = passwordBox;
            cmd.Parameters.Add("@Count", SqlDbType.Int);
            cmd.Parameters["@Count"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int count = int.Parse(cmd.Parameters["@Count"].Value.ToString());
            return count;
        }
        public void addUser(string loginBox, string passwordBox)
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE addUser @Login,@Password";
            cmd.Parameters.Add("@Login", SqlDbType.NVarChar).Value = loginBox;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = passwordBox;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// проверка существаования такого же логина и пароля в базе
        /// </summary>
        /// <param name="loginBox"></param>
        /// <returns></returns>
        public int checkingUser(string loginBox)
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE checkingUser @Login,@Count OUTPUT";
            cmd.Parameters.Add("@Login", SqlDbType.NVarChar).Value = loginBox;
            cmd.Parameters.Add("@Count", SqlDbType.Int);
            cmd.Parameters["@Count"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int count = int.Parse(cmd.Parameters["@Count"].Value.ToString());
            return count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strCheck"></param>
        /// <returns></returns>
        public bool isChekingUserDocument(string strCheck)
        {
            bool result = false;
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE checkingDocument @Login,@Count OUTPUT";
            cmd.Parameters.Add("@Login", SqlDbType.NVarChar).Value = strCheck;
            cmd.Parameters.Add("@Count", SqlDbType.Int);
            cmd.Parameters["@Count"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int count = int.Parse(cmd.Parameters["@Count"].Value.ToString());
            if (count > 0)
            {
                result = true;
            }
            return result;

        }
        /// <summary>
        /// проверка существования отдыхающего в базе данных
        /// </summary>
        /// <param name="login"></param>
        /// <param name="passport"></param>
        /// <returns></returns>

        public bool ischeckingDocumentForPassport(string lastName, string passport)
        {
            bool result = false;
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE checkingDocumentForPassport @LastName,@Passport,@Count OUTPUT";
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastName;
            cmd.Parameters.Add("@Passport", SqlDbType.NVarChar).Value = passport;
            cmd.Parameters.Add("@Count", SqlDbType.Int);
            cmd.Parameters["@Count"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int count = int.Parse(cmd.Parameters["@Count"].Value.ToString());
            if (count > 0)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// добавление документа нового отдыхающего в базу
        /// </summary>
        /// <param name="login"></param>
        /// <param name="Name"></param>
        /// <param name="Surname"></param>
        /// <param name="MiddleName"></param>
        /// <param name="seria"></param>
        /// <param name="number"></param>

        public void addDocument(string login, string Name, string LastName, string SecondName, string passport)
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE addDocument @Login, @Passport, @FirstName, @LastName, @SecondName";
            cmd.Parameters.Add("@Login", SqlDbType.NVarChar).Value = login;
            cmd.Parameters.Add("@Passport", SqlDbType.NVarChar).Value = passport;
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
            cmd.Parameters.Add("@SecondName", SqlDbType.NVarChar).Value = SecondName;
            cmd.ExecuteNonQuery();
        }

        public int getDiscont(DateTime date, string card )
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE calculationDiscount @FirstDate, @card, @FDiscount OUTPUT";
            cmd.Parameters.Add("@FirstDate", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@card", SqlDbType.Int).Value = int.Parse(card);
            cmd.Parameters.Add("@FDiscount", SqlDbType.Int);
            cmd.Parameters["@FDiscount"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();

            int result = int.Parse(cmd.Parameters["@FDiscount"].Value.ToString());

            return result;
        }

        public SqlDataReader checkingFreeSpace(DateTime FirtstDate, DateTime secontDate)
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE checkingFreeSpace @FirstDate, @SecondDate";
            cmd.Parameters.Add("@FirstDate", SqlDbType.DateTime).Value = FirtstDate;
            cmd.Parameters.Add("@SecondDate", SqlDbType.DateTime).Value = secontDate;
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public string getTotalCost(int discont, string beginCost)
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE replaceDiscont @DISCONT, @REPLACE, @ReplaceResult OUTPUT";
            cmd.Parameters.Add("@DISCONT", SqlDbType.Money).Value = discont;
            cmd.Parameters.Add("@REPLACE", SqlDbType.Money).Value = beginCost;
            cmd.Parameters.Add("@ReplaceResult", SqlDbType.Money);
            cmd.Parameters["@ReplaceResult"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            string result = cmd.Parameters["@ReplaceResult"].Value.ToString();

            return result;
        }

        public SqlDataReader enterDocument(string login)
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE enterDocument @login";
            cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = login;
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }
        public SqlDataReader seachDocument(string passport)
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE seachDocument @passport";
            cmd.Parameters.Add("@passport", SqlDbType.NVarChar).Value = passport;
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public void addRecordInHotel(int number, string login,  string numberDocument, int discont, int cCard, DateTime BeginDate, DateTime EndDate,
            double cost, double EndCost)
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE addRecordInHotel @number, @login, @numberDocument, @discont, @clubCard, @BeginDate, @EndDate, @Cost, @EndCost";
            cmd.Parameters.Add("@number", SqlDbType.NVarChar).Value = number;
            cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = login;
            cmd.Parameters.Add("@numberDocument", SqlDbType.NVarChar).Value = numberDocument;
            cmd.Parameters.Add("@discont", SqlDbType.Int).Value = discont;
            cmd.Parameters.Add("@clubCard", SqlDbType.Int).Value = cCard;
            cmd.Parameters.Add("@BeginDate", SqlDbType.Date).Value = BeginDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.Date).Value = EndDate;
            cmd.Parameters.Add("@Cost", SqlDbType.Money).Value = cost;
            cmd.Parameters.Add("@EndCost", SqlDbType.Money).Value = EndCost;
            cmd.ExecuteNonQuery();
        }
        public SqlDataReader addCard(int cardId,int cardDiscount )
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE addCard @CardId, @DateOfIssue, @cardDiscount ";
            cmd.Parameters.Add("@CardId", SqlDbType.NVarChar).Value = cardId;
            cmd.Parameters.Add("@DateOfIssue", SqlDbType.NVarChar).Value = DateTime.Now.Date;
            cmd.Parameters.Add("@cardDiscount", SqlDbType.NVarChar).Value = cardDiscount;
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }
        public int checkCard(string CardIDBox)
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE checkCard @CardID,@Count OUTPUT";
            cmd.Parameters.Add("@CardID", SqlDbType.NVarChar).Value = CardIDBox;
            cmd.Parameters.Add("@Count", SqlDbType.Int);
            cmd.Parameters["@Count"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int count = int.Parse(cmd.Parameters["@Count"].Value.ToString());
            return count;
        }
        public int enterCard(string CardIDBox)
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE enterCard   @CardID int,@ID int  OUTPUT";
            cmd.Parameters.Add("@CardID", SqlDbType.NVarChar).Value = CardIDBox;
            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters["@ID"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int count = int.Parse(cmd.Parameters["@ID"].Value.ToString());
            return count;
        }
        public SqlDataReader addServices()
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE addServices";
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }
        public int getDiscont(int card)
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE discountForServices  @card, @FDiscount OUTPUT";
            cmd.Parameters.Add("@card", SqlDbType.Int).Value = card;
            cmd.Parameters.Add("@FDiscount", SqlDbType.Int);
            cmd.Parameters["@FDiscount"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int result = int.Parse(cmd.Parameters["@FDiscount"].Value.ToString());

            return result;
        }
        public SqlDataReader searchRecord(string passport)
        {
            SqlCommand cmd = connection();
            cmd.CommandText = "EXECUTE searchRecord @passport";
            cmd.Parameters.Add("@passport", SqlDbType.NVarChar).Value = passport;
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }
        public void addRecordOfService(int nService, int nRecord)
        {
            SqlCommand cmd = connection();
            cmd.CommandText = "EXECUTE addRecordOfService @nService, @nRecord";
            cmd.Parameters.Add("@nService", SqlDbType.NVarChar).Value = nService;
            cmd.Parameters.Add("@nRecord", SqlDbType.NVarChar).Value = nRecord;
            SqlDataReader reader = cmd.ExecuteReader();
        }
        public int getRecordID()
        {
            SqlCommand cmd = connection();
            cmd.CommandText = "EXECUTE getRecordID @nRecord  OUTPUT";
            cmd.Parameters.Add("@nRecord", SqlDbType.Int);
            cmd.Parameters["@nRecord"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int nRecord = int.Parse(cmd.Parameters["@nRecord"].Value.ToString());

            return nRecord;
        }
        public void ProofOfPurchaseInfAboutRecords(int nRecord)
        {
            SqlCommand cmd = connection();

            cmd.CommandText = "EXECUTE ProofOfPurchaseInfAboutRecords @nRecord";
            cmd.Parameters.Add("@nRecord", SqlDbType.NVarChar).Value = nRecord;
            cmd.ExecuteNonQuery();
        }
    }
}
