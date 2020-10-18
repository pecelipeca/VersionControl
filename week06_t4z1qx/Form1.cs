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

        RichTextBox rtb1 = new RichTextBox();
        RichTextBox rtb2 = new RichTextBox();
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<currs> Currencies = new BindingList<currs>();
        public class currs
        {
            public string curr2 { get; set; }
        }
        
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Rates;
            GetCurrencies();
            comboBox1.DataSource = Currencies;
            RefreshDate();
        }

        private void GetCurrencies()
        {

            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetCurrenciesRequestBody();
            var response = mnbService.GetCurrencies(request);
            var result2 = response.GetCurrenciesResult;

            var xml = new XmlDocument();
            xml.LoadXml(result2);
            foreach (XmlElement element in xml.DocumentElement)
            {
                var curr = new currs();



                curr.curr2 = element.GetAttribute("curr");
                Currencies.Add(curr);

            }
            rtb2.Text = Currencies.ToString();
        }

        void GetExhangeRate()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = (comboBox1.SelectedItem).ToString(),
                startDate = (dateTimePicker1.Value).ToString(),
                endDate = (dateTimePicker2.Value).ToString()
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            rtb1.Text = result;
        }

        void xmlLoad()
        {
            var xml = new XmlDocument();
            xml.LoadXml(rtb1.Text.ToString());
            foreach (XmlElement x in xml.DocumentElement)
            {
                var rate = new RateData();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(x.GetAttribute("date"));

                var childElement = (XmlElement)x.ChildNodes[0];
                rate.Currency = childElement.GetAttribute("curr");
                if (childElement == null)
                    continue;
                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }

        }

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

        public void RefreshDate()
        {

            Rates.Clear();
            GetExhangeRate();
            xmlLoad();
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
