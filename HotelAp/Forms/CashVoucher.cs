using Microsoft.Reporting.WebForms;
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

namespace HotelAp.Forms
{
    public partial class CashVoucher : Form
    {
        public int nRecord;
        public CashVoucher(int nRecord) {
            this.nRecord = nRecord;
            InitializeComponent();
        }

        private void CashVoucher_Load(object sender, EventArgs e)
        {
            ActionWithDB api = new ActionWithDB();
            int nRecord = api.getRecordID();
            api.ProofOfPurchaseInfAboutRecords(nRecord);
            ReportParameter[] parametrs = new ReportParameter[1];
            parametrs[0] = new ReportParameter("ReportParametrnRecord", nRecord.ToString());
            //reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParametrnRecord", nRecord.ToString()));

            this.reportViewer1.RefreshReport();
        }
    }
}
