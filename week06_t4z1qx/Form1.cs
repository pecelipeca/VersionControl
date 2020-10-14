using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using week06_t4z1qx.Entities;
using week06_t4z1qx.MnbServiceReference;

namespace week06_t4z1qx
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> Currencies = new BindingList<string>();
        
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Currencies;
            var getCurre = new GetCurrenciesRequest();
            RefreshDate();
        }


        public void RefreshDate()
        {

            Rates.Clear();
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = (comboBox1.SelectedItem).ToString(),
                startDate = (dateTimePicker1.Value).ToString(),
                endDate = (dateTimePicker2.Value).ToString()
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
            xmlLoad();

            void chartLoad()
            {
                chartRateData.DataSource = Rates;

                var series = chartRateData.Series[0];
                series.ChartType = SeriesChartType.Line;
                series.XValueMember = "Date";
                series.YValueMembers = "Value";
                series.BorderWidth = 2;

                var legend = chartRateData.Legends[0];
                legend.Enabled = false;

                var chartArea = chartRateData.ChartAreas[0];
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisY.MajorGrid.Enabled = false;
                chartArea.AxisY.IsStartedFromZero = false;
            }

            chartLoad();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshDate();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshDate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDate();
        }
    }
}
