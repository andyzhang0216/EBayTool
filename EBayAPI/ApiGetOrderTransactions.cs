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
    public partial class ApiGetOrderTransactions : Form
    {
        public ApiContext apiContext;
        public ApiGetOrderTransactions()
        {
            InitializeComponent();
        }

        private void BtnGetOrderTransactions_Click(object sender, EventArgs e)
        {
            GetOrderTransactionsCall apicall = new GetOrderTransactionsCall(apiContext);
            StringCollection strCol = new StringCollection();
            string[] strArr = new string[] { "291522580422-1203196191019" };
            strCol.AddRange(strArr);
            OrderTypeCollection orderDetails = apicall.GetOrderTransactions(strCol);
        }
    }
}
