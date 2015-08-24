using eBay.Service.Call;
using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using EBayAPI.Entry;
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
        public Dictionary<string, object> orderDic;
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
                orderDic = new Dictionary<string, object>();
                LstOrders.Items.Clear();
                GetOrdersCall apicall = new GetOrdersCall(apiContext);
                TimeFilter fltr = new TimeFilter();
                fltr.TimeFrom = DatePickStartFrom.Value;
                fltr.TimeTo = DatePickStartTo.Value;

                OrderTypeCollection orders = apicall.GetOrders(fltr, (TradingRoleCodeType)Enum.Parse(typeof(TradingRoleCodeType), CboRole.SelectedItem.ToString()), (OrderStatusCodeType)Enum.Parse(typeof(OrderStatusCodeType), CboStatus.SelectedItem.ToString()));

                foreach (OrderType order in orders)
                {
                    OCOrder o = new OCOrder();
                    string[] listparams = new string[5];
                    listparams[0] = order.OrderID;
                    listparams[1] = order.OrderStatus.ToString();
                    listparams[2] = order.AmountSaved.Value.ToString();
                    string[] itemids = new string[order.TransactionArray.Count];
                    int index = 0;
                    foreach (TransactionType trans in order.TransactionArray)
                    {
                        itemids[index] = trans.Item.ItemID;
                        o.goods = new OCGoods() { goodsName = trans.Item.Title };
                        index++;
                    }
                    listparams[3] = string.Join(", ", itemids);
                    ListViewItem vi = new ListViewItem(listparams);
                    LstOrders.Items.Add(vi);


                    if (order.OrderID.Contains('-'))
                    {
                        o.orderNo = "EB" + order.OrderID.Split('-')[1];
                    }
                    else
                    {
                        o.orderNo = "EB" + order.OrderID;
                    }
                    o.orderAmount = order.Total.Value;
                    o.consignee = order.ShippingAddress.Name;
                    o.consigneeAddress = string.IsNullOrEmpty(order.ShippingAddress.Street) ? string.IsNullOrEmpty(order.ShippingAddress.Street1) ? order.ShippingAddress.Street2 : order.ShippingAddress.Street1 : order.ShippingAddress.Street;
                    o.consigneeTelephone = string.IsNullOrEmpty(order.ShippingAddress.Phone) ? order.ShippingAddress.Phone2 : order.ShippingAddress.Phone;
                    string consigneeCountry_Code = order.ShippingAddress.Country.ToString();//  type
                    o.consigneeCountry = order.ShippingAddress.CountryName;
                    o.consigneeProvince = order.ShippingAddress.StateOrProvince;
                    o.consigneeCity = order.ShippingAddress.CityName;
                    o.consigneeZip = order.ShippingAddress.PostalCode;
                    o.createTime = order.CreatedTime;
                    o.acttime = DateTime.Now;

                    orderDic.Add(order.OrderID, o);
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
            List<OCOrder> list = new List<OCOrder>();
            foreach (ListViewItem i in this.LstOrders.CheckedItems)
            {
                list.Add(orderDic[i.Text] as OCOrder);
            }
            ExportSql export = new ExportSql();
            export.ExportEbayOrder(list);
        }
    }
}
