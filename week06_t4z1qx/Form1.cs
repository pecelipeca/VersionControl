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
using week06_t4z1qx.Entities;
using week06_t4z1qx.MnbServiceReference;

namespace week06_t4z1qx
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        public Form1()
        {
            InitializeComponent();

            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            dataGridView1.DataSource = Rates;

            void xmlLoad()
            {
                var xml = new XmlDocument();
                xml.LoadXml(result);
                foreach (XmlElement x in xml.DocumentElement)
                {
                    var rate = new RateData();
                    Rates.Add(rate);

                    rate.Date = DateTime.Parse(x.GetAttribute("date"));

                    var childElement = (XmlElement)x.ChildNodes[0];
                    rate.Currency = childElement.GetAttribute("curr");

                    var unit = decimal.Parse(childElement.GetAttribute("unit"));
                    var value = decimal.Parse(childElement.InnerText);
                    if (unit != 0)
                        rate.Value = value / unit;
                }

            }
        }

    }
}
