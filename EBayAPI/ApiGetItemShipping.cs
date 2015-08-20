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
    public partial class ApiGetItemShipping : Form
    {
        public ApiContext apiContext;
        public ApiGetItemShipping()
        {
            InitializeComponent();
        }

        #region Event
        private void ApiGetItemShipping_Load(object sender, EventArgs e)
        {
            CboCountry.Items.Add("NoChange");

            string[] countries = Enum.GetNames(typeof(CountryCodeType));
            foreach (string cntry in countries)
            {
                if (cntry != "CustomCode")
                {
                    CboCountry.Items.Add(cntry);
                }
            }
            CboCountry.SelectedIndex = 0;
        }
        private void BtnGetItemShipping_Click(object sender, EventArgs e)
        {
            try
            {
                LstShipSvc.Items.Clear();
                TxtShipZip.Text = "";
                TxtHandlingCost.Text = "";
                TxtShipType.Text = "";
                TxtPackage.Text = "";
                TxtWeight.Text = "";

                GetItemShippingCall apicall = new GetItemShippingCall(apiContext);

                if (TxtQuantity.Text != string.Empty)
                    apicall.QuantitySold = Convert.ToInt32(TxtQuantity.Text);
                if (CboCountry.SelectedIndex != 0)
                    apicall.DestinationCountryCode = (CountryCodeType)Enum.Parse(typeof(CountryCodeType), CboCountry.SelectedItem.ToString());

                ShippingDetailsType shipdetails = apicall.GetItemShipping(TxtItemId.Text, TxtDestination.Text);
                TxtShipType.Text = shipdetails.ShippingType.ToString();

                if (shipdetails.CalculatedShippingRate != null)
                {
                    TxtShipType.Text = shipdetails.CalculatedShippingRate.OriginatingPostalCode;
                    TxtHandlingCost.Text = shipdetails.CalculatedShippingRate.PackagingHandlingCosts.Value.ToString();
                    TxtPackage.Text = shipdetails.CalculatedShippingRate.ShippingPackage.ToString();
                    TxtWeight.Text = shipdetails.CalculatedShippingRate.WeightMajor.Value.ToString() + " " + shipdetails.CalculatedShippingRate.WeightMajor.unit + " - " + shipdetails.CalculatedShippingRate.WeightMinor.Value.ToString() + " " + shipdetails.CalculatedShippingRate.WeightMinor.unit;
                }

                foreach (ShippingServiceOptionsType shipopt in shipdetails.ShippingServiceOptions)
                {
                    string[] listparams = new string[5];
                    listparams[0] = shipopt.ShippingService.ToString();
                    if (shipopt.ShippingServiceCost != null)
                    {
                        listparams[1] = shipopt.ShippingServiceCost.Value.ToString();
                    }
                    if (shipopt.ShippingInsuranceCost != null)
                    {
                        listparams[2] = shipopt.ShippingInsuranceCost.Value.ToString();
                    }
                    if (shipopt.ShippingServiceAdditionalCost != null)
                    {
                        listparams[3] = shipopt.ShippingServiceAdditionalCost.Value.ToString();
                    }

                    ListViewItem vi = new ListViewItem(listparams);
                    this.LstShipSvc.Items.Add(vi);
                }

                foreach (InternationalShippingServiceOptionsType shipopt in shipdetails.InternationalShippingServiceOption)
                {
                    string[] listparams = new string[5];
                    listparams[0] = shipopt.ShippingService.ToString();
                    if (shipopt.ShippingServiceCost != null)
                        listparams[1] = shipopt.ShippingServiceCost.Value.ToString();
                    if (shipopt.ShippingServiceAdditionalCost != null)
                        listparams[3] = shipopt.ShippingServiceAdditionalCost.Value.ToString();
                    listparams[4] = String.Join(", ", shipopt.ShipToLocation.ToArray());

                    ListViewItem vi = new ListViewItem(listparams);
                    this.LstShipSvc.Items.Add(vi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
