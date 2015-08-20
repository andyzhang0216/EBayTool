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
                TxtCategory.Text = fetchedItem.PrimaryCategory.CategoryName;
                TxtCategoryId.Text = fetchedItem.PrimaryCategory.CategoryID;

                if (fetchedItem.SecondaryCategory != null)
                {
                    TxtCategory2.Text = fetchedItem.SecondaryCategory.CategoryName;
                    TxtCategory2Id.Text = fetchedItem.BuyItNowPrice.Value.ToString();
                }

                TxtCurrentPrice.Text = fetchedItem.SellingStatus.CurrentPrice.Value.ToString();
                TxtBuyItNowPrice.Text = fetchedItem.BuyItNowPrice.Value.ToString();
                TxtBidCount.Text = fetchedItem.SellingStatus.BidCount.ToString();

                if (fetchedItem.SellingStatus.HighBidder != null)
                {
                    TxtHighBidder.Text = fetchedItem.SellingStatus.HighBidder.UserID;
                }

                TxtStartTime.Text = fetchedItem.ListingDetails.StartTime.ToString();
                TxtEndTime.Text = fetchedItem.ListingDetails.EndTime.ToString();
                TxtQuantity.Text = fetchedItem.Quantity.ToString();
                TxtQuantitySold.Text = fetchedItem.SellingStatus.QuantitySold.ToString();

                TxtBestOfferCount.Text = "0";
                TxtBestOfferEnabled.Text = "False";

                if (fetchedItem.BestOfferDetails != null)
                {
                    TxtBestOfferCount.Text = fetchedItem.BestOfferDetails.BestOfferCount.ToString();
                    TxtBestOfferEnabled.Text = fetchedItem.BestOfferDetails.BestOfferEnabled.ToString();
                }

                if (fetchedItem.PayPalEmailAddress != null)
                {
                    TxtPayPalEmailAddress.Text = fetchedItem.PayPalEmailAddress.ToString();
                }

                if (fetchedItem.ApplicationData != null)
                {
                    TxtApplicationData.Text = fetchedItem.ApplicationData.ToString();
                }

                if (fetchedItem.ProductListingDetails != null)
                {
                    TxtProductID.Text = fetchedItem.ProductListingDetails.ProductID;
                }

                TxtPictureURL.Text = "";
                if (fetchedItem.PictureDetails != null)
                {
                    StringCollection pictureUrls = fetchedItem.PictureDetails.PictureURL;
                    string pictureUrl = "";
                    for (int i = 0; pictureUrls != null && i < pictureUrls.Count; i++)
                    {
                        pictureUrl += pictureUrls[i] + ",";
                    }
                    TxtPictureURL.Text = pictureUrl;
                }
                TxtSite.Text = fetchedItem.Site.ToString();

                TxtListType.Text = fetchedItem.ListingType.ToString();
                a_itemId = fetchedItem.ItemID;
                LblItemIdResult.Text = "Item Id: " + fetchedItem.ItemID;

                if (LblItemIdResult.Text.Length > 0)
                {
                    BtnRelistItem.Visible = true;
                    BtnReviseItem.Visible = true;
                    BtnEndItem.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void BtnRelistItem_Click(object sender, EventArgs e)
        {
            ApiReListItem form = new ApiReListItem();
            form.a_itemId = a_itemId;
            form.apiContext = apiContext;
            form.ShowDialog();
        }

        private void BtnReviseItem_Click(object sender, EventArgs e)
        {
            ApiReListItem form = new ApiReListItem();
            form.a_itemId = a_itemId;
            form.apiContext = apiContext;
            form.ShowDialog();
        }
        private void BtnEndItem_Click(object sender, EventArgs e)
        {
            ApiEndItem form = new ApiEndItem();
            form.a_itemId = a_itemId;
            form.apiContext = apiContext;
            form.ShowDialog();
        }
    }
}
