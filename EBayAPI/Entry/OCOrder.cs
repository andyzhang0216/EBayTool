using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBayAPI.Entry
{
    public class OCOrder
    {
        public string orderNo { get; set; }
        public double orderAmount { get; set; }
        public string consignee { get; set; }
        public string consigneeAddress { get; set; }
        public string consigneeTelephone { get; set; }
        public string consigneeCountry { get; set; }
        public string consigneeProvince { get; set; }
        public string consigneeCity { get; set; }
        public string consigneeZip { get; set; }
        public DateTime createTime { get; set; }
        public DateTime acttime { get; set; }
        public OCGoods goods { get; set; }
    }
}
