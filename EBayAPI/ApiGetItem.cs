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
    public partial class ApiGetItem : Form
    {
        public ApiContext apiContext;
        public string a_itemId;
        private ItemType fetchedItem;
        public ApiGetItem()
        {
            InitializeComponent();
        }

        #region Private Method
        private static CallRetry GetCallRetry()
        {
            CallRetry retry = new CallRetry();
            retry.DelayTime = 1000;
            retry.MaximumRetries = 2;
            retry.TriggerHttpStatusCodes = new Int32Collection();
            retry.TriggerHttpStatusCodes.Add(502);
            retry.TriggerHttpStatusCodes.Add(404);
            return retry;
        }
        #endregion

        #region Event
        private void ApiGetItem_Load(object sender, EventArgs e)
        {
            TxtItemId.Text = a_itemId;
        }

        #endregion

        private void BtnGetItem_Click(object sender, EventArgs e)
        {
            try
            {
                TxtTitle.Text = "";
                TxtCategory.Text = "";
                TxtCategory2.Text = "";
                TxtCurrentPrice.Text = "";
                TxtBuyItNowPrice.Text = "";
                TxtBidCount.Text = "";
                TxtHighBidder.Text = "";
                TxtStartTime.Text = "";
                TxtEndTime.Text = "";
                TxtQuantity.Text = "";
                TxtQuantitySold.Text = "";
                LblItemIdResult.Text = "";
                TxtCategory2Id.Text = "";
                TxtCategoryId.Text = "";

                apiContext.CallRetry = GetCallRetry();

                GetItemCall apicall = new GetItemCall(apiContext);
                apicall.DetailLevelList.Add(DetailLevelCodeType.ReturnAll);
                fetchedItem = apicall.GetItem(TxtItemId.Text);

                TxtTitle.Text = fetchedItem.Title;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
