using eBay.Service.Call;
using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBayAPI
{
    public partial class ApiGetItemTransactions : Form
    {
        public ApiContext apiContext;
        public ApiGetItemTransactions()
        {
            InitializeComponent();
        }

        private void ApiGetItemTransactions_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DatePickModTo.Value = now;
            DatePickModFrom.Value = now.AddDays(-5);
        }

        private void BtnGetItemTransactions_Click(object sender, EventArgs e)
        {
            try
            {
                LstTransactions.Items.Clear();

                GetItemTransactionsCall apicall = new GetItemTransactionsCall(apiContext);

                TransactionTypeCollection transactions = apicall.GetItemTransactions(TxtItemId.Text, DatePickModFrom.Value, DatePickModTo.Value);

                if (transactions.Count == 0)
                {
                    MessageBox.Show("There is no transaction");
                    return;
                }

                foreach (TransactionType trans in transactions)
                {
                    string[] listparams = new string[6];
                    listparams[0] = trans.TransactionID;
                    listparams[1] = trans.TransactionPrice.Value.ToString();
                    listparams[2] = trans.AmountPaid.Value.ToString();
                    listparams[3] = trans.QuantityPurchased.ToString();
                    listparams[4] = trans.Buyer.UserID;
                    listparams[5] = trans.BestOfferSale.ToString();

                    ListViewItem vi = new ListViewItem(listparams);
                    LstTransactions.Items.Add(vi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSendInvoice_Click(object sender, EventArgs e)
        {
            //FrmSendInvoice form = new FrmSendInvoice();
            //form.mItemID = TxtItemId.Text;
            //form.Context = Context;
            //form.ShowDialog();
        }
    }
}
