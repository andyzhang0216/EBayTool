using eBay.Service.Core.Sdk;
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
    public partial class ApiEndItem : Form
    {
        public ApiContext apiContext;
        public string a_itemId;
        public ApiEndItem()
        {
            InitializeComponent();
        }
    }
}
