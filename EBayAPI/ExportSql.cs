using EBayAPI.Entry;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBayAPI
{
    public class ExportSql
    {
        public void ExportEbayOrder(List<OCOrder> list)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.CommandText = string.Format(OrderInsert);
            sqlComm.Parameters.Add("@orderNo", SqlDbType.NVarChar, 20);
            sqlComm.Parameters.Add("@orderAmount", SqlDbType.Money);
            sqlComm.Parameters.Add("@orderFreight", SqlDbType.Money);
            sqlComm.Parameters.Add("@consignee", SqlDbType.NVarChar, 100);
            sqlComm.Parameters.Add("@consigneeAddress", SqlDbType.NVarChar, 300);

            sqlComm.Parameters.Add("@consigneeTelephone", SqlDbType.NVarChar, 50);
            sqlComm.Parameters.Add("@consigneeCountry", SqlDbType.NVarChar, 100);
            sqlComm.Parameters.Add("@consigneeProvince", SqlDbType.NVarChar, 100);
            sqlComm.Parameters.Add("@consigneeCity", SqlDbType.NVarChar, 100);
            sqlComm.Parameters.Add("@consigneeZip", SqlDbType.NVarChar, 30);

            sqlComm.Parameters.Add("@createTime", SqlDbType.DateTime);
            sqlComm.Parameters.Add("@acttime", SqlDbType.DateTime);
            sqlComm.CommandType = CommandType.Text;
            sqlComm.Connection = sqlConn;
            sqlConn.Open();
            try
            {
                foreach (var o in list)
                {
                    try
                    {
                        sqlComm.Parameters["@orderNo"].Value = o.orderNo;
                        sqlComm.Parameters["@orderAmount"].Value = o.orderAmount;
                        sqlComm.Parameters["@orderFreight"].Value = 0;
                        sqlComm.Parameters["@consignee"].Value = o.consignee;
                        sqlComm.Parameters["@consigneeAddress"].Value = o.consigneeAddress;

                        sqlComm.Parameters["@consigneeTelephone"].Value = o.consigneeTelephone;
                        sqlComm.Parameters["@consigneeCountry"].Value = o.consigneeCountry;
                        sqlComm.Parameters["@consigneeProvince"].Value = o.consigneeProvince;
                        sqlComm.Parameters["@consigneeCity"].Value = o.consigneeCity;
                        sqlComm.Parameters["@consigneeZip"].Value = o.consigneeZip;

                        sqlComm.Parameters["@createTime"].Value = o.createTime;
                        sqlComm.Parameters["@acttime"].Value = o.acttime;

                        o.goods.goodsId = ExportEbayGoods(o.goods, o.orderNo);

                        sqlComm.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public int ExportEbayGoods(OCGoods good, string orderNo)
        {
            int value = 0;
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString);
            try
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandText = string.Format(GoodsInsert);
                sqlComm.Parameters.Add("@orderNo", SqlDbType.NVarChar, 20);
                sqlComm.Parameters.Add("@goodsName", SqlDbType.NVarChar, 300);
                sqlComm.CommandType = CommandType.Text;
                sqlComm.Connection = sqlConn;
                sqlConn.Open();

                sqlComm.Parameters["@goodsName"].Value = good.goodsName;
                sqlComm.Parameters["@orderNo"].Value = orderNo;

                SqlDataReader dr = sqlComm.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    value = (int)dr[0];
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlConn.Close();
            }
            return value;
        }

        string OrderInsert = "if not exists(select * from dbo.OC_Orders where orderNo = @orderNo)" +
            "insert into dbo.OC_Orders(orderNo, orderAmount, orderFreight, orderFreightCurrency, orderWeight, orderNetWeight, consignee, consigneeAddress, consigneeTelephone, consigneeCountry_Code, consigneeCountry, consigneeProvince, consigneeCity, consigneeZip, postalCountry_Code, loginticsFreight, logisticsFreightCurrency, insuredFee, insuredFeeCurrency, orderMark, wrapType, packNo, ieFlag, destinationPort, destinationCountry, logisticsNo, billNo, logistics_Id, shop_Id, orderState, createTime, acttime, orderMemo, orderSign, busines_Id, customs_OrderNo, ishavechild, parentId) values " +
                                    "(@orderNo,@orderAmount,@orderFreight, 1                   ,           1,              1,@consignee,@consigneeAddress,@consigneeTelephone,                     1,@consigneeCountry,@consigneeProvince,@consigneeCity,@consigneeZip,                '1',              '1',                        1,          1,                  1,         1,        1,      1,    '1',               1,                  1,         '1',    '1',            1,      16,          1,@createTime,@acttime,       '1',         1,          8,             '1',           1,        1)";
        string GoodsInsert = "if not exists(select * from dbo.OC_Orders where orderNo = @orderNo)" +
            "insert into dbo.OC_Goods(goodsName) output inserted.goodsId values" +
                                   "(@goodsName)";

    }
}
