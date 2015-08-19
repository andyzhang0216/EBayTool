using eBay.Service.Core.Sdk;
using eBay.Service.Util;
using Samples.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBayAPI
{
    public partial class APIMain : Form
    {
        public ApiContext apiContext;
        public APIMain()
        {
            InitializeComponent();
            AddCommandToListBox("GetOrders", typeof(ApiGetOrders));

            SetFormStartPosition();
        }

        #region Private Method
        private void AddCommandToListBox(string commandName, System.Type formType)
        {
            this.APICallListBox.Items.Add(new CommandListBoxEntry(commandName, formType));
        }
        private void SetFormStartPosition()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private ExceptionFilter GetExceptionFilter(LoggingProperties logProps)
        {
            if (logProps.LogPayloadErrorCodes == null && logProps.LogPayloadExceptions == null && logProps.LogPayloadHttpStatusCodes == null)
                return null;
            else
                return new ExceptionFilter(logProps.LogPayloadErrorCodes, logProps.LogPayloadExceptions, logProps.LogPayloadHttpStatusCodes);
        }
        private void SetProxy()
        {
            IWebProxy proxy = null;
            string proxyHost = ConfigurationManager.AppSettings.Get("Proxy.Host");
            string proxyPort = ConfigurationManager.AppSettings.Get("Proxy.Port");
            if (proxyHost.Length > 0 && proxyPort.Length > 0)
            {
                proxy = new WebProxy(proxyHost, int.Parse(proxyPort));

                string username = ConfigurationManager.AppSettings.Get("Proxy.Username");
                string password = ConfigurationManager.AppSettings.Get("Proxy.Password");
                if (username.Length > 0 && password.Length > 0)
                {
                    proxy.Credentials = new NetworkCredential(username, password);
                }
            }
            apiContext.WebProxy = proxy;
        }
        private void RunSelectedCommand()
        {
            CommandListBoxEntry commandListBoxEntry = (CommandListBoxEntry)this.APICallListBox.SelectedItem;
            if (commandListBoxEntry != null)
            {
                System.Type formType = commandListBoxEntry.FormType;
                System.Reflection.ConstructorInfo ci = formType.GetConstructor(System.Type.EmptyTypes);
                using (Form form = (Form)ci.Invoke(null))
                {
                    form.GetType().GetField("apiContext").SetValue(form, apiContext);
                    form.ShowDialog();
                }
            }
        }
        #endregion


        #region Event
        private void APIMain_Load(object sender, EventArgs e)
        {
            apiContext = AppSettingHelper.GetApiContext();
            apiContext.ApiLogManager = new ApiLogManager();
            LoggingProperties logProps = AppSettingHelper.GetLoggingProperties();
            apiContext.ApiLogManager.ApiLoggerList.Add(new FileLogger(logProps.LogFileName, true, true, true));
            apiContext.ApiLogManager.EnableLogging = true;
            apiContext.ApiLogManager.MessageLoggingFilter = GetExceptionFilter(logProps);
            apiContext.Site = eBay.Service.Core.Soap.SiteCodeType.US;

            SetProxy();
        }
        private void BtnAccountSettings_Click(object sender, EventArgs e)
        {
            APIAccount form = new APIAccount();
            form.apiContext = apiContext;
            if (form.ShowDialog() == DialogResult.OK)
                apiContext = form.apiContext;
        }
        private void APICallListBox_DoubleClick(object sender, EventArgs e)
        {
            RunSelectedCommand();
        }
        private void APICallListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.runbutton.Text = "Run " + this.APICallListBox.SelectedItem.ToString();
        }
        #endregion

        public class CommandListBoxEntry
        {
            public string Name = string.Empty;
            public System.Type FormType = null;
            public CommandListBoxEntry(string name, System.Type formType)
            {
                this.Name = name;
                this.FormType = formType;
            }
            public override string ToString()
            {
                return this.Name;
            }
        }

        private void runbutton_Click(object sender, EventArgs e)
        {
            RunSelectedCommand();
        }
    }
}
