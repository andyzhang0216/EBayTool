using eBay.Service.Call;
using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using eBay.Service.Util;
using Samples.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EBayAPI
{
    public partial class ApiAccount : Form
    {
        public ApiContext apiContext;
        public ApiAccount()
        {
            InitializeComponent();
            SetFormStartPosition();
        }

        #region Private Method
        private void SetFormStartPosition()
        {
            this.StartPosition = FormStartPosition.CenterParent;
        }
        private void SetBindings()
        {
            TxtDeveloper.DataBindings.Clear();
            TxtApplication.DataBindings.Clear();
            TxtCertificate.DataBindings.Clear();
            TxtUrl.DataBindings.Clear();
            TxtSignInUrl.DataBindings.Clear();
            TxtEPSUrl.DataBindings.Clear();
            TxtVersion.DataBindings.Clear();
            TxtTimeOut.DataBindings.Clear();

            ChkEnableLog.DataBindings.Clear();
            ChkLogExceptions.DataBindings.Clear();
            ChkLogMessages.DataBindings.Clear();
            TxtLogFile.DataBindings.Clear();

            TxtDeveloper.DataBindings.Add("Text", apiContext.ApiCredential.ApiAccount, "Developer");
            TxtApplication.DataBindings.Add("Text", apiContext.ApiCredential.ApiAccount, "Application");
            TxtCertificate.DataBindings.Add("Text", apiContext.ApiCredential.ApiAccount, "Certificate");
            TxtToken.DataBindings.Add("Text", apiContext.ApiCredential, "eBayToken");
            TxtVersion.DataBindings.Add("Text", apiContext, "Version");
            TxtTimeOut.DataBindings.Add("Text", apiContext, "Timeout");
            txtRulName.DataBindings.Add("Text", apiContext, "RuleName");

            TxtUrl.DataBindings.Add("Text", apiContext, "SoapApiServerUrl");
            TxtSignInUrl.DataBindings.Add("Text", apiContext, "SignInUrl");
            TxtEPSUrl.DataBindings.Add("Text", apiContext, "EPSServerUrl");

            ChkEnableLog.DataBindings.Add("Checked", apiContext.ApiLogManager, "EnableLogging");
            ChkLogMessages.DataBindings.Add("Checked", apiContext.ApiLogManager, "LogApiMessages");
            ChkLogExceptions.DataBindings.Add("Checked", apiContext.ApiLogManager, "LogExceptions");

            FileLogger logfile = (FileLogger)apiContext.ApiLogManager.ApiLoggerList.ItemAt(0);
            TxtLogFile.DataBindings.Add("Text", logfile, "FileName");
        }
        private void RelplaceConfigSettings()
        {
            XmlDocument xdoc = new XmlDocument();
            AppDomain myDomain = System.AppDomain.CurrentDomain;
            string sFileName = myDomain.SetupInformation.ConfigurationFile;
            try
            {
                AppSettingHelper.SetAppSetting(AppSettingHelper.DEV_ID, apiContext.ApiCredential.ApiAccount.Developer);
                AppSettingHelper.SetAppSetting(AppSettingHelper.APP_ID, apiContext.ApiCredential.ApiAccount.Application);
                AppSettingHelper.SetAppSetting(AppSettingHelper.CERT_ID, apiContext.ApiCredential.ApiAccount.Certificate);
                //annotated by peter
                //AppSettingHelper.SetAppSetting(AppSettingHelper.EBAY_USER, Context.ApiCredential.eBayAccount.UserName);
                //AppSettingHelper.SetAppSetting(AppSettingHelper.EBAY_PASSWORD, Context.ApiCredential.eBayAccount.Password);
                AppSettingHelper.SetAppSetting(AppSettingHelper.API_TOKEN, apiContext.ApiCredential.eBayToken);
                AppSettingHelper.SetAppSetting(AppSettingHelper.API_SERVER_URL, apiContext.SoapApiServerUrl);
                AppSettingHelper.SetAppSetting(AppSettingHelper.SIGNIN_URL, apiContext.SignInUrl);
                AppSettingHelper.SetAppSetting(AppSettingHelper.EPS_SERVER_URL, apiContext.EPSServerUrl);
                AppSettingHelper.SetAppSetting(AppSettingHelper.VERSION, apiContext.Version);
                AppSettingHelper.SetAppSetting(AppSettingHelper.TIME_OUT, apiContext.Timeout.ToString());
                AppSettingHelper.SetAppSetting(AppSettingHelper.LOG_FILE_NAME,
                                    ((FileLogger)(apiContext.ApiLogManager.ApiLoggerList.ItemAt(0))).FileName);
                AppSettingHelper.SaveAppSettings();

            }
            catch (Exception ex)
            {
#if DEBUG
                System.Windows.Forms.MessageBox.Show("replaceConfigSettings()" + ex.Message);
#else
                System.Windows.Forms.MessageBox.Show("Unable to save changes"); 
#endif
                xdoc = null;
            }
        }
        private bool ValidateApiAccount(ApiContext apiContext)
        {
            eBay.Service.Core.Sdk.ApiAccount acc = apiContext.ApiCredential.ApiAccount;
            if (acc == null || acc.Application.Length == 0 || acc.Certificate.Length == 0 || acc.Developer.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Event
        private void APIAccount_Load(object sender, EventArgs e)
        {
            if (apiContext == null)
            {
                apiContext = AppSettingHelper.GetApiContext();
                apiContext.ApiLogManager = new ApiLogManager();
                LoggingProperties logProps = AppSettingHelper.GetLoggingProperties();
                apiContext.ApiLogManager.ApiLoggerList.Add(new FileLogger(logProps.LogFileName, true, true, true));
                apiContext.ApiLogManager.EnableLogging = true;
                apiContext.Site = SiteCodeType.US;
            }
            string[] sites = Enum.GetNames(typeof(SiteCodeType));
            foreach (string site in sites)
            {
                if (site != "CustomCode")
                {
                    CboSite.Items.Add(site);
                }
            }
            string[] langs = Enum.GetNames(typeof(ErrorLanguageCodeType));
            foreach (string lang in langs)
            {
                if (lang != "CustomCode")
                {
                    CboLanguage.Items.Add(lang);
                }
            }
            CboSite.SelectedIndex = 0;

            SetBindings();
        }
        private void BtnContinue_Click(object sender, EventArgs e)
        {
            RelplaceConfigSettings();
        }
        private void BtnGenerateSID_Click(object sender, EventArgs e)
        {
            if (!ValidateApiAccount(apiContext))
            {

            }
        }
        private void TxtSessionID_TextChanged(object sender, EventArgs e)
        {
            LblSidLength.Text = TxtSessionID.Text.Length.ToString();
        }
        private void BtnFetchToken_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtSessionID.Text.Length == 0)
                {
                    MessageBox.Show("Please retrieve a SessionID first, then launch Sign-In, before fetch token!");
                    return;
                }
                FetchTokenCall ftc = new FetchTokenCall(apiContext);
                apiContext.ApiCredential.eBayToken = ftc.FetchToken(TxtSessionID.Text);
                this.TabSettings.SelectedTab = this.TabPageCredentials;
                TxtToken.Text = apiContext.ApiCredential.eBayToken;
                TxtToken.Focus();
            }
            catch (ApiException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnLaunchBrowserWithSecret_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TxtSessionID.Text.Length == 0)
                {
                    MessageBox.Show("Please retrieve a SessionID frist!");
                    return;
                }
                SdkUtility.LaunchSignInPage(apiContext, TxtSessionID.Text);
            }
            catch (SdkException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ChkEnableLog_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                ChkLogMessages.Enabled = true;
                ChkLogExceptions.Enabled = true;
                TxtLogFile.Enabled = true;
                BtnLogFile.Enabled = true;
            }
            else
            {
                ChkLogMessages.Enabled = false;
                ChkLogExceptions.Enabled = false;
                TxtLogFile.Enabled = false;
                BtnLogFile.Enabled = false;
            }
        }
        private void BtnLogFile_Click(object sender, EventArgs e)
        {
            DlgSaveLog.ShowDialog();
        }
        private void DlgSaveLog_FileOk(object sender, CancelEventArgs e)
        {
            TxtLogFile.Text = DlgSaveLog.FileName;
        }
        private void CboSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            apiContext.Site = (SiteCodeType)Enum.Parse(typeof(SiteCodeType), CboSite.Text);
            ErrorLanguageCodeType lang = ErrorLanguageUtility.GetDefaultErrorLanguageCodeType(apiContext.Site);
            CboLanguage.SelectedIndex = CboLanguage.Items.IndexOf(lang.ToString());
        }
        #endregion

        private void CboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            apiContext.ErrorLanguage = (ErrorLanguageCodeType)Enum.Parse(typeof(ErrorLanguageCodeType), CboLanguage.Text);
        }
    }
}
