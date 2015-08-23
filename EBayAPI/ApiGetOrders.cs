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
    public partial class ApiGetOrders : Form
    {
        public ApiContext apiContext;
        public ApiGetOrders()
        {
            InitializeComponent();
        }
        #region Event
        private void ApiGetOrders_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DatePickStartTo.Value = now;
            DatePickStartFrom.Value = now.AddDays(-5);

            string[] roles = Enum.GetNames(typeof(TradingRoleCodeType));
            foreach (string rl in roles)
            {
                if (rl != "CustomCode")
                {
                    CboRole.Items.Add(rl);
                }
            }
            CboRole.SelectedIndex = 0;
            string[] statie = Enum.GetNames(typeof(OrderStatusCodeType));
            foreach (string stat in statie)
            {
                if (stat != "CustomCode")
                {
                    CboStatus.Items.Add(stat);
                }
            }
            CboStatus.SelectedIndex = 0;
        }
        private void BtnGetOrders_Click(object sender, EventArgs e)
        {
            try
            {
                LstOrders.Items.Clear();
                GetOrdersCall apicall = new GetOrdersCall(apiContext);
                TimeFilter fltr = new TimeFilter();
                fltr.TimeFrom = DatePickStartFrom.Value;
                fltr.TimeTo = DatePickStartTo.Value;

                OrderTypeCollection orders = apicall.GetOrders(fltr, (TradingRoleCodeType)Enum.Parse(typeof(TradingRoleCodeType), CboRole.SelectedItem.ToString()), (OrderStatusCodeType)Enum.Parse(typeof(OrderStatusCodeType), CboStatus.SelectedItem.ToString()));

                foreach (OrderType order in orders)
                {
                    string orderId = "EB" + order.OrderID.Split('-')[0];
                    double orderAmount = order.Total.Value;

                    string consignee = order.ShippingAddress.Name;
                    //string consigneeAddress = order.ShippingAddress.AddressID;
                    string consigneeTelephone = string.IsNullOrEmpty(order.ShippingAddress.Phone) ? order.ShippingAddress.Phone2 : order.ShippingAddress.Phone;

                    string consigneeCountry_Code = order.ShippingAddress.Country.ToString();//  type
                    string consigneeCountry = order.ShippingAddress.CountryName;
                    string consigneeProvince = order.ShippingAddress.StateOrProvince;
                    string consigneeCity = order.ShippingAddress.CityName;
                    string consigneeZip = order.ShippingAddress.PostalCode;
                    DateTime createTime = order.CreatedTime;
                    
                    string[] listparams = new string[5];
                    listparams[0] = order.OrderID;
                    listparams[1] = order.OrderStatus.ToString();
                    listparams[2] = order.CreatingUserRole.ToString();
                    listparams[3] = order.AmountSaved.Value.ToString();
                    string[] itemids = new string[order.TransactionArray.Count];
                    int index = 0;
                    foreach (TransactionType trans in order.TransactionArray)
                    {
                        itemids[index] = trans.Item.ItemID;
                        index++;
                    }
                    listparams[4] = string.Join(", ", itemids);
                    ListViewItem vi = new ListViewItem(listparams);
                    LstOrders.Items.Add(vi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void BtnExport_Click(object sender, EventArgs e)
        {


        }
    }
}
